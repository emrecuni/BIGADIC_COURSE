using BIGADIC_COURSE.Classes;
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
    public partial class FormBirthDates : Form
    {
        public FormBirthDates(List<Register> birthDates)
        {
            InitializeComponent();
            _birthDates = birthDates;
        }

        List<Register> _birthDates;
        StringBuilder idStr = new StringBuilder();

        private void FormBirthDates_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Register birthDate in _birthDates)
                {
                    idStr.Clear();
                    if (birthDate.ID < 10)
                        idStr.Append($"GKM000{birthDate.ID}");
                    else if (birthDate.ID < 100)
                        idStr.Append($"GKM00{birthDate.ID}");
                    else if (birthDate.ID < 1000)
                        idStr.Append($"GKM0{birthDate.ID}");

                    ListViewItem item = new ListViewItem(idStr.ToString());
                    item.SubItems.Add(birthDate.TCKN);
                    item.SubItems.Add(birthDate.NAME);
                    item.SubItems.Add(birthDate.SURNAME);
                    item.SubItems.Add(birthDate.PHONE);
                    item.SubItems.Add(birthDate.BIRTHDATE.ToString("dd-MM-yyyy"));
                    listViewBirthDate.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormBirthDates_Load Error Hata Kodu: 9000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBirthDate.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
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
                Log.logger.Error($"exportExcelToolStripMenuItem_Click Error Hata Kodu: 9001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBirthDate.Items.Count == 0) // listenen hiçbir kayıt yoksa onay ister
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
                Log.logger.Error($"exportExcelToolStripMenuItem_Click Error Hata Kodu: 9002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExportToExcel()
        {
            try
            {
                string excelPath = Application.StartupPath + "\\ExportExcel\\";
                if (!Directory.Exists(excelPath))
                    Directory.CreateDirectory(excelPath);

                excelPath += $"birthDate_{DateTime.Now.Date:yyyy_MM_dd}.xlsx";
                int row = 2;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (var package = new ExcelPackage(new FileInfo(excelPath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now:HH_mm_ss}");

                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "T.C. No";
                    worksheet.Cells[1, 3].Value = "Adı";
                    worksheet.Cells[1, 4].Value = "Soyadı";
                    worksheet.Cells[1, 5].Value = "Telefon";
                    worksheet.Cells[1, 6].Value = "Doğum Tarihi";

                    for (int i = 0; i < listViewBirthDate.Items.Count; i++)
                    {
                        worksheet.Cells[row, 1].Value = listViewBirthDate.Items[i].SubItems[0].Text;
                        worksheet.Cells[row, 2].Value = listViewBirthDate.Items[i].SubItems[1].Text;
                        worksheet.Cells[row, 3].Value = listViewBirthDate.Items[i].SubItems[2].Text;
                        worksheet.Cells[row, 4].Value = listViewBirthDate.Items[i].SubItems[3].Text;
                        worksheet.Cells[row, 5].Value = listViewBirthDate.Items[i].SubItems[4].Text;
                        worksheet.Cells[row++, 6].Value = listViewBirthDate.Items[i].SubItems[5].Text;
                    }
                    package.Save();
                }
                Process.Start(excelPath);
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"ExportExcel Error Hata Kodu: 9003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                pdfPath += $"birthDate_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new iText.Layout.Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                        // Tabloyu oluşturuyoruz ve sütun genişliklerini ayarlıyoruz
                        float[] columnWidths = { 1, 2, 3, 3, 2, 2 }; // Sütun genişlikleri
                        Table table = new Table(columnWidths);

                        table.AddCell("ID").SetFont(font).SetFontSize(13);
                        table.AddCell("T.C. No").SetFont(font).SetFontSize(13);
                        table.AddCell("Adı").SetFont(font).SetFontSize(13);
                        table.AddCell("Soyadı").SetFont(font).SetFontSize(13);
                        table.AddCell("Telefon").SetFont(font).SetFontSize(13);
                        table.AddCell("Doğum Tarihi").SetFont(font).SetFontSize(13);

                        for (int i = 0; i < listViewBirthDate.Items.Count; i++)
                        {
                            table.AddCell(listViewBirthDate.Items[i].SubItems[0].Text).SetFont(font).SetFontSize(13);
                            table.AddCell(listViewBirthDate.Items[i].SubItems[1].Text).SetFont(font).SetFontSize(13);
                            table.AddCell(listViewBirthDate.Items[i].SubItems[2].Text).SetFont(font).SetFontSize(13);
                            table.AddCell(listViewBirthDate.Items[i].SubItems[3].Text).SetFont(font).SetFontSize(13);
                            table.AddCell(listViewBirthDate.Items[i].SubItems[4].Text).SetFont(font).SetFontSize(13);
                            table.AddCell(listViewBirthDate.Items[i].SubItems[5].Text).SetFont(font).SetFontSize(13);
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
                Log.logger.Error($"ExportToPdf Error Hata Kodu: 9004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
