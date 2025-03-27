using BIGADIC_COURSE.Classes;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
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
        string imagePath = Application.StartupPath + "LOGO.png";

        private void FormBirthDates_Load(object sender, EventArgs e)
        {
            try
            {
                var birthDates = _birthDates.FindAll(b => b.BIRTHDATE.Date.Day == DateTime.Now.Date.Day);
                FillListView(birthDates);
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
                    if (dialogResult == DialogResult.Yes)
                        if (!ExportToExcel())
                            MessageBox.Show("Kayıtlar Excel Dosyasına Aktarlırken Bir Hata Oldu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!ExportToExcel())
                    MessageBox.Show("Kayıtlar Excel Dosyasına Aktarlırken Bir Hata Oldu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (dialogResult == DialogResult.Yes)
                        if (!ExportToPdf())
                            MessageBox.Show("Kayıtlar Pdf Dosyasına Aktarlırken Bir Hata Oldu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!ExportToPdf())
                    MessageBox.Show("Kayıtlar Pdf Dosyasına Aktarlırken Bir Hata Oldu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                string excelPath = Application.StartupPath + "ExportExcel\\";
                if (!Directory.Exists(excelPath))
                    Directory.CreateDirectory(excelPath);

                excelPath += $"birthDate_{DateTime.Now.Date:yyyy_MM_dd}.xlsx";
                int row = 6;

                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

                using (var package = new ExcelPackage(new FileInfo(excelPath)))
                {
                    var worksheet = package.Workbook.Worksheets.Add($"{DateTime.Now:HH_mm_ss}");

                    ExcelPicture logo = worksheet.Drawings.AddPicture("Logo", new FileInfo(imagePath));

                    logo.SetPosition(0, 5, 3, 5); // Satır 2, Sütun B (Hücre: B2)
                    logo.SetSize(55, 50); // Genişlik - Yükseklik

                    worksheet.Cells[1, 1, 1, 6].Merge = true;
                    worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    // **Satırın yüksekliğini resme göre ayarla**
                    worksheet.Row(1).Height = (60); // Excel'de yükseklik yaklaşık %75 ölçekli

                    worksheet.Cells[2, 1, 2, 6].Merge = true;
                    worksheet.Cells[2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[2, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    worksheet.Cells[2, 1].Value = "Bigadiç Belediyesi";
                    worksheet.Cells[2, 1].Style.Font.Size = 14;

                    worksheet.Cells[3, 1, 3, 6].Merge = true;
                    worksheet.Cells[3, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[3, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    worksheet.Cells[3, 1].Value = "Gençlik ve Kültür Merkezi";
                    worksheet.Cells[3, 1].Style.Font.Size = 14;

                    worksheet.Cells[4, 3, 4, 5].Merge = true;
                    worksheet.Cells[4, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[4, 3].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    worksheet.Cells[4, 3].Value = "Doğum Günü Kutlama Formu";
                    worksheet.Cells[4, 3].Style.Font.Size = 12;
                    worksheet.Cells[4, 3].Style.Font.Bold = true; // Kalın;
                    worksheet.Cells[4, 6].Value = "Tarih:.../.../2025";

                    worksheet.Cells[5, 1].Value = "ID";
                    worksheet.Cells[5, 2].Value = "T.C. No";
                    worksheet.Cells[5, 3].Value = "Adı";
                    worksheet.Cells[5, 4].Value = "Soyadı";
                    worksheet.Cells[5, 5].Value = "Telefon";
                    worksheet.Cells[5, 6].Value = "Doğum Tarihi";

                    worksheet.Cells[5, 1].Style.Font.Size = 12;
                    worksheet.Cells[5, 2].Style.Font.Size = 12;
                    worksheet.Cells[5, 3].Style.Font.Size = 12;
                    worksheet.Cells[5, 4].Style.Font.Size = 12;
                    worksheet.Cells[5, 5].Style.Font.Size = 12;
                    worksheet.Cells[5, 6].Style.Font.Size = 12;

                    worksheet.Cells[5, 1].Style.Font.Bold = true; // Kalın;
                    worksheet.Cells[5, 2].Style.Font.Bold = true; // Kalın;                    
                    worksheet.Cells[5, 3].Style.Font.Bold = true; // Kalın;                    
                    worksheet.Cells[5, 4].Style.Font.Bold = true; // Kalın;                    
                    worksheet.Cells[5, 5].Style.Font.Bold = true; // Kalın;                    
                    worksheet.Cells[5, 6].Style.Font.Bold = true; // Kalın;
                    worksheet.Row(5).Height = (20); // Excel'de yükseklik yaklaşık %75 ölçekli

                    for (int i = 0; i < listViewBirthDate.Items.Count; i++)
                    {
                        worksheet.Cells[row, 1].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 2].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 3].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 4].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 5].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 6].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 6].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;


                        worksheet.Cells[row, 1].Value = listViewBirthDate.Items[i].SubItems[0].Text;
                        worksheet.Cells[row, 2].Value = listViewBirthDate.Items[i].SubItems[1].Text;
                        worksheet.Cells[row, 3].Value = listViewBirthDate.Items[i].SubItems[2].Text;
                        worksheet.Cells[row, 4].Value = listViewBirthDate.Items[i].SubItems[3].Text;
                        worksheet.Cells[row, 5].Value = listViewBirthDate.Items[i].SubItems[4].Text;
                        worksheet.Cells[row++, 6].Value = listViewBirthDate.Items[i].SubItems[5].Text;

                        worksheet.Cells[row, 6].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        worksheet.Cells[row, 1].Value = "Açıklama:";
                        worksheet.Row(row).Height = (30); // Excel'de yükseklik yaklaşık %75 ölçekli
                        worksheet.Cells[row, 2, row, 6].Merge = true;
                        worksheet.Cells[row, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[row++, 2].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    }

                    worksheet.Cells[row, 1].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    worksheet.Cells[row, 2].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    worksheet.Cells[row, 3].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    worksheet.Cells[row, 4].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    worksheet.Cells[row, 5].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                    worksheet.Cells[row, 6].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    worksheet.Cells[row, 1].Value = "Görüşmeyi Yapan Personel";
                    worksheet.Cells[row, 4].Value = "Onaylayan";
                    worksheet.Cells[row, 4, row, 6].Merge = true;
                    worksheet.Cells[row, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[row++, 4].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    worksheet.Cells[row, 1].Value = ".......................";
                    worksheet.Cells[row, 4].Value = "........";
                    worksheet.Cells[row, 4, row, 6].Merge = true;
                    worksheet.Cells[row, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[row++, 4].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    worksheet.Cells[row, 4].Value = "Gençlik ve Kültür Merkezi Müdürü";
                    worksheet.Cells[row, 4, row, 6].Merge = true;
                    worksheet.Cells[row, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[row, 4].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;


                    worksheet.Cells.Style.Font.Name = "Calibri";
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
                Log.logger.Error($"ExportExcel Error Hata Kodu: 9003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ExportToPdf()
        {
            try
            {
                string pdfPath = Application.StartupPath + "ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                pdfPath += $"birthDate_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document document = new iText.Layout.Document(pdf);

                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(imagePath));
                        img.ScaleToFit(100, 100); // Resmi 100x100 boyutuna ölçeklendirir

                        img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(img);

                        document.Add(new Paragraph());
                        document.Add(new Paragraph("BİGADİÇ BELEDİYESİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("GENÇLİK VE KÜLTÜR MERKEZİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("DOĞUM GÜNÜ KUTLAMA FORMU").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("Tarih:.../.../2025").SetFont(font).SetFontSize(11).SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT));
                        document.Add(new Paragraph());

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

                            table.AddCell("Açıklama:").SetFont(font).SetFontSize(13);
                            table.AddCell(new Cell(1, 5));
                        }

                        document.Add(table);

                        document.Add(new Paragraph());
                        document.Add(new Paragraph("Görüşmeyi Yapan Personel").SetFont(font).SetFontSize(11).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT));
                        // Ana DIV (Sağa hizalı)
                        Div outerDiv = new Div()
                            .SetTextAlignment(TextAlignment.RIGHT) // Sağa hizala
                            .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT) // Sayfanın sağına yasla
                            .SetWidth(200) // Genişlik belirleyerek hizalamayı daha iyi sağlarız
                            .SetMarginRight(20); // Sağdan biraz boşluk bırak

                        // İç DIV (Dikey ortalanmış içerik için)
                        Div innerDiv = new Div()
                            .SetVerticalAlignment(VerticalAlignment.MIDDLE) // Dikey ortala
                            .SetHeight(100) // Dikey ortalamayı sağlamak için yükseklik ver
                            .SetTextAlignment(TextAlignment.CENTER); // Metinleri ortala

                        // İçeriği ekleyelim
                        innerDiv.Add(new Paragraph("Onaylayan").SetFontSize(11));
                        innerDiv.Add(new Paragraph("........").SetFontSize(11));
                        innerDiv.Add(new Paragraph("Gençlik ve Kültür Merkezi Müdürü").SetFontSize(11));

                        // İç divi dış div içine ekle
                        outerDiv.Add(innerDiv);

                        // PDF'ye ekle
                        document.Add(outerDiv);


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
                Log.logger.Error($"ExportToPdf Error Hata Kodu: 9004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void checkBoxMonth_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxMonth.Checked)
                    FillListView(_birthDates);
                else
                {
                    var birthDates = _birthDates.FindAll(b => b.BIRTHDATE.Date.Day == DateTime.Now.Date.Day);
                    FillListView(birthDates);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"checkBoxMonth_CheckedChanged Error Hata Kodu: 9005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillListView(List<Register> birthDates)
        {
            try
            {
                listViewBirthDate.Items.Clear();
                foreach (Register birthDate in birthDates)
                {
                    idStr.Clear();
                    if (birthDate.ID < 10)
                        idStr.Append($"GKM000{birthDate.ID}");
                    else if (birthDate.ID < 100)
                        idStr.Append($"GKM00{birthDate.ID}");
                    else if (birthDate.ID < 1000)
                        idStr.Append($"GKM0{birthDate.ID}");
                    else
                        idStr.Append($"GKM{birthDate.ID}");

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
                Log.logger.Error($"checkBoxMonth_CheckedChanged Error Hata Kodu: 9005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 9005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
