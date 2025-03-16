using BIGADIC_COURSE.Classes;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIGADIC_COURSE
{
    public partial class FormReport : Form
    {
        public FormReport(List<Register> registers, List<CheckBox> courses)
        {
            InitializeComponent();
            _registers = registers;
            _courses = courses;
        }

        List<Personel> personels = new List<Personel>();
        List<Register> _registers;
        List<CheckBox> _courses;
        List<int> selectedCourses = new List<int>();
        DateTime startDate;
        DateTime endDate;
        StringBuilder query = new StringBuilder();
        StringBuilder idStr = new StringBuilder();

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxFilters.SelectedIndex = 0;
                AddCheckboxToPanel();
                dateTimePickerEndDate.Value = DateTime.Today;
                dateTimePickerStartDate.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormReport_Load Error Hata Kodu: 6000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillListView(List<Register> filterRegisters) // listview'ı gönderilen list ile doldurur
        {
            try
            {
                listViewAllRegister.Items.Clear();
                foreach (var register in filterRegisters)
                {
                    idStr.Clear();
                    if (register.ID < 10)
                        idStr.Append($"GKM000{register.ID}");
                    else if (register.ID < 100)
                        idStr.Append($"GKM00{register.ID}");
                    else if (register.ID < 1000)
                        idStr.Append($"GKM0{register.ID}");

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

                textBoxTotalRegister.Text = filterRegisters.Count.ToString();
                textBoxActiveRegisters.Text = filterRegisters.Count(r => r.STATUS == "A").ToString();
                textBoxPassiveRegisters.Text = filterRegisters.Count(r => r.STATUS == "P").ToString();
                textBoxWaitingRegisters.Text = filterRegisters.Count(r => r.STATUS == "B").ToString();
                textBoxMale.Text = filterRegisters.Count(r => r.GENDER == true).ToString();
                textBoxFemale.Text = filterRegisters.Count(r => r.GENDER == false).ToString();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FillListView Error Hata Kodu: 6001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxSelectDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxSelectDate.Checked)
                {
                    dateTimePickerStartDate.Enabled = true;
                    dateTimePickerEndDate.Enabled = true;
                }
                else // tarih seçimi iptal olursa tarihler default değerlere döner
                {
                    dateTimePickerStartDate.Enabled = false;
                    dateTimePickerEndDate.Enabled = false;
                    startDate = DateTime.MinValue;
                    endDate = DateTime.Today;
                }
                comboBoxFilters_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"checkBoxSelectDate_CheckedChanged Error Hata Kodu: 6002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                startDate = DateTime.MinValue;
                endDate = DateTime.Today;

                if (checkBoxSelectDate.Checked) // tarih seçimi aktifse seçilen tarihlere göre liste filtrelenir
                {
                    startDate = dateTimePickerStartDate.Value;
                    endDate = dateTimePickerEndDate.Value;
                }

                List<Register> filteredRegisters = new List<Register>();
                switch (comboBoxFilters.SelectedIndex) // seçilen rapora göre liste belirlenir
                {
                    case 0: // toplam kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList(); //&& selectedCourses.Contains(r.COURSEID)
                        break;
                    case 1: // aktif kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "A" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 2: // bekleyen kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "B" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 3: // pasif kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "P" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 4: // kadın kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER == false && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 5: // kadın aktif kayıtlar 
                        filteredRegisters = _registers.FindAll(r => r.GENDER == false && r.STATUS == "A" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 6: // kadın bekleyen kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER == false && r.STATUS == "B" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 7: // kadın pasif kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER == false && r.STATUS == "P" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 8: // erkek kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER).ToList();
                        break;
                    case 9: // erkek aktif kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER && r.STATUS == "A" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 10: // erkek bekleyen kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER && r.STATUS == "B" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 11: // erkek pasif kayıtlar
                        filteredRegisters = _registers.FindAll(r => r.GENDER && r.STATUS == "P" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate).ToList();
                        break;
                    case 12: // branşa göre toplam
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && selectedCourses.Contains(r.COURSEID)).ToList();
                        break;
                    case 13: // branşa göre aktif
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "A" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && selectedCourses.Contains(r.COURSEID)).ToList();
                        break;
                    case 14: // branşa göre bekleyen
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "B" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && selectedCourses.Contains(r.COURSEID)).ToList();
                        break;
                    case 15: // branşa göre pasif
                        filteredRegisters = _registers.FindAll(r => r.STATUS == "P" && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && selectedCourses.Contains(r.COURSEID)).ToList();
                        break;
                    case 16: // haftalık rapor
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= DateTime.Today.AddDays(-7)).ToList();
                        break;
                    case 17: // günlük rapor
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= DateTime.Today).ToList();
                        break;
                    case 18: // aylık rapor
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= DateTime.Today.AddMonths(-1)).ToList();
                        break;
                    case 19: // yıllık rapor
                        filteredRegisters = _registers.FindAll(r => r.REGISTERDATE >= DateTime.Today.AddYears(-1)).ToList();
                        break;
                    case 20: // anlık rapor
                        GetPersonels();
                        ExportCurrentReport();
                        break;
                }

                FillListView(filteredRegisters);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"comboBoxFilters_SelectedIndexChanged Error Hata Kodu: 6003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearAllFilter_Click(object sender, EventArgs e) // bütün filtreleri temizle
        {
            try
            {
                foreach (CheckBox course in flowLayoutPanelBranches.Controls.OfType<CheckBox>())
                    course.Checked = false;

                comboBoxFilters.SelectedIndex = 0; // toplam kayıtları listeler
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonClearAllFilter_Click Error Hata Kodu: 6004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCheckboxToPanel()
        {
            try
            {
                flowLayoutPanelBranches.Controls.Clear(); // branşları eklenmeden bütün kurslar temizlenir

                foreach (var course in _courses) // veri tabanından çekilen bütün branşlar flowlayoutpanel'a eklenir
                {
                    CheckBox addedBranch = new CheckBox();
                    flowLayoutPanelBranches.Controls.Add(addedBranch);
                    addedBranch.Text = course.Text;
                    addedBranch.Name = course.Name;
                    addedBranch.Tag = course.Tag;
                    addedBranch.Location = new Point(10, 10);
                    addedBranch.ForeColor = Color.Black;
                    addedBranch.CheckedChanged += AddedBranch_CheckedChanged;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"AddCheckboxToPanel Error Hata Kodu: 6005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddedBranch_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked)
                {
                    checkBox.ForeColor = Color.Red;
                    selectedCourses.Add(int.Parse(checkBox.Tag.ToString()));
                }
                else
                {
                    checkBox.ForeColor = Color.Black;
                    selectedCourses.Remove(int.Parse(checkBox.Tag.ToString()));
                }
                comboBoxFilters_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"AddedBranch_CheckedChanged Error Hata Kodu: 6006 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6006", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerStartDate.Value > dateTimePickerEndDate.Value) // başlangıç tarihi bitiş tarihinden daha büyük bir değer girilmesini engeller
                {
                    dateTimePickerStartDate.Value = dateTimePickerEndDate.Value;
                    MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden Daha Büyük Olamaz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                comboBoxFilters_SelectedIndexChanged(sender, e); // tarih seçimi yapıldıktan listeleme işlemi tekrar tetiklenir
            }
            catch (Exception ex)
            {
                Log.logger.Error($"dateTimePicker_ValueChanged Error Hata Kodu: 6007 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6007", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCharts formCharts = new FormCharts(_registers);
                Hide();
                formCharts.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"graphicToolStripMenuItem_Click Error Hata Kodu: 6008 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6008", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAllRegister.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
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
                Log.logger.Error($"exportToExcelToolStripMenuItem_Click Error Hata Kodu: 6009 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6009", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAllRegister.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
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
                Log.logger.Error($"exportToPdfToolStripMenuItem_Click Error Hata Kodu: 6010 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6010", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExportToExcel()
        {
            try
            {
                string excelPath = Application.StartupPath + "\\ExportExcel\\";
                if (!Directory.Exists(excelPath))
                    Directory.CreateDirectory(excelPath);

                excelPath += $"list_{DateTime.Now.Date:yyyy_MM_dd}.xlsx";
                int row = 2;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (var package = new ExcelPackage(new FileInfo(excelPath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now:HH_mm_ss}");

                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "T.C. No";
                    worksheet.Cells[1, 3].Value = "Adı";
                    worksheet.Cells[1, 4].Value = "Soyadı";
                    worksheet.Cells[1, 5].Value = "Branş";
                    worksheet.Cells[1, 6].Value = "Doğum Tarihi";
                    worksheet.Cells[1, 7].Value = "Telefon";
                    worksheet.Cells[1, 8].Value = "Kayıt Tarihi";
                    worksheet.Cells[1, 9].Value = "Durumu";

                    for (int i = 0; i < listViewAllRegister.Items.Count; i++)
                    {
                        worksheet.Cells[row, 1].Value = listViewAllRegister.Items[i].SubItems[0].Text;
                        worksheet.Cells[row, 2].Value = listViewAllRegister.Items[i].SubItems[1].Text;
                        worksheet.Cells[row, 3].Value = listViewAllRegister.Items[i].SubItems[2].Text;
                        worksheet.Cells[row, 4].Value = listViewAllRegister.Items[i].SubItems[3].Text;
                        worksheet.Cells[row, 5].Value = listViewAllRegister.Items[i].SubItems[4].Text;
                        worksheet.Cells[row, 6].Value = listViewAllRegister.Items[i].SubItems[5].Text;
                        worksheet.Cells[row, 7].Value = listViewAllRegister.Items[i].SubItems[6].Text;
                        worksheet.Cells[row, 8].Value = listViewAllRegister.Items[i].SubItems[7].Text;
                        worksheet.Cells[row++, 9].Value = listViewAllRegister.Items[i].SubItems[8].Text;
                    }
                    package.Save();
                }
                Process.Start(excelPath);
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportToExcel Error Hata Kodu: 6011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ExportToPdf()
        {
            try
            {
                string pdfPath = Application.StartupPath + "\\ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                pdfPath += $"list_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new iText.Layout.Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                        // Tabloyu oluşturuyoruz ve sütun genişliklerini ayarlıyoruz
                        float[] columnWidths = { 1, 2, 3, 3, 2, 2, 2, 2, 2 }; // Sütun genişlikleri
                        Table table = new Table(columnWidths);

                        table.AddCell("ID").SetFont(font).SetFontSize(9);
                        table.AddCell("T.C. No").SetFont(font).SetFontSize(9);
                        table.AddCell("Adı").SetFont(font).SetFontSize(9);
                        table.AddCell("Soyadı").SetFont(font).SetFontSize(9);
                        table.AddCell("Branş").SetFont(font).SetFontSize(9);
                        table.AddCell("Doğum Tarihi").SetFont(font).SetFontSize(9);
                        table.AddCell("Telefon").SetFont(font).SetFontSize(9);
                        table.AddCell("Kayıt Tarihi").SetFont(font).SetFontSize(9);
                        table.AddCell("Durumu").SetFont(font).SetFontSize(9);

                        for (int i = 0; i < listViewAllRegister.Items.Count; i++)
                        {
                            table.AddCell(listViewAllRegister.Items[i].SubItems[0].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[1].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[2].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[3].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[4].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[5].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[6].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[7].Text).SetFont(font).SetFontSize(9);
                            table.AddCell(listViewAllRegister.Items[i].SubItems[8].Text).SetFont(font).SetFontSize(9);
                        }

                        document.Add(table);
                        document.Close();
                    }
                }

                Process.Start(pdfPath);
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportToPdf Error Hata Kodu: 6012 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6012", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ExportCurrentReport()
        {
            try
            {
                string pdfPath = Application.StartupPath + "\\ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                pdfPath += $"Anlık_Rapor_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";
                string imagePath = Application.StartupPath + "\\LOGO.png";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new iText.Layout.Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arialbd.ttf", PdfEncodings.IDENTITY_H);

                        // Tabloyu oluşturuyoruz ve sütun genişliklerini ayarlıyoruz
                        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(imagePath));
                        img.ScaleToFit(100, 100); // Resmi 100x100 boyutuna ölçeklendirir

                        img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(img);

                        document.Add(new Paragraph());
                        document.Add(new Paragraph("BİGADİÇ BELEDİYESİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("GENÇLİK VE KÜLTÜR MERKEZİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                        document.Add(new Paragraph($"TOPLAM SAYI: {_registers.Count}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"AKTİF SAYI: {_registers.Count(r => r.STATUS == "A")}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"PASİF SAYI: {_registers.Count(r => r.STATUS == "P")}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"BEKLEYEN BAŞVURU SAYISI: {_registers.Count(r => r.STATUS == "B")}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"FAALİYET GÖSTEREN BRANŞ SAYISI: {_registers.Count(r => r.STATUS == "A" || r.STATUS == "P")}").SetFont(font).SetFontSize(12));

                        document.Add(new Paragraph("\nFAALİYET GÖSTEREN BRANŞLAR\n").SetFont(font).SetFontSize(14).SetUnderline().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                        List<Register> activeCourses = _registers.Where(r => r.STATUS == "A" || r.STATUS == "P")
                            .GroupBy(r => r.COURSE)
                            .Select(r => r.First())
                            .ToList();

                        float[] columnWidths = { 1, 2, 3, 3, 2 }; // Sütun genişlikleri
                        Table tableActive = new Table(columnWidths);
                        foreach (Register course in activeCourses)
                        {
                            Cell cell = new Cell().Add(new Paragraph($"*{course.COURSE}").SetFont(font).SetFontSize(12));
                            cell.SetBorder(Border.NO_BORDER);  // Hücrenin kenarlığını kaldır
                            cell.SetPadding(7);
                            tableActive.AddCell(cell);
                        }
                        document.Add(tableActive);

                        document.Add(new Paragraph("\nAÇILMASI PLANLANAN KURSLAR\n").SetFont(font).SetFontSize(14).SetUnderline().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                        List<Register> waitingRegisters = _registers.GroupBy(r => r.COURSE)
                            .Where(g => !g.Any(r => r.STATUS == "A" || r.STATUS == "P"))
                            .Select(g => g.First())
                            .ToList();

                        Table tableWaiting = new Table(columnWidths);
                        foreach (Register course in waitingRegisters)
                        {
                            Cell cell = new Cell().Add(new Paragraph($"*{course.COURSE}").SetFont(font).SetFontSize(12));
                            cell.SetBorder(Border.NO_BORDER);  // Hücrenin kenarlığını kaldır
                            cell.SetPadding(7);
                            tableWaiting.AddCell(cell);
                        }
                        document.Add(tableWaiting);

                        document.Add(new Paragraph("\nPERSONELLERİMİZ\n").SetFont(font).SetFontSize(14).SetUnderline().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                        document.Add(new Paragraph($"PERSONEL SAYISI: {personels.Count(p => p.TYPE == 1)}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"ANTRENÖR SAYISI: {personels.Count(p => p.TYPE == 2)}").SetFont(font).SetFontSize(12));
                        document.Add(new Paragraph($"ÖĞRETMEN SAYISI: {personels.Count(p => p.TYPE == 3)}").SetFont(font).SetFontSize(12));

                        document.Close();
                    }
                }
                Process.Start(pdfPath);
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportCurrentReport Error Hata Kodu: 6013 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6013", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void GetPersonels()
        {
            try
            {
                Sql sql = new Sql();


                query.Clear();
                query.Append("SELECT * FROM PERSONELS;");

                DataTable allPersonels = await sql.GetFromDb(query.ToString());

                foreach (DataRow row in allPersonels.Rows)
                    personels.Add(new Personel
                    {
                        ID = int.Parse(row.ItemArray[0].ToString()),
                        TYPE = int.Parse(row.ItemArray[4].ToString())
                    });
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetPersonels Error Hata Kodu: 6014 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 6014", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
