using BIGADIC_COURSE.Classes;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;


namespace BIGADIC_COURSE
{
    public partial class FormMain : Form
    {
        public FormMain(User user)
        {
            InitializeComponent();
            _user = user;
        }

        StringBuilder query = new StringBuilder();
        StringBuilder idStr = new StringBuilder();
        List<SqlParameter> parameters = new List<SqlParameter>();
        List<Register> allRegistersList = new List<Register>();
        List<Register> birthDates = new List<Register>();
        Dictionary<int, string> selectionBranches = new Dictionary<int, string>();
        User? _user;
        Register? selectedRegister;
        string? statusDesc;
        string title = "BİGADİÇ GENÇLİK VE KÜLTÜR MERKEZİ";
        int titleIndex = 0;

        private async void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                timer.Enabled = true;
                timer.Start();

                // UI işlemlerini UI thread'de yapalım
                dateTimePickerRegisterDate.Value = DateTime.Now;
                dateTimePickerBirthDate.Value = DateTime.Now;
                dateTimePickerStartDate.Value = DateTime.Now;
                dateTimePickerEndDate.Value = DateTime.Now;

                // Admin kontrollerini UI thread'de yapalım
                if (_user.IsAdmin)
                {
                    importToolStripMenuItem.Visible = true;
                    adminPanelToolStripMenuItem.Visible = true;
                }

                await Task.Run(async () =>
                {
                    await GetCourses();  // GetCourses'in tamamlanmasını bekle
                    await RefreshData();       // GetCourses tamamlandıktan sonra çalıştır

                    DeleteOldExportDatas();
                    GetBirthDates(false);
                }).ContinueWith(task =>
                {
                    // RefreshData ve diğer işlemler bittikten sonra çalıştır
                    GetCourseCount();
                }, TaskScheduler.FromCurrentSynchronizationContext()); // UI thread üzerinde çalışmasını sağla


            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormMain_Load Error Hata Kodu: 2000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dialogResult != DialogResult.Yes) // evet dışında bir seçenek seçildiyse kapatılma event'i iptal edilir
                    e.Cancel = true;

