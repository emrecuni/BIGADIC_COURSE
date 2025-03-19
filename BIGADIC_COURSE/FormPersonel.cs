using BIGADIC_COURSE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System.Diagnostics;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using OfficeOpenXml.Drawing;


namespace BIGADIC_COURSE
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        StringBuilder query = new StringBuilder();
        List<SqlParameter> parameters = new List<SqlParameter>();
        List<Personel> allPersonels = new List<Personel>();
        Personel selectedPersonel;
        Personel updatedPersonel;
        string imagePath = Application.StartupPath + "LOGO.png";

        private async void FormPersonel_Load(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    RefreshData();
                    GetCourses();
                    buttonOrder_Click(sender, e);
                    comboBoxPersonelType.SelectedIndex = 0; // seçiniz default gelir
                    comboBoxBranch.SelectedIndex = 0; // seçiniz default gelir
                });
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_Enter Error Hata Kodu: 8000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_Enter Error Hata Kodu: 8001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (textBox.Text.Length != 10)
                    {
                        MessageBox.Show("Telefon Numarası 10 Karakter Olmalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Focus();
                    }
                }
                if (textBoxName.Text != string.Empty && textBoxSurname.Text != string.Empty && maskedTextBoxPhone.Text != string.Empty && comboBoxPersonelType.SelectedIndex <= 0)
                    buttonRegister.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_Enter Error Hata Kodu: 8002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log.logger.Error($"textBox_KeyDown Error Hata Kodu: 8003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty && textBoxSurname.Text != string.Empty && maskedTextBoxPhone.Text != string.Empty && comboBoxPersonelType.SelectedIndex >= 0)
                {
                    Sql sql = new Sql();

                    query.Clear();
                    query.Append("INSERT INTO PERSONELS (NAME, SURNAME, PHONE, TYPE, COURSE_ID, REGISTER_DATE) " +
                        "VALUES (@Name, @Surname, @Phone, @Type, @CourseId, GETDATE());");

                    parameters.Clear();
                    parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = textBoxName.Text.Trim().ToUpper() });
                    parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50) { Value = textBoxSurname.Text.Trim().ToUpper() });
                    parameters.Add(new SqlParameter("@Phone", SqlDbType.Char, 10) { Value = maskedTextBoxPhone.Text });
                    parameters.Add(new SqlParameter("@Type", SqlDbType.TinyInt) { Value = comboBoxPersonelType.SelectedIndex });
                    parameters.Add(new SqlParameter("@CourseId", SqlDbType.TinyInt) { Value = comboBoxBranch.SelectedIndex });

                    int returnCode = await sql.EditData(query.ToString(), parameters);
                    int id = -1;
                    switch (returnCode)
                    {
                        case -1:
                            Log.logger.Error("buttonRegister_Click Error EditData Hatası. Hata Kodu: 8004");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 0:
                            Log.logger.Error("buttonRegister_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 8005");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            Log.logger.Info($"Yeni kurs kaydı başarıyla yapıldı. {textBoxName.Text} - {textBoxSurname.Text}");
                            if (allPersonels.Count > 0)
                                id = allPersonels.LastOrDefault().ID;
                            RefreshData(); // veri tabanındaki kayıtlar tekrar çekilir
                            GetNewRegisters(id); // sadece yeni eklene kayıtlar listview'a getirir
                            buttonClear_Click(sender, e); // textbox'ları temizler
                            MessageBox.Show($"Kayıt(lar) Başarılıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 2:
                            Log.logger.Info($"Kurs zaten kayıtlı. {textBoxName.Text}  -  {textBoxSurname.Text}");
                            MessageBox.Show($"Eklemek İstediğiniz Kayıt Veri Tabanında Mevcut", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonRegister_Click Error Hata Kodu: 8006 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8006", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirm = true;
                if (selectedPersonel.NAME == textBoxName.Text && selectedPersonel.SURNAME == textBoxSurname.Text && selectedPersonel.PHONE == maskedTextBoxPhone.Text && selectedPersonel.TYPE == comboBoxPersonelType.SelectedIndex && selectedPersonel.COURSEID == comboBoxBranch.SelectedIndex)
                {
                    DialogResult dialogResult = MessageBox.Show("Hiçbir Değer Değiştirilmedi. Güncellemek İstiyor Musunuz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult != DialogResult.Yes)
                        confirm = false;
                }

                if (confirm)
                {
                    Sql sql = new Sql();
                    int id = int.Parse(listViewPersonels.SelectedItems[0].Text);

                    query.Clear();
                    query.Append($"UPDATE PERSONELS SET NAME = @Name, SURNAME = @Surname, PHONE = @Phone, TYPE = @Type, COURSE_ID = @CourseId WHERE ID = @Id;");

                    parameters.Clear();
                    parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = textBoxName.Text });
                    parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50) { Value = textBoxSurname.Text });
                    parameters.Add(new SqlParameter("@Phone", SqlDbType.Char, 10) { Value = maskedTextBoxPhone.Text });
                    parameters.Add(new SqlParameter("@Type", SqlDbType.TinyInt) { Value = comboBoxPersonelType.SelectedIndex });
                    parameters.Add(new SqlParameter("@CourseId", SqlDbType.TinyInt) { Value = comboBoxBranch.SelectedIndex });
                    parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                    int returnCode = await sql.EditData(query.ToString(), parameters);
                    switch (returnCode)
                    {
                        case 0:
                            Log.logger.Error("buttonUpdate_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 8007");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8007", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            Log.logger.Info($"Kayıt başarıyla güncellendi. {maskedTextBoxPhone.Text}");
                            RefreshData(); // veri tabanındaki kayıtlar tekrar çekilir
                            GetUpdatedRegister(id); // sadece güncellenen kaydı getirir
                            buttonClear_Click(sender, e); // textbox'ları temizler
                            buttonUpdate.Enabled = false;
                            buttonDelete.Enabled = false;
                            MessageBox.Show($"Kayıt Başarılıyla Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case -1:
                            Log.logger.Error("buttonUpdate_Click Error EditData Hatası. Hata Kodu: 8008");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8008", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonUpdate_Click Error Hata Kodu: 8009 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8009", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Personeli Silmek İstediğinize Emin Misiniz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Sql sql = new Sql();
                    int id = int.Parse(listViewPersonels.SelectedItems[0].Text);

                    query.Clear();
                    query.Append($"DELETE FROM PERSONELS WHERE ID = @Id;");

                    parameters.Clear();
                    parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                    int returnCode = await sql.EditData(query.ToString(), parameters);
                    switch (returnCode)
                    {
                        case 0:
                            Log.logger.Error("buttonDelete_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 8010");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8010", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            Log.logger.Info($"Kayıt başarıyla silindi. {maskedTextBoxPhone.Text}");
                            RefreshData(); // veri tabanındaki kayıtlar tekrar çekilir
                            buttonOrder_Click(sender, e); // bütün kayıtları getirir
                            buttonClear_Click(sender, e); // textbox'ları temizler
                            buttonUpdate.Enabled = false;
                            buttonDelete.Enabled = false;
                            MessageBox.Show($"Kayıt Başarılıyla Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case -1:
                            Log.logger.Error("buttonDelete_Click Error EditData Hatası. Hata Kodu: 8011");
                            MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonDelete_Click Error Hata Kodu: 8012 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8012", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                listViewPersonels.Items.Clear();
                foreach (Personel personel in allPersonels)
                {
                    ListViewItem item = new ListViewItem(personel.ID.ToString());
                    item.SubItems.Add(personel.NAME);
                    item.SubItems.Add(personel.SURNAME);
                    item.SubItems.Add(personel.PHONE);
                    item.SubItems.Add(personel.TYPEDESCRIPTION);
                    item.SubItems.Add(personel.COURSE);
                    item.SubItems.Add(personel.REGISTERDATE.ToString("dd-MM-yyyy"));
                    listViewPersonels.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonOrder_Click Error Hata Kodu: 8013 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8013", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxId.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxSurname.Text = string.Empty;
                maskedTextBoxPhone.Text = string.Empty;
                comboBoxPersonelType.SelectedIndex = 0;
                comboBoxBranch.SelectedIndex = 0;
                buttonRegister.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonClear_Click Error Hata Kodu: 8014 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8014", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != string.Empty || textBoxSurname.Text != string.Empty || maskedTextBoxPhone.Text != string.Empty)
                {
                    listViewPersonels.Items.Clear();
                    var searchedPersonel = allPersonels.FindAll(p => p.NAME.Contains(textBoxName.Text) && p.SURNAME.Contains(textBoxSurname.Text) && p.PHONE.Contains(maskedTextBoxPhone.Text));

                    if (searchedPersonel.Count > 0)
                    {
                        foreach (var personel in searchedPersonel)
                        {
                            ListViewItem item = new ListViewItem(personel.ID.ToString());
                            item.SubItems.Add(personel.NAME);
                            item.SubItems.Add(personel.SURNAME);
                            item.SubItems.Add(personel.PHONE);
                            item.SubItems.Add(personel.TYPEDESCRIPTION);
                            item.SubItems.Add(personel.COURSE);
                            item.SubItems.Add(personel.REGISTERDATE.ToString("dd-MM-yyyy"));
                            listViewPersonels.Items.Add(item);
                        }
                    }
                    else
                        MessageBox.Show("Aranan Kayıt Bulunamadı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Arama Yapabilmek İçin Ad-Soyad veya Telefon Numarası Alanlarını Doldurunuz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonSearch_Click Error Hata Kodu: 8015 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8015", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPersonels_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(listViewPersonels.SelectedItems[0].Text);

                textBoxId.Text = id.ToString();
                textBoxName.Text = allPersonels.Find(p => p.ID == id).NAME;
                textBoxSurname.Text = allPersonels.Find(p => p.ID == id).SURNAME;
                maskedTextBoxPhone.Text = allPersonels.Find(p => p.ID == id).PHONE;
                comboBoxPersonelType.SelectedIndex = allPersonels.Find(p => p.ID == id).TYPE;
                comboBoxBranch.SelectedIndex = allPersonels.Find(p => p.ID == id).COURSEID;

                buttonRegister.Enabled = false;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;

                selectedPersonel = new Personel
                {
                    ID = id,
                    NAME = textBoxName.Text,
                    SURNAME = textBoxSurname.Text,
                    PHONE = maskedTextBoxPhone.Text,
                    TYPE = comboBoxPersonelType.SelectedIndex,
                    COURSEID = comboBoxBranch.SelectedIndex
                };
            }
            catch (Exception ex)
            {
                Log.logger.Error($"listViewPersonels_Click Error Hata Kodu: 8016 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8016", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPersonels_Key(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    listViewPersonels_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"listViewPersonels_Key Error Hata Kodu: 8017 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8017", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void RefreshData()
        {
            try
            {
                Sql sql = new Sql();
                query.Clear();
                query.Append("SELECT P.*, T.NAME AS TYPEDESC, C.NAME AS COURSE FROM PERSONELS P" +
                    " INNER JOIN PERSONELTYPES T ON T.ID = P.TYPE" +
                    " INNER JOIN COURSES C ON C.ID = P.COURSE_ID;");

                DataTable personels = await sql.GetFromDb(query.ToString());

                allPersonels.Clear();
                foreach (DataRow personel in personels.Rows)
                {
                    allPersonels.Add(new Personel
                    {
                        ID = int.Parse(personel.ItemArray[0].ToString()),
                        NAME = personel.ItemArray[1].ToString(),
                        SURNAME = personel.ItemArray[2].ToString(),
                        PHONE = personel.ItemArray[3].ToString(),
                        TYPE = int.Parse(personel.ItemArray[4].ToString()),
                        REGISTERDATE = DateTime.Parse(personel.ItemArray[5].ToString()).Date,
                        COURSEID = int.Parse(personel.ItemArray[6].ToString()),
                        TYPEDESCRIPTION = personel.ItemArray[7].ToString(),
                        COURSE = personel.ItemArray[8].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"RefreshData Error Hata Kodu: 8018 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8018", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetNewRegisters(int id)
        {
            try
            {
                listViewPersonels.Items.Clear();
                while (allPersonels.Any(p => p.ID > id))
                {
                    ListViewItem item = new ListViewItem(allPersonels.Find(p => p.ID > id).ID.ToString());
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).NAME);
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).SURNAME);
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).PHONE);
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).TYPEDESCRIPTION);
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).COURSE);
                    item.SubItems.Add(allPersonels.Find(p => p.ID > id).REGISTERDATE.ToString("dd-MM-yyyy"));
                    listViewPersonels.Items.Add(item);
                    id = int.Parse(item.SubItems[0].Text);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetNewRegisters Error Hata Kodu: 8019 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8019", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUpdatedRegister(int id)
        {
            try
            {
                listViewPersonels.Items.Clear();
                ListViewItem item = new ListViewItem(allPersonels.Find(p => p.ID == id).ID.ToString());
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).NAME);
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).SURNAME);
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).PHONE);
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).TYPEDESCRIPTION);
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).COURSE);
                item.SubItems.Add(allPersonels.Find(p => p.ID == id).REGISTERDATE.ToString("dd-MM-yyyy"));
                listViewPersonels.Items.Add(item);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetUpdatedRegister Error Hata Kodu: 8020 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8020", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCourses()
        {
            try
            {
                Sql sql = new Sql();

                query.Clear();
                query.Append("SELECT * FROM COURSES;");

                DataTable? courses = await sql.GetFromDb(query.ToString());

                comboBoxBranch.Items.Add("Seçiniz");
                    foreach (DataRow row in courses.Rows)
                        comboBoxBranch.Items.Add(row.ItemArray[1].ToString());
                
                //comboBoxBranch.Items[0].
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourses Error Hata Kodu: 8021 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8021", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPersonels.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
                {
                    DialogResult dialogResult = MessageBox.Show("Listenen Hiçbir Kayıt Yok. Devam Etmek İstiyor Musunuz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes && ExportToExcel())
                        MessageBox.Show("Kayıtlar Excel Dosyasına Aktarıldı.\n\nDosya Açılıyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (ExportToExcel())
                    MessageBox.Show("Kayıtlar Excel Dosyasına Aktarıldı.\n\nDosya Açılıyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"exportToExcelToolStripMenuItem_Click Error Hata Kodu: 8022 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8022", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExportToExcel()
        {
            try
            {
                string excelPath = Application.StartupPath + "ExportExcel\\";
                if (!Directory.Exists(excelPath))
                    Directory.CreateDirectory(excelPath);

                excelPath += $"personel_{DateTime.Now.Date:yyyy_MM_dd}.xlsx";
                int row = 5;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (var package = new ExcelPackage(new FileInfo(excelPath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now:HH_mm_ss}");

                    ExcelPicture logo = worksheet.Drawings.AddPicture("Logo", new FileInfo(imagePath));

                    logo.SetPosition(0, 15, 3, 10); // Satır 2, Sütun B (Hücre: B2)
                    logo.SetSize(55, 50); // Genişlik - Yükseklik

                    worksheet.Cells[1, 1, 1, 7].Merge = true;
                    worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    worksheet.Row(1).Height = (60); // Excel'de yükseklik yaklaşık %75 ölçekli

                    worksheet.Cells[2, 1, 2, 7].Merge = true;
                    worksheet.Cells[2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[2, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    worksheet.Cells[2, 1].Value = "Bigadiç Belediyesi";
                    worksheet.Cells[2, 1].Style.Font.Size = 14;

                    worksheet.Cells[3, 1, 3, 7].Merge = true;
                    worksheet.Cells[3, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[3, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    worksheet.Cells[3, 1].Value = "Gençlik ve Kültür Merkezi";
                    worksheet.Cells[3, 1].Style.Font.Size = 14;

                    worksheet.Cells[4, 1].Value = "ID";
                    worksheet.Cells[4, 2].Value = "Adı";
                    worksheet.Cells[4, 3].Value = "Soyadı";
                    worksheet.Cells[4, 4].Value = "Telefon";
                    worksheet.Cells[4, 5].Value = "Tipi";
                    worksheet.Cells[4, 6].Value = "Branş";
                    worksheet.Cells[4, 7].Value = "Kayıt Tarihi";

                    for (int i = 0; i < listViewPersonels.Items.Count; i++)
                    {
                        worksheet.Cells[row, 1].Value = listViewPersonels.Items[i].SubItems[0].Text;
                        worksheet.Cells[row, 2].Value = listViewPersonels.Items[i].SubItems[1].Text;
                        worksheet.Cells[row, 3].Value = listViewPersonels.Items[i].SubItems[2].Text;
                        worksheet.Cells[row, 4].Value = listViewPersonels.Items[i].SubItems[3].Text;
                        worksheet.Cells[row, 5].Value = listViewPersonels.Items[i].SubItems[4].Text;
                        worksheet.Cells[row, 6].Value = listViewPersonels.Items[i].SubItems[5].Text;
                        worksheet.Cells[row++, 7].Value = listViewPersonels.Items[i].SubItems[6].Text;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    
                    try
                    {
                        package.Save();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Açık Excel Dosyasını Kapatıp Yeniden Deneyin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer",
                    Arguments = $"\"{excelPath}\"",
                    UseShellExecute = true
                });
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportToExcel Error Hata Kodu: 8023 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8023", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void exportToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (listViewPersonels.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
                {
                    DialogResult dialogResult = MessageBox.Show("Listenen Hiçbir Kayıt Yok. Devam Etmek İstiyor Musunuz?", "SORU", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes && ExportToPdf())
                        MessageBox.Show("Kayıtlar Pdf Dosyasına Aktarıldı.\n\nDosya Açılıyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ExportToPdf())
                    MessageBox.Show("Kayıtlar Pdf Dosyasına Aktarıldı.\n\nDosya Açılıyor...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourses Error Hata Kodu: 8024 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8024", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExportToPdf()
        {
            try
            {
                string pdfPath = Application.StartupPath + "ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                pdfPath += $"personel_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new(pdf);
                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(imagePath));
                        img.ScaleToFit(100, 100); // Resmi 100x100 boyutuna ölçeklendirir

                        img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(img);

                        document.Add(new Paragraph());
                        document.Add(new Paragraph("BİGADİÇ BELEDİYESİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("GENÇLİK VE KÜLTÜR MERKEZİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph());
                        document.Add(new Paragraph());
                        document.Add(new Paragraph());

                        // Tabloyu oluşturuyoruz ve sütun genişliklerini ayarlıyoruz
                        float[] columnWidths = { 1, 2, 3, 3, 2, 2, 2 }; // Sütun genişlikleri
                        Table table = new Table(columnWidths);

                        table.AddCell("ID").SetFont(font).SetFontSize(18);
                        table.AddCell("Adı").SetFont(font).SetFontSize(18);
                        table.AddCell("Soyadı").SetFont(font).SetFontSize(18);
                        table.AddCell("Telefon").SetFont(font).SetFontSize(18);
                        table.AddCell("Tipi").SetFont(font).SetFontSize(18);
                        table.AddCell("Branş").SetFont(font).SetFontSize(18);
                        table.AddCell("Kayıt Tarihi").SetFont(font).SetFontSize(18);

                        for (int i = 0; i < listViewPersonels.Items.Count; i++)
                        {
                            table.AddCell(listViewPersonels.Items[i].SubItems[0].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[1].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[2].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[3].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[4].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[5].Text).SetFont(font).SetFontSize(15);
                            table.AddCell(listViewPersonels.Items[i].SubItems[6].Text).SetFont(font).SetFontSize(15);
                        }

                        document.Add(table);
                        document.Close();
                    }
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = "explorer",
                    Arguments = $"\"{pdfPath}\"",
                    UseShellExecute = true
                });
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportToPdf Error Hata Kodu: 8025 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 8025", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