                _user = null;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormMain_FormClosing Error Hata Kodu: 2001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonMale.Checked || radioButtonFemale.Checked)
                {
                    if (dateTimePickerBirthDate.Value.Date != DateTime.Now.Date)
                    {
                        Sql sql = new Sql();
                        query.Clear();
                        parameters.Clear();

                        var list = new List<KeyValuePair<int, string>>(selectionBranches);

                        if (list.Count > 0)
                        {
                            for (int i = 0; i < list.Count; i++) // seçilen her branş için kayıt ekler
                            {
                                query.Append($@"IF NOT EXISTS (SELECT TOP 1 * FROM TRAINEES WHERE (NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) OR TCKN = @Tckn{i + 1})
                            AND NOT EXISTS (SELECT TOP 1 * FROM COURSEREGISTER WHERE TRAINEE_ID = (SELECT TOP 1 ID FROM TRAINEES WHERE NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) AND COURSE_ID = @BranchId{i + 1})
                            BEGIN
	                            INSERT INTO TRAINEES (NAME, SURNAME, TCKN, BIRTHDATE, PHONE, GENDER, REGISTER_DATE)
	                            VALUES (@Name{i + 1}, @Surname{i + 1}, @Tckn{i + 1}, @BirthDate{i + 1}, @Phone{i + 1}, @Gender{i + 1}, @RegisterDate{i + 1})
                                INSERT INTO COURSEREGISTER (TRAINEE_ID, COURSE_ID, STATUS, REGISTER_DATE)
	                            VALUES ((SELECT TOP 1 ID FROM TRAINEES WHERE (NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) OR TCKN = @Tckn{i + 1}), @BranchId{i + 1}, 'B', @RegisterDate{i + 1})
                            END 
                            ELSE IF NOT EXISTS (SELECT TOP 1 * FROM COURSEREGISTER WHERE TRAINEE_ID = (SELECT TOP 1 ID FROM TRAINEES WHERE NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) AND COURSE_ID = @BranchId{i + 1})
                            BEGIN 
	                            INSERT INTO COURSEREGISTER (TRAINEE_ID, COURSE_ID, STATUS, REGISTER_DATE)
	                            VALUES ((SELECT TOP 1 ID FROM TRAINEES WHERE (NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) OR TCKN = @Tckn{i + 1}), @BranchId{i + 1}, 'B', @RegisterDate{i + 1})
                            END
                            ELSE
                            BEGIN 
	                            SELECT 'MEVCUT KAYIT BULUNMAKTADIR'
                            END
                            ");

                                parameters.Add(new Microsoft.Data.SqlClient.SqlParameter($"@Name{i + 1}", SqlDbType.NVarChar, 50) { Value = textBoxName.Text.Trim().ToUpper() });
                                parameters.Add(new SqlParameter($"@Surname{i + 1}", SqlDbType.NVarChar, 50) { Value = textBoxSurname.Text.Trim().ToUpper() });
                                parameters.Add(new SqlParameter($"@Tckn{i + 1}", SqlDbType.Char, 11) { Value = maskedTextBoxTckn.Text.Trim() });
                                parameters.Add(new SqlParameter($"@BirthDate{i + 1}", SqlDbType.Date) { Value = dateTimePickerBirthDate.Value });
                                parameters.Add(new SqlParameter($"@Phone{i + 1}", SqlDbType.Char, 10) { Value = maskedTextBoxPhone.Text.Trim() });
                                parameters.Add(new SqlParameter($"@Gender{i + 1}", SqlDbType.Bit) { Value = radioButtonMale.Checked ? 1 : 0 });
                                parameters.Add(new SqlParameter($"@RegisterDate{i + 1}", SqlDbType.Date) { Value = dateTimePickerRegisterDate.Value });
                                parameters.Add(new SqlParameter($"@BranchId{i + 1}", SqlDbType.Int) { Value = list[i].Key });
                            }
                            int id = -1;
                            int returnCode = await sql.EditData(query.ToString(), parameters);

                            switch (returnCode) // işlem sonucunu kontrol eder
                            {
                                case -1:
                                    Log.logger.Error("buttonRegister_Click Error EditData Hatası. Hata Kodu: 2002");
                                    MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 0:
                                    Log.logger.Error("buttonRegister_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 2003");
                                    MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 1:
                                    Log.logger.Info($"Yeni kurs kaydı başarıyla yapıldı. {maskedTextBoxTckn.Text}");
                                    if (allRegistersList.Count > 0)
                                        id = allRegistersList.LastOrDefault()?.ID ?? -1;

                                    await Task.Run(async () =>
                                    {
                                        await RefreshData();
                                    });

                                    // UI işlemlerini senkron yerine async olarak çağır
                                    await Task.Yield(); // UI thread'in kilitlenmesini önler
                                    GetCourseCount();
                                    await Task.Run(() => GetNewRegisters(id));
                                    ChangeEnableRadioButtons(0);

                                    buttonRegister.Enabled = false;
                                    MessageBox.Show($"Kayıt(lar) Başarılıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case 2:
                                    Log.logger.Info($"Kurs zaten kayıtlı. {maskedTextBoxTckn.Text}");
                                    MessageBox.Show($"Eklemek İstediğiniz Kayıt Veri Tabanında Mevcut", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Lütfen Bir Kurs Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Doğum Tarihi Bugün Olamaz.\n\nLütfen Geçerli Bir Tarih Yazınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lütfen Cinsiyet Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonRegister_Click Error Hata Kodu: 2004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty || textBoxSurname.Text != string.Empty || maskedTextBoxTckn.Text != string.Empty)
                {
                    listViewAllRegister.Items.Clear();
                    var searchedRegisters = allRegistersList.FindAll(r => r.NAME.Contains(textBoxName.Text) && r.SURNAME.Contains(textBoxSurname.Text) && r.TCKN.Contains(maskedTextBoxTckn.Text));

                    if (searchedRegisters.Count > 0) // aranan değerlere uygun kayıt/lar varsa
                    {
                        foreach (var register in searchedRegisters)
                        {
                            idStr.Clear();
                            if (register.ID < 10)
                                idStr.Append($"GKM000{register.ID}");
                            else if (register.ID < 100)
                                idStr.Append($"GKM00{register.ID}");
                            else if (register.ID < 1000)
                                idStr.Append($"GKM0{register.ID}");
                            else
                                idStr.Append($"GKM{register.ID}");

                            ListViewItem item = new ListViewItem(idStr.ToString());
                            item.SubItems.Add(register.TCKN);
                            item.SubItems.Add(register.NAME);
                            item.SubItems.Add(register.SURNAME);
                            item.SubItems.Add(register.COURSE);
                            item.SubItems.Add(register.BIRTHDATE.ToString("dd-MM-yyyy"));
                            item.SubItems.Add(register.PHONE);
                            item.SubItems.Add(register.REGISTERDATE.ToString("dd-MM-yyyy"));
                            item.SubItems.Add(register.STATUS);
                            listViewAllRegister.Items.Add(item);
                        }
                        ChangeEnableRadioButtons(1);
                    }
                    else
                        MessageBox.Show("Aranan Kayıt Bulunamadı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Arama Yapabilmek İçin Ad-Soyad veya TC Kimlik No Alanlarını Doldurunuz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonSearch_Click Error Hata Kodu: 2005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirm = true;
                bool gender = radioButtonMale.Checked ? true : false;
                char status = '\0';

                if (radioButtonActive.Checked)
                    status = 'A';
                else if (radioButtonPassive.Checked)
                    status = 'P';
                else if (radioButtonWaiting.Checked)
                    status = 'B';

                if (selectedRegister != null && selectedRegister.NAME == textBoxName.Text && selectedRegister.SURNAME == textBoxSurname.Text && selectedRegister.PHONE == maskedTextBoxPhone.Text
                 && selectedRegister.TCKN == maskedTextBoxTckn.Text && selectedRegister.BIRTHDATE == dateTimePickerBirthDate.Value
                 && selectedRegister.GENDER == gender && selectedRegister.STATUS == status.ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("Hiçbir Değer Değiştirilmedi. Güncellemek İstiyor Musunuz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult != DialogResult.Yes)
                        confirm = false;
                }

                if (confirm)
                {
                    Sql sql = new Sql();
                    int id = int.Parse(listViewAllRegister.SelectedItems[0].Text.Substring(3));

                    query.Clear();
                    query.Append(@"UPDATE TRAINEES SET NAME = @Name, SURNAME = @Surname, TCKN = @Tckn, BIRTHDATE = @Birthdate, PHONE = @Phone, GENDER = @Gender WHERE ID = @TraineeId;
                UPDATE COURSEREGISTER SET COURSE_ID = @CourseId, STATUS = @Status WHERE ID = @RegisterId;");

                    parameters.Clear();
                    parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = textBoxName.Text.Trim().ToUpper() });
                    parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50) { Value = textBoxSurname.Text.Trim().ToUpper() });
                    parameters.Add(new SqlParameter("@Tckn", SqlDbType.Char, 11) { Value = maskedTextBoxTckn.Text.Trim() });
                    parameters.Add(new SqlParameter("@Birthdate", SqlDbType.Date) { Value = dateTimePickerBirthDate.Value });
                    parameters.Add(new SqlParameter("@Phone", SqlDbType.Char, 10) { Value = maskedTextBoxPhone.Text.Trim() });
                    parameters.Add(new SqlParameter("@Gender", SqlDbType.Bit) { Value = radioButtonMale.Checked == true ? 1 : 0 });
                    parameters.Add(new SqlParameter("@TraineeId", SqlDbType.Int) { Value = allRegistersList.FirstOrDefault(r => r.ID == id)?.TRAINEEID ?? -1 });
                    parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int) { Value = allRegistersList.FirstOrDefault(r => r.ID == id)?.COURSEID ?? -1 });
                    parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1) { Value = status });
                    parameters.Add(new SqlParameter("@RegisterId", SqlDbType.Int) { Value = id });

                    int returnCode = await sql.EditData(query.ToString(), parameters);
                    switch (returnCode)
                    {
                        case 0:
                            Log.logger.Error("buttonUpdate_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 2006");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2006", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            Log.logger.Info($"Kayıt başarıyla güncellendi. {maskedTextBoxTckn.Text}");

                            await Task.Run(async () =>
                            {
                                await RefreshData();
                            });

                            // UI işlemlerini senkron yerine async olarak çağır
                            await Task.Yield(); // UI thread'in kilitlenmesini önler
                            await Task.Run(() => GetUpdatedRegister(id));
                            ChangeEnableRadioButtons(0);

                            buttonUpdate.Enabled = false;
                            buttonDelete.Enabled = false;
                            flowLayoutPanelBranches.Enabled = true;
                            MessageBox.Show($"Kayıt Başarılıyla Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case -1:
                            Log.logger.Error("buttonUpdate_Click Error EditData Hatası. Hata Kodu: 2007");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2007", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonUpdate_Click Error Hata Kodu: 2008 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2008", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e) // kurs kaydı veri tabanından silinir
        {
            try
            {
                if (textBoxName.Text != null && textBoxSurname.Text != null && maskedTextBoxTckn.Text != null && maskedTextBoxPhone.Text != null && listViewAllRegister.SelectedItems != null)
                {
                    // onay istenir
                    DialogResult dialogResult = MessageBox.Show("Seçili Kaydı Silmek İstiyor Musunuz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) // onay verilirse
                    {
                        Sql sql = new Sql();

                        query.Clear();
                        query.Append("DELETE FROM COURSEREGISTER WHERE ID = @Id;");

                        parameters.Clear();
                        parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = int.Parse(listViewAllRegister.SelectedItems[0].Text.Substring(3)) });

                        int returnCode = await sql.EditData(query.ToString(), parameters);

                        switch (returnCode)
                        {
                            case 0:
                                Log.logger.Error("buttonDelete_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 2009");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2009", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Kayıt Başarıyla Silindi. {maskedTextBoxTckn.Text} - {textBoxSelectionBranches.Text}");

                                await Task.Run(async () =>
                                {
                                    await RefreshData();
                                });

                                // UI işlemlerini senkron yerine async olarak çağır
                                await Task.Yield(); // UI thread'in kilitlenmesini önler
                                GetCourseCount();
                                ChangeEnableRadioButtons(0);

                                buttonOrder_Click(sender, e); // listview'ın değerleri güncellenir
                                textBoxId.Text = string.Empty;
                                textBoxName.Text = string.Empty;
                                textBoxSurname.Text = string.Empty;
                                maskedTextBoxPhone.Text = string.Empty;
                                maskedTextBoxTckn.Text = string.Empty;
                                textBoxSelectionBranches.Text = string.Empty;
                                buttonUpdate.Enabled = false;
                                buttonDelete.Enabled = false;
                                flowLayoutPanelBranches.Enabled = true;
                                MessageBox.Show($"Kayıt Başarıyla Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("buttonDelete_Click Error EditData Hatası. Hata Kodu: 2010");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2010", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                }
                else
                    MessageBox.Show("Alanlar Boş Olup Olmadığını ve Listeden Seçim Yapıldığını Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonDelete_Click Error Hata Kodu: 2011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) // bütün text'leri temizledi
        {
            try
            {
                textBoxId.Text = string.Empty; //$"BGM{(allRegistersList.OrderByDescending(r => r.ID).ToList()[0].ID + 1)}";
                textBoxName.Text = string.Empty;
                textBoxSurname.Text = string.Empty;
                maskedTextBoxTckn.Text = string.Empty;
                maskedTextBoxPhone.Text = string.Empty;
                dateTimePickerBirthDate.Value = DateTime.Now;
                dateTimePickerRegisterDate.Value = DateTime.Now;
                radioButtonFemale.Checked = false;
                radioButtonMale.Checked = false;
                radioButtonActive.Checked = false;
                radioButtonPassive.Checked = false;
                radioButtonWaiting.Checked = false;
                radioButtonTotal.Checked = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                buttonRegister.Enabled = false;
                flowLayoutPanelBranches.Enabled = true;

                List<CheckBox> checkBoxes = flowLayoutPanelBranches.Controls.OfType<CheckBox>().Where(c => c.Checked == true).ToList();
                checkBoxes.ForEach(checkBox => { checkBox.Checked = false; });

                listViewAllRegister.Items.Clear();
                ChangeEnableRadioButtons(0);

                textBoxName.Focus();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonClear_Click Error Hata Kodu: 2012 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2012", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e) // veri tabanındaki bütün kurs kayıtları listeler
        {
            try
            {
                buttonClear_Click(sender, e);
                listViewAllRegister.Items.Clear();
                if (checkBoxSelectDate.Checked)
                {
                    var registers = allRegistersList.FindAll(r => r.REGISTERDATE >= dateTimePickerStartDate.Value && r.REGISTERDATE <= dateTimePickerEndDate.Value);
                    foreach (var register in registers)
                    {
                        idStr.Clear();
                        if (register.ID < 10)
                            idStr.Append($"GKM000{register.ID}");
                        else if (register.ID < 100)
                            idStr.Append($"GKM00{register.ID}");
                        else if (register.ID < 1000)
                            idStr.Append($"GKM0{register.ID}");
                        else
                            idStr.Append($"GKM{register.ID}");

                        ListViewItem item = new ListViewItem(idStr.ToString());
                        item.SubItems.Add(register.TCKN);
                        item.SubItems.Add(register.NAME);
                        item.SubItems.Add(register.SURNAME);
                        item.SubItems.Add(register.COURSE);
                        item.SubItems.Add(register.BIRTHDATE.ToString("dd-MM-yyyy"));
                        item.SubItems.Add(register.PHONE);
                        item.SubItems.Add(register.REGISTERDATE.ToString("dd-MM-yyyy"));
                        item.SubItems.Add(register.STATUS);
                        listViewAllRegister.Items.Add(item);
                    }
                }
                else
                {
                    foreach (var register in allRegistersList)
                    {
                        idStr.Clear();
                        if (register.ID < 10)
                            idStr.Append($"GKM000{register.ID}");
                        else if (register.ID < 100)
                            idStr.Append($"GKM00{register.ID}");
                        else if (register.ID < 1000)
                            idStr.Append($"GKM0{register.ID}");
                        else
                            idStr.Append($"GKM{register.ID}");

                        ListViewItem item = new ListViewItem(idStr.ToString());
                        item.SubItems.Add(register.TCKN);
                        item.SubItems.Add(register.NAME);
                        item.SubItems.Add(register.SURNAME);
                        item.SubItems.Add(register.COURSE);
                        item.SubItems.Add(register.BIRTHDATE.ToString("dd-MM-yyyy"));
                        item.SubItems.Add(register.PHONE);
                        item.SubItems.Add(register.REGISTERDATE.ToString("dd-MM-yyyy"));
                        item.SubItems.Add(register.STATUS);
                        listViewAllRegister.Items.Add(item);
                    }
                }
                ChangeEnableRadioButtons(1);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonOrder_Click Error Hata Kodu: 2013 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2013", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCharts formChart = new FormCharts(allRegistersList);
                formChart.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"graphicToolStripMenuItem_Click Error Hata Kodu: 2014 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2014", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddBranch formBranch = new FormAddBranch();
                formBranch.ShowDialog();
                await GetCourses();
                GetCourseCount();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"addBranchToolStripMenuItem_Click Error Hata Kodu: 2015 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2015", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAdminPanel formAdminPanel = new FormAdminPanel();
                formAdminPanel.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"adminPanelToolStripMenuItem_Click Error Hata Kodu: 2016 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2016", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormPersonel formPersonel = new FormPersonel();
                formPersonel.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"exitToolStripMenuItem_Click Error Hata Kodu: 2017 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2017", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddedBranch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox? checkBox = sender as CheckBox;
                if (checkBox != null && checkBox.Checked) // checkbox tiklenirse seçilen branşlar text'ine ve listesine eklenir  
                {
                    if (textBoxSelectionBranches.Text != string.Empty)
                        textBoxSelectionBranches.Text += ",";
                    textBoxSelectionBranches.Text += checkBox.Text;
                    selectionBranches.Add(int.Parse(checkBox.Tag?.ToString() ?? "-1"), checkBox.Text);
                    checkBox.ForeColor = Color.Red;
                }
                else if (checkBox != null)// checkbox'ın tiki kaldırılırsa seçilen branşlar text'inden ve listesinden çıkartılır
                {
                    textBoxSelectionBranches.Text = textBoxSelectionBranches.Text.Replace(checkBox.Text, string.Empty);
                    textBoxSelectionBranches.Text = textBoxSelectionBranches.Text.Replace(",,", ",");
                    selectionBranches.Remove(int.Parse(checkBox.Tag?.ToString() ?? "-1"));
                    checkBox.ForeColor = Color.Black;

                    if (textBoxSelectionBranches.Text.Length > 0 && textBoxSelectionBranches.Text[0] == ',') // textbox'ın başında kalan virgülü siler
                        textBoxSelectionBranches.Text = textBoxSelectionBranches.Text.Remove(0, 1);
                    if (textBoxSelectionBranches.Text.Length > 0 && textBoxSelectionBranches.Text[textBoxSelectionBranches.Text.Length - 1] == ',') // textbox'ın sonunda kalan virgülü siler
                        textBoxSelectionBranches.Text = textBoxSelectionBranches.Text.Remove(textBoxSelectionBranches.Text.Length - 1, 1);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"AddedBranch_CheckedChanged Error Hata Kodu: 2018 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2018", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                Sql sql = new Sql();
                query.Clear();
                query.Append(@"
                SELECT R.ID, T.TCKN, T.NAME, T.SURNAME, C.NAME AS COURSENAME, R.REGISTER_DATE, R.STATUS, 
                       T.GENDER, T.PHONE, T.BIRTHDATE, C.ID AS COURSEID, T.ID AS TRAINEEID
                FROM COURSEREGISTER R
                INNER JOIN TRAINEES T ON T.ID = R.TRAINEE_ID
                INNER JOIN COURSES C ON C.ID = R.COURSE_ID;
                ");

                DataTable? allRegister = await sql.GetFromDb(query.ToString());

                // Yeni yöntem: Daha hızlı listeye çevirme
                if (allRegister != null)
                {
                    allRegistersList = allRegister.AsEnumerable().Select(register =>
                    {
                        string status = register.Field<string>("STATUS");
                        string statusDesc;

                        switch (status)
                        {
                            case "A":
                                statusDesc = "AKTİF";
                                break;
                            case "B":
                                statusDesc = "BEKLEYEN";
                                break;
                            case "P":
                                statusDesc = "PASİF";
                                break;
                            default:
                                statusDesc = "BİLİNMİYOR";
                                break;
                        }

                        return new Register
                        {
                            ID = register.Field<int>("ID"),
                            TCKN = register.Field<string>("TCKN"),
                            NAME = register.Field<string>("NAME"),
                            SURNAME = register.Field<string>("SURNAME"),
                            COURSE = register.Field<string>("COURSENAME"),
                            REGISTERDATE = register.Field<DateTime>("REGISTER_DATE"),
                            STATUS = status,
                            GENDER = register.Field<bool>("GENDER"),
                            PHONE = register.Field<string>("PHONE"),
                            BIRTHDATE = register.Field<DateTime>("BIRTHDATE"),
                            COURSEID = register.Field<int>("COURSEID"),
                            TRAINEEID = register.Field<int>("TRAINEEID"),
                            GENDERDESC = register.Field<bool>("GENDER") ? "Erkek" : "Kadın",
                            STATUSDESC = statusDesc
                        };
                    }).ToList();
                }
                // UI güncellemelerini ana thread'de yap
                textBoxTotalRegister.Invoke((MethodInvoker)(() =>
                    textBoxTotalRegister.Text = allRegistersList.Count.ToString()));

                textBoxActiveRegisters.Invoke((MethodInvoker)(() =>
                    textBoxActiveRegisters.Text = allRegistersList.Count(r => r.STATUS == "A").ToString()));

                textBoxPassiveRegisters.Invoke((MethodInvoker)(() =>
                    textBoxPassiveRegisters.Text = allRegistersList.Count(r => r.STATUS == "P").ToString()));

                textBoxWaitingRegisters.Invoke((MethodInvoker)(() =>
                    textBoxWaitingRegisters.Text = allRegistersList.Count(r => r.STATUS == "B").ToString()));

                textBoxMale.Invoke((MethodInvoker)(() =>
                    textBoxMale.Text = allRegistersList.Count(r => r.GENDER).ToString()));

                textBoxFemale.Invoke((MethodInvoker)(() =>
                    textBoxFemale.Text = allRegistersList.Count(r => !r.GENDER).ToString()));
            }
            catch (Exception ex)
            {
                Log.logger.Error($"RefreshData Error Hata Kodu: 2019 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2019", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAllRegister_Click(object sender, EventArgs e)
        {
            try
            {
                List<CheckBox> allCheckBoxes = flowLayoutPanelBranches.Controls.OfType<CheckBox>().ToList(); // bütün checkbox'ların tiki kaldırılır
                foreach (var check in allCheckBoxes)
                    check.Checked = false;

                int id = int.Parse(listViewAllRegister.SelectedItems[0].Text.Substring(3));

                idStr.Clear();
                if (id < 10)
                    idStr.Append($"GKM000{id}");
                else if (id < 100)
                    idStr.Append($"GKM00{id}");
                else if (id < 1000)
                    idStr.Append($"GKM0{id}");
                else
                    idStr.Append($"GKM{id}");

                textBoxId.Text = idStr.ToString();
                textBoxName.Text = allRegistersList.FirstOrDefault(r => r.ID == id).NAME;
                textBoxSurname.Text = allRegistersList.FirstOrDefault(r => r.ID == id).SURNAME;
                maskedTextBoxTckn.Text = allRegistersList.FirstOrDefault(r => r.ID == id).TCKN;
                maskedTextBoxPhone.Text = allRegistersList.FirstOrDefault(r => r.ID == id).PHONE;
                dateTimePickerBirthDate.Value = allRegistersList.FirstOrDefault(r => r.ID == id).BIRTHDATE;
                dateTimePickerRegisterDate.Value = allRegistersList.FirstOrDefault(r => r.ID == id).REGISTERDATE;

                if (allRegistersList.FirstOrDefault(r => r.ID == id).GENDER)
                    radioButtonMale.Checked = true;
                else
                    radioButtonFemale.Checked = true;

                switch (allRegistersList.FirstOrDefault(r => r.ID == id).STATUS)
                {
                    case "A":
                        radioButtonActive.Checked = true;
                        break;
                    case "B":
                        radioButtonWaiting.Checked = true;
                        break;
                    case "P":
                        radioButtonPassive.Checked = true;
                        break;
                }

                //textBoxSelectionBranches.Text = allRegistersList.FirstOrDefault(r => r.ID == id).COURSE;
                CheckBox checkBox = flowLayoutPanelBranches.Controls.OfType<CheckBox>()
                                        .FirstOrDefault(c => c.Tag.ToString() == allRegistersList.FirstOrDefault(r => r.ID == id).COURSEID.ToString());
                checkBox.Checked = true;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                flowLayoutPanelBranches.Enabled = false;

                selectedRegister = new Register
                {
                    ID = id,
                    NAME = textBoxName.Text,
                    SURNAME = textBoxSurname.Text,
                    TCKN = maskedTextBoxTckn.Text,
                    PHONE = maskedTextBoxPhone.Text,
                    BIRTHDATE = dateTimePickerBirthDate.Value,
                    GENDER = radioButtonMale.Checked ? true : false,
                    STATUS = allRegistersList.FirstOrDefault(r => r.ID == id).STATUS
                };
            }
            catch (Exception ex)
            {
                Log.logger.Error($"listViewAllRegister_Click Error Hata Kodu: 2020 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2020", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExportPdf_Click(object sender, EventArgs e) // listview'daki kayıtları tablo şeklinde pdf'e yazar
        {
            try
            {
                string pdfPath = Path.Combine(Application.StartupPath, $"list_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf");

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new(pdf);

                        Table table = new Table(7);
                        table.AddCell("ID");
                        table.AddCell("T.C. No");
                        table.AddCell("Adı");
                        table.AddCell("Soyadı");
                        table.AddCell("Branş");
                        table.AddCell("Kayıt Tarihi");
                        table.AddCell("Durumu");

                        for (int i = 0; i < listViewAllRegister.Items.Count; i++)
                        {
                            table.AddCell(listViewAllRegister.Items[i].SubItems[0].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[1].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[2].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[3].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[4].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[5].Text);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[6].Text);
                        }

                        document.Add(table);
                        document.Close();
                    }
                }
                MessageBox.Show("Kayıtlar Pdf Dosyasına Aktarıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer",
                    Arguments = $"\"{pdfPath}\"",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonExportExcel_Click Error Hata Kodu: 2021 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2021", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)sender;
                    textBox.BackColor = Color.Yellow;
                }
                else if (sender.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox textBox = (MaskedTextBox)sender;
                    textBox.BackColor = Color.Yellow;
                    textBox.SelectionStart = 0;
                    textBox.SelectionLength = 0;
                }
                else if (sender.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)sender;
                    dateTimePicker.CalendarMonthBackground = Color.Yellow;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_Enter Error Hata Kodu: 2022 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2022", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)sender;
                    textBox.BackColor = Color.White;
                    textBox.Text = textBox.Text.Trim().ToUpper();
                }
                else if (sender.GetType() == typeof(MaskedTextBox))
                {
                    MaskedTextBox textBox = (MaskedTextBox)sender;
                    textBox.BackColor = Color.White;
                    if (textBox.Name == "maskedTextBoxTckn" && textBox.Text.Length != 11)
                    {
                        MessageBox.Show("Kimlik Numarası 11 Karakter Olmalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Focus();
                    }
                }
                else if (sender.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)sender;
                    dateTimePicker.CalendarMonthBackground = Color.White;
                    if (dateTimePicker.Value.Date >= DateTime.Now.Date)
                    {
                        MessageBox.Show("Doğum Gününü Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dateTimePicker.Focus();
                    }
                }
                if (textBoxName.Text != string.Empty && textBoxSurname.Text != string.Empty && maskedTextBoxTckn.Text != string.Empty)
                    buttonRegister.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_Enter Error Hata Kodu: 2023 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2023", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormDeleteBranch formBranch = new FormDeleteBranch();
                formBranch.ShowDialog();
                await GetCourses();
                GetCourseCount();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"deleteBranchToolStripMenuItem_Click Error Hata Kodu: 2024 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2024", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetCourses()
        {
            try
            {
                Sql sql = new Sql();
                query.Clear();
                query.Append("SELECT * FROM COURSES WHERE TYPE <> 1 OR TYPE IS NULL;");

                DataTable branchesTable = await sql.GetFromDb(query.ToString()); // veri tabanından bütün branşlar çekilir

                // UI thread'ine gönderiyoruz
                if (flowLayoutPanelBranches.InvokeRequired)
                {
                    flowLayoutPanelBranches.Invoke(new Action(() =>
                    {
                        flowLayoutPanelBranches.Controls.Clear(); // branşları eklenmeden bütün kurslar temizlenir
                        foreach (DataRow branch in branchesTable.Rows) // veri tabanından çekilen bütün branşlar flowlayoutpanel'a eklenir
                        {
                            GroupBox groupBox = new();
                            groupBox.Text = string.Empty;
                            groupBox.Tag = branch.ItemArray[0];
                            groupBox.Name = $"groupBox{branch.ItemArray[0]}";
                            groupBox.Size = new Size(180, 50);

                            CheckBox addedBranch = new CheckBox();
                            groupBox.Controls.Add(addedBranch);
                            addedBranch.Text = branch.ItemArray[1].ToString();
                            addedBranch.Name = $"checkBox{branch.ItemArray[0]}";
                            addedBranch.Tag = branch.ItemArray[0];
                            addedBranch.Location = new Point(10, 15);
                            addedBranch.ForeColor = Color.Black;
                            addedBranch.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                            addedBranch.CheckedChanged += AddedBranch_CheckedChanged;

                            Label label = new Label();
                            groupBox.Controls.Add(label);
                            label.Text = "....";
                            label.Location = new Point(125, 15);
                            label.ForeColor = Color.Red;
                            label.Name = $"label{branch.ItemArray[0]}";
                            label.Tag = branch.ItemArray[0];

                            flowLayoutPanelBranches.Controls.Add(groupBox);
                        }
                    }));
                }
                else
                {
                    flowLayoutPanelBranches.Controls.Clear(); // branşları eklenmeden bütün kurslar temizlenir
                    foreach (DataRow branch in branchesTable.Rows) // veri tabanından çekilen bütün branşlar flowlayoutpanel'a eklenir
                    {
                        GroupBox groupBox = new();
                        groupBox.Text = string.Empty;
                        groupBox.Tag = branch.ItemArray[0];
                        groupBox.Name = $"groupBox{branch.ItemArray[0]}";
                        groupBox.Size = new Size(180, 50);

                        CheckBox addedBranch = new CheckBox();
                        groupBox.Controls.Add(addedBranch);
                        addedBranch.Text = branch.ItemArray[1].ToString();
                        addedBranch.Name = $"checkBox{branch.ItemArray[0]}";
                        addedBranch.Tag = branch.ItemArray[0];
                        addedBranch.Location = new Point(10, 15);
                        addedBranch.ForeColor = Color.Black;
                        addedBranch.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                        addedBranch.CheckedChanged += AddedBranch_CheckedChanged;

                        Label label = new Label();
                        groupBox.Controls.Add(label);
                        label.Text = "....";
                        label.Location = new Point(125, 15);
                        label.ForeColor = Color.Red;
                        label.Name = $"label{branch.ItemArray[0]}";
                        label.Tag = branch.ItemArray[0];

                        flowLayoutPanelBranches.Controls.Add(groupBox);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourses Error Hata Kodu: 2025 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2025", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<GroupBox> groupboxes = flowLayoutPanelBranches.Controls.OfType<GroupBox>().ToList();
                List<CheckBox> checkBoxes = new();
                foreach (GroupBox groupbox in groupboxes) 
                {
                    checkBoxes.AddRange(groupbox.Controls.OfType<CheckBox>());
                }
                FormReport formReport = new FormReport(allRegistersList, checkBoxes);
                formReport.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"reportToolStripMenuItem_Click Error Hata Kodu: 2026 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2026", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetCourseCount()
        {
            try
            {
                // Kurs ID'lerine göre grup oluşturalım
                var courseCounts = allRegistersList.GroupBy(r => r.COURSEID)
                                                   .ToDictionary(g => g.Key, g => g.Count());

                foreach (GroupBox groupBox in flowLayoutPanelBranches.Controls.OfType<GroupBox>())
                {
                    foreach (Label label in groupBox.Controls.OfType<Label>())
                    {
                        if (label.Tag != null && int.TryParse(label.Tag.ToString(), out int courseId))
                        {
                            label.Text = courseCounts.ContainsKey(courseId) ? courseCounts[courseId].ToString() : "0";
                            label.Refresh();  // Zorla güncelle  
                        }
                    }                    
                }
                //Application.DoEvents(); // UI'yi güncelle

            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourseCount Error Hata Kodu: 2027 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2027", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                    SendKeys.Send("{Tab}");
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_KeyDown Error Hata Kodu: 2028 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2028", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox_Click(object sender, EventArgs e) // seçilen maskedtextbox'ın 0. indisine odaklanır
        {
            try
            {
                MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
                maskedTextBox.SelectionStart = 0;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"maskedTextBox_Click Error Hata Kodu: 2029 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2029", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUpdatedRegister(int id)
        {
            try
            {
                listViewAllRegister.Items.Clear();
                idStr.Clear();

                // ID'ye göre ilgili kaydı bul
                var register = allRegistersList.FirstOrDefault(r => r.ID == id);

                if (register == null)
                {
                    MessageBox.Show("Kayıt bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // ID formatını belirle
                if (register.ID < 10)
                    idStr.Append($"GKM000{register.ID}");
                else if (register.ID < 100)
                    idStr.Append($"GKM00{register.ID}");
                else if (register.ID < 1000)
                    idStr.Append($"GKM0{register.ID}");
                else
                    idStr.Append($"GKM{register.ID}");

                // ListViewItem oluştur
                ListViewItem item = new ListViewItem(idStr.ToString());
                item.SubItems.Add(register.TCKN);
                item.SubItems.Add(register.NAME);
                item.SubItems.Add(register.SURNAME);
                item.SubItems.Add(register.COURSE);
                item.SubItems.Add(register.BIRTHDATE.ToString("dd-MM-yyyy"));
                item.SubItems.Add(register.PHONE);
                item.SubItems.Add(register.REGISTERDATE.ToString("dd-MM-yyyy"));
                item.SubItems.Add(register.STATUS);

                listViewAllRegister.Items.Add(item);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetUpdatedRegister Error Hata Kodu: 2030 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2030", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteOldExportDatas()
        {
            try
            {

                string excelPath = Application.StartupPath + "ExportExcel\\";
                if (!Directory.Exists(excelPath))
                    Directory.CreateDirectory(excelPath);

                var allExcelFiles = Directory.GetFiles(excelPath);
                if (allExcelFiles.Length > 0)
                {
                    foreach (var file in allExcelFiles)
                    {
                        if (File.GetLastWriteTime(file) < DateTime.Now.AddDays(-7))
                            File.Delete(file);
                    }
                }

                string pdfPath = Application.StartupPath + "\\ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                var allPdfFiles = Directory.GetFiles(pdfPath);
                if (allPdfFiles.Length > 0)
                {
                    foreach (var file in allPdfFiles)
                    {
                        if (File.GetLastWriteTime(file) < DateTime.Now.AddDays(-7))
                            File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"maskedTextBox_Click Error Hata Kodu: 2031 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2031", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                WriteToExcel();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonBackup_Click Error Hata Kodu: 2032 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2032", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteToExcel()
        {
            try
            {
                int row = 2;
                string excelPath = "D:\\Backup BGM\\";
                bool errorCode = false;
                try
                {
                    if (!Directory.Exists(excelPath))
                        Directory.CreateDirectory(excelPath);
                }
                catch (Exception ex)
                {
                    errorCode = true;
                    Log.logger.Error($"WriteToExcel path Error Hata Kodu: 2033 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                    MessageBox.Show("D Diski Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!errorCode) // hata verdiyse çalıştırmaz
                {
                    excelPath += $"backup{DateTime.Now.Date:yyyy_MM_dd}.xlsx";

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                    using (var package = new ExcelPackage(new FileInfo(excelPath)))
                    {
                        var worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now:HH_mm_ss}");

                        worksheet.Cells[1, 1].Value = "ID";
                        worksheet.Cells[1, 2].Value = "ID NO";
                        worksheet.Cells[1, 3].Value = "AD";
                        worksheet.Cells[1, 4].Value = "SOYAD";
                        worksheet.Cells[1, 5].Value = "TC NO";
                        worksheet.Cells[1, 6].Value = "D_TARİHİ";
                        worksheet.Cells[1, 7].Value = "TELEFON";
                        worksheet.Cells[1, 8].Value = "CİNSİYET";
                        worksheet.Cells[1, 9].Value = "K_TARİHİ";
                        worksheet.Cells[1, 10].Value = "BRANŞLAR";
                        worksheet.Cells[1, 11].Value = "DURUMU";

                        for (int i = 0; i < allRegistersList.Count; i++)
                        {
                            idStr.Clear();
                            if (allRegistersList[i].ID < 10)
                                idStr.Append($"GKM000{allRegistersList[i].ID}");
                            else if (allRegistersList[i].ID < 100)
                                idStr.Append($"GKM00{allRegistersList[i].ID}");
                            else if (allRegistersList[i].ID < 1000)
                                idStr.Append($"GKM0{allRegistersList[i].ID}");
                            else
                                idStr.Append($"GKM{allRegistersList[i].ID}");

                            worksheet.Cells[row, 1].Value = allRegistersList[i].ID;
                            worksheet.Cells[row, 2].Value = idStr.ToString();
                            worksheet.Cells[row, 3].Value = allRegistersList[i].NAME;
                            worksheet.Cells[row, 4].Value = allRegistersList[i].SURNAME;
                            worksheet.Cells[row, 5].Value = allRegistersList[i].TCKN;
                            worksheet.Cells[row, 6].Value = allRegistersList[i].BIRTHDATE;
                            worksheet.Cells[row, 7].Value = allRegistersList[i].PHONE;
                            worksheet.Cells[row, 8].Value = allRegistersList[i].GENDER ? "E" : "K";
                            worksheet.Cells[row, 9].Value = allRegistersList[i].REGISTERDATE;
                            worksheet.Cells[row, 10].Value = allRegistersList[i].COURSE;
                            worksheet.Cells[row++, 11].Value = allRegistersList[i].STATUS;
                        }
                        package.Save();
                    }
                    MessageBox.Show("Yedek Oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"WriteToExcel Error Hata Kodu: 2034 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2034", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAllRegister_Key(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    listViewAllRegister_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"listViewAllRegister_Key Error Hata Kodu: 2035 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2035", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.RestoreDirectory = true; // son klasörü açar
                openFileDialog.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
                openFileDialog.Title = "Backup Dosyasını Seçiniz.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Sql sql = new Sql();
                    List<Register> importRegisters = new List<Register>();
                    List<Register> importUsers = new List<Register>();
                    List<string> importBranches = new List<string>();
                    string filePath = openFileDialog.FileName;
                    int row = 2;

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage(filePath))
                    {
                        var worksheet = package.Workbook.Worksheets[0];

                        while (worksheet != null && worksheet.Cells[row, 1].Text != string.Empty)
                        {
                            if (!importUsers.Any(u => u.TCKN == worksheet.Cells[row, 5].Text))
                            {
                                importUsers.Add(new Register
                                {
                                    NAME = worksheet.Cells[row, 3].Text,
                                    SURNAME = worksheet.Cells[row, 4].Text,
                                    TCKN = worksheet.Cells[row, 5].Text,
                                    BIRTHDATE = DateTime.Parse(worksheet.Cells[row, 6].Text),
                                    PHONE = worksheet.Cells[row, 7].Text,
                                    GENDER = worksheet.Cells[row, 8].Text == "E" ? true : false
                                });
                            }
                            if (!importBranches.Contains(worksheet.Cells[row, 10].Text))
                                importBranches.Add(worksheet.Cells[row, 10].Text);
                            if (!importRegisters.Any(r => r.TCKN == worksheet.Cells[row, 5].Text && r.COURSE == worksheet.Cells[row, 10].Text))
                            {
                                importRegisters.Add(new Register
                                {
                                    TCKN = worksheet.Cells[row, 5].Text,
                                    REGISTERDATE = DateTime.Parse(worksheet.Cells[row, 9].Text),
                                    COURSE = worksheet.Cells[row, 10].Text,
                                    STATUS = worksheet.Cells[row, 11].Text,
                                });
                            }
                            row++;
                        }

                        query.Clear();
                        parameters.Clear();
                        for (int i = 0; i < importUsers.Count; i++)
                        {
                            query.Append($" IF NOT EXISTS (SELECT TOP 1 * FROM TRAINEES WHERE (NAME = @Name{i + 1} AND SURNAME = @Surname{i + 1}) OR TCKN = @Tckn{i + 1}) " +
                                $"BEGIN " +
                                "INSERT INTO TRAINEES (NAME, SURNAME, TCKN, BIRTHDATE, PHONE, GENDER, REGISTER_DATE) " +
                                $"VALUES (@Name{i + 1}, @Surname{i + 1}, @Tckn{i + 1}, @BirthDate{i + 1}, @Phone{i + 1}, @Gender{i + 1}, GETDATE())" +
                                "END ");

                            parameters.Add(new SqlParameter($"@Name{i + 1}", SqlDbType.NVarChar, 50) { Value = importUsers[i].NAME });
                            parameters.Add(new SqlParameter($"@Surname{i + 1}", SqlDbType.NVarChar, 50) { Value = importUsers[i].SURNAME });
                            parameters.Add(new SqlParameter($"@Tckn{i + 1}", SqlDbType.Char, 11) { Value = importUsers[i].TCKN });
                            parameters.Add(new SqlParameter($"@BirthDate{i + 1}", SqlDbType.DateTime) { Value = importUsers[i].BIRTHDATE });
                            parameters.Add(new SqlParameter($"@Phone{i + 1}", SqlDbType.Char, 10) { Value = importUsers[i].PHONE });
                            parameters.Add(new SqlParameter($"@Gender{i + 1}", SqlDbType.Bit) { Value = importUsers[i].GENDER });
                        }

                        int returnCodeTrainees = await sql.EditData(query.ToString(), parameters);
                        switch (returnCodeTrainees)
                        {
                            case 0:
                                Log.logger.Error("importToolStripMenuItem_Click Trainees Error Sql Bağlantısı Açılamadı. Hata Kodu: 2036");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2036", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Kursiyerler Başarıyla Eklendi.");
                                // ya çıkış yaptırıp yeniden giriş yaptır
                                // ya da sayfayı otomatik yenile
                                // veya bütün işlemlerin bitmesini bekle
                                MessageBox.Show($"Kursiyerler Başarıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("importToolStripMenuItem_Click Trainees Error EditData Hatası. Hata Kodu: 2037");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2037", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }


                        query.Clear();
                        parameters.Clear();
                        for (int i = 0; i < importBranches.Count; i++)
                        {
                            query.Append($" IF NOT EXISTS (SELECT * FROM COURSES WHERE NAME = @CourseName{i + 1}) " +
                                "BEGIN " +
                                "INSERT INTO COURSES (NAME, ADDITION_TIME) " +
                                $"VALUES (@CourseName{i + 1}, GETDATE()) " +
                                "END ");
                            parameters.Add(new SqlParameter($"@CourseName{i + 1}", SqlDbType.NVarChar, 50) { Value = importBranches[i] });
                        }

                        int returnCodeBranches = await sql.EditData(query.ToString(), parameters);
                        switch (returnCodeBranches)
                        {
                            case 0:
                                Log.logger.Error("importToolStripMenuItem_Click Branch Error Sql Bağlantısı Açılamadı. Hata Kodu: 2038");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2038", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Branşlar Başarıyla Eklendi.");
                                // ya çıkış yaptırıp yeniden giriş yaptır
                                // ya da sayfayı otomatik yenile
                                // veya bütün işlemlerin bitmesini bekle
                                MessageBox.Show($"Branşlar Başarıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("importToolStripMenuItem_Click Branch Error EditData Hatası. Hata Kodu: 2039");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2039", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        query.Clear();
                        parameters.Clear();
                        for (int i = 0; i < importRegisters.Count; i++)
                        {
                            query.Append($" IF NOT EXISTS (SELECT * FROM COURSEREGISTER WHERE TRAINEE_ID = (SELECT ID FROM TRAINEES WHERE TCKN = @TCKN{i + 1}) AND COURSE_ID = (SELECT ID FROM COURSES WHERE NAME = @CourseName{i + 1})) " +
                                "BEGIN " +
                                "INSERT INTO COURSEREGISTER (TRAINEE_ID, COURSE_ID, STATUS, REGISTER_DATE) " +
                                "VALUES (" +
                                $"(SELECT ID FROM TRAINEES WHERE TCKN = @TCKN{i + 1}), " +
                                $"(SELECT ID FROM COURSES WHERE NAME = @CourseName{i + 1}), " +
                                $"@Status{i + 1}, " +
                                $"@RegisterDate{i + 1}) " +
                                "END ");
                            parameters.Add(new SqlParameter($"@TCKN{i + 1}", SqlDbType.Char, 11) { Value = importRegisters[i].TCKN });
                            parameters.Add(new SqlParameter($"@CourseName{i + 1}", SqlDbType.NVarChar, 50) { Value = importRegisters[i].COURSE });
                            parameters.Add(new SqlParameter($"@Status{i + 1}", SqlDbType.Char, 1) { Value = importRegisters[i].STATUS });
                            parameters.Add(new SqlParameter($"@RegisterDate{i + 1}", SqlDbType.Date) { Value = importRegisters[i].REGISTERDATE });
                        }

                        int returnCodeRegisters = await sql.EditData(query.ToString(), parameters);
                        switch (returnCodeRegisters)
                        {
                            case 0:
                                Log.logger.Error("importToolStripMenuItem_Click Register Error Sql Bağlantısı Açılamadı. Hata Kodu: 2040");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2040", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Kurs Kayıtları Başarıyla Eklendi.");
                                // ya çıkış yaptırıp yeniden giriş yaptır
                                // ya da sayfayı otomatik yenile
                                // veya bütün işlemlerin bitmesini bekle
                                MessageBox.Show($"Kurs Kayıtları Başarıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error($"importToolStripMenuItem_Click Register Error EditData Hatası. Hata Kodu: 2041\nQuery:{query}");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2041", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        await Task.Run(async () =>
                        {
                            await GetCourses();  // GetCourses'in tamamlanmasını bekle
                            await RefreshData();
                        });

                        // UI işlemlerini senkron yerine async olarak çağır
                        await Task.Yield(); // UI thread'in kilitlenmesini önler
                        GetCourseCount();
                        buttonOrder_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"importToolStripMenuItem_Click Error Hata Kodu: 2042 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2042", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNewRegisters(int id)
        {
            try
            {
                listViewAllRegister.Items.Clear();

                // Döngüye girmeden önce sıralı bir liste alalım
                var newRegisters = allRegistersList.Where(r => r.ID > id).OrderBy(r => r.ID).ToList();

                foreach (var register in newRegisters)
                {
                    idStr.Clear();

                    if (register.ID < 10)
                        idStr.Append($"GKM000{register.ID}");
                    else if (register.ID < 100)
                        idStr.Append($"GKM00{register.ID}");
                    else if (register.ID < 1000)
                        idStr.Append($"GKM0{register.ID}");
                    else
                        idStr.Append($"GKM{register.ID}");

                    ListViewItem item = new ListViewItem(idStr.ToString());
                    item.SubItems.Add(register.TCKN);
                    item.SubItems.Add(register.NAME);
                    item.SubItems.Add(register.SURNAME);
                    item.SubItems.Add(register.COURSE);
                    item.SubItems.Add(register.BIRTHDATE.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(register.PHONE);
                    item.SubItems.Add(register.REGISTERDATE.ToString("dd-MM-yyyy"));
                    item.SubItems.Add(register.STATUS);

                    listViewAllRegister.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetNewRegisters Error Hata Kodu: 2043 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2043", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeEnableRadioButtons(int onOff) // kayıt durumlarının aktifliğini değiştirir
        {
            try
            {
                if (onOff == 1)
                {
                    radioButtonActive.Enabled = true;
                    radioButtonPassive.Enabled = true;
                    radioButtonTotal.Enabled = true;
                    radioButtonWaiting.Enabled = true;
                }
                else if (onOff == 0)
                {
                    radioButtonActive.Enabled = false;
                    radioButtonPassive.Enabled = false;
                    radioButtonTotal.Enabled = false;
                    radioButtonWaiting.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"EnabledRadioButtons Error Hata Kodu: 2044 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2044", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e) // uygulama alta alındıktan sonra scroll ekleyip kaydırmasını engeller
        {
            try
            {
                flowLayoutPanelBranches.Width = ClientSize.Width;
                flowLayoutPanelBranches.Height = ClientSize.Height;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormMain_Resize Error Hata Kodu: 2045 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2045", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetBirthDates(bool isBirthdateStrip) // doğum günü bugün olan kayıtları alır
        {
            try
            {
                await Task.Run(() =>
                {
                    birthDates.Clear();
                    birthDates = allRegistersList.Where(r => r.BIRTHDATE.Month == DateTime.Now.Month)
                        .GroupBy(r => r.TRAINEEID)
                        .Select(r => r.First()).ToList();

                    if (birthDates.Count(b => b.BIRTHDATE.Date.Month == DateTime.Now.Date.Month && b.BIRTHDATE.Date.Day == DateTime.Now.Date.Day) > 0 || isBirthdateStrip)
                    {
                        DialogResult dialogResult = MessageBox.Show("Eşleşen Doğum Günleri Listelensin Mi?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FormBirthDates formBirthDates = new FormBirthDates(birthDates);
                            formBirthDates.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("Eşleşen Doğum Günü Bulunamadı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                });
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetBirthDates Error Hata Kodu: 2046 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2046", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTitle.Text.Length < 49) // textbox'ın length'i dolana kadar boşluk ekler
                    textBoxTitle.Text += " ";
                else if (textBoxTitle.Text.Length >= 49) // textbox dolduktan sonra textbox'ın başından itibaren yeni text'i yazmaya başlar
                {
                    textBoxTitle.Text = textBoxTitle.Text.Remove(0, 1);
                    textBoxTitle.Text = textBoxTitle.Text + title[titleIndex++];
                    if (titleIndex > 32) // index 0'ın altına düşerse işlem başa alınır
                    {
                        titleIndex = 0;
                        textBoxTitle.Text = textBoxTitle.Text.Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"timer_Tick Error Hata Kodu: 2047 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2047", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void birthDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetBirthDates(true);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"birthDatesToolStripMenuItem_Click Error Hata Kodu: 2048 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2048", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddPersonelBranch formAddPersonelBranch = new();
                formAddPersonelBranch.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"addPersonelToolStripMenuItem_Click Error Hata Kodu: 2049 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2049", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormDeletePersonelBranch formDeletePersonelBranch = new();
                formDeletePersonelBranch.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"deletePersonelToolStripMenuItem_Click Error Hata Kodu: 2050 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 2050", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
