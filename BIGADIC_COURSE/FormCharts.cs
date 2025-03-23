using BIGADIC_COURSE.Classes;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Kernel.Geom;  // PageSize için gerekli
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
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
    public partial class FormCharts : Form
    {
        public FormCharts(List<Register> registers)
        {
            _registers = registers;
            InitializeComponent();
        }

        StringBuilder query = new StringBuilder();
        List<Register> _registers;
        List<Register> allRegistersList = new List<Register>();
        Dictionary<string, int> chartDict = new Dictionary<string, int>();
        DateTime startDate;
        DateTime endDate;
        string selectedStatusRadioButton; // hangi kayıt tipini seçildiğini tutar list'ten o tipteki kayıtları çekmek için
        string selectedGenderRadioButton; // kurs bazında grafiğinde hangi cinsiyetin seçildiği bilgisi tutulur
        string title = null;
        string logoPath = Application.StartupPath + "LOGO.png";
        string imagePath = Application.StartupPath + $"ExportCharts";
        char selectedChart; // radiobutton değiştirildiğinde en son hangi grafik çizildiyse o grafiği güncellenmesi için tetiklenecek metodu tutar

        private void FormCharts_Load(object sender, EventArgs e)
        {
            try
            {
                //courseToolStripMenuItem_Click(sender, e);
                selectedChart = 'C';
                radioButtonTotal.Checked = true;

                dateTimePickerStartDate.Value = DateTime.Today;
                dateTimePickerEndDate.Value = DateTime.Today;
                DeleteOldSS();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormCharts_Load Error Hata Kodu: 3000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                title = null;
                selectedChart = 'C';
                groupBoxRegisterType.Enabled = true;
                radioButtonMale.Enabled = true;
                radioButtonFemale.Enabled = true;
                startDate = DateTime.MinValue;
                endDate = DateTime.Today;
                chartDict.Clear();
                courseToolStripMenuItem.BackColor = Color.Blue;
                genderToolStripMenuItem.BackColor = Color.Silver;
                registerTypeToolStripMenuItem.BackColor = Color.Silver;

                if (checkBoxSelectDate.Checked) // tarih seçimi aktifse seçilen tarihlere göre liste filtrelenir
                {
                    startDate = dateTimePickerStartDate.Value;
                    endDate = dateTimePickerEndDate.Value;

                    title = $"{startDate.Date:dd.MM.yy} - {endDate.Date:dd.MM.yy} Arasında ";
                }

                title += "Kurs Bazında Branşlara Göre ";
                if (radioButtonMale.Checked)
                    title += "Erkek Kursiyerlerin ";
                else if (radioButtonFemale.Checked)
                    title += "Kadın Kursiyerlerin ";
                if (radioButtonTotal.Checked)
                    title += "Toplam Dağılım Grafiği";
                else if (radioButtonActive.Checked)
                    title += "Aktif Dağılım Grafiği";
                else if (radioButtonPassive.Checked)
                    title += "Pasif Dağılım Grafiği";
                else if (radioButtonWaiting.Checked)
                    title += "Bekleyen Dağılım Grafiği";

                foreach (Register register in _registers)
                {
                    // seçilen kayıt tipini alır
                    if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton != "T" && selectedGenderRadioButton == null && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.STATUS == selectedStatusRadioButton) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                        && r.STATUS == selectedStatusRadioButton));

                    // toplam kayıtları alır
                    else if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton == "T" && selectedGenderRadioButton == null && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate));

                    // seçilen tipteki erkek kayıtları alır
                    else if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton != "T" && selectedGenderRadioButton == "E" && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.STATUS == selectedStatusRadioButton && r.GENDER) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                        && r.STATUS == selectedStatusRadioButton
                        && r.GENDER));

                    // seçilen tipteki kadın kayıtları alır
                    else if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton != "T" && selectedGenderRadioButton == "K" && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.STATUS == selectedStatusRadioButton && r.GENDER == false) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                        && r.STATUS == selectedStatusRadioButton
                        && r.GENDER == false));

                    // toplam erkek kayıtları alır
                    else if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton == "T" && selectedGenderRadioButton == "E" && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.GENDER) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                        && r.GENDER));

                    // toplam kadın kayıtları alır
                    else if (!chartDict.ContainsKey(register.COURSE) && selectedStatusRadioButton == "T" && selectedGenderRadioButton == "K" && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.GENDER == false) > 0)
                        chartDict.Add(register.COURSE, _registers.Count(r => r.COURSE == register.COURSE
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                        && r.GENDER == false));
                }

                DrawChart("Kurs", title);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"courseToolStripMenuItem_Click Error Hata Kodu: 3001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                title = null;
                selectedChart = 'G';
                groupBoxRegisterType.Enabled = true;
                radioButtonMale.Enabled = false;
                radioButtonFemale.Enabled = false;
                startDate = DateTime.MinValue;
                endDate = DateTime.Today;
                chartDict.Clear();
                genderToolStripMenuItem.BackColor = Color.Blue;
                courseToolStripMenuItem.BackColor = Color.Silver;
                registerTypeToolStripMenuItem.BackColor = Color.Silver;

                if (checkBoxSelectDate.Checked) // tarih seçimi aktifse seçilen tarihlere göre liste filtrelenir
                {
                    startDate = dateTimePickerStartDate.Value;
                    endDate = dateTimePickerEndDate.Value;

                    title = $"{startDate.Date:dd.MM.yy} - {endDate.Date:dd.MM.yy} Arasında ";
                }

                title += "Cinsiyet Bazında ";
                if (radioButtonTotal.Checked)
                    title += "Toplam Dağılım Grafiği";
                else if (radioButtonActive.Checked)
                    title += "Aktif Dağılım Grafiği";
                else if (radioButtonPassive.Checked)
                    title += "Pasif Dağılım Grafiği";
                else if (radioButtonWaiting.Checked)
                    title += "Bekleyen Dağılım Grafiği";

                foreach (Register register in _registers)
                {
                    // seçilen kayıt tipini alır
                    if (!chartDict.ContainsKey(register.GENDERDESC) && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate && r.STATUS == selectedStatusRadioButton) > 0 && selectedStatusRadioButton != "T")
                        chartDict.Add(register.GENDERDESC, _registers.Count(r => r.GENDER == register.GENDER
                            && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate
                            && r.STATUS == selectedStatusRadioButton));
                    // toplam kayıtları alır
                    else if (!chartDict.ContainsKey(register.GENDERDESC) && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate) > 0 && selectedStatusRadioButton == "T")
                        chartDict.Add(register.GENDERDESC, _registers.Count(r => r.GENDER == register.GENDER
                        && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate));
                }
                DrawChart("Cinsiyet", title);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"genderToolStripMenuItem_Click Error Hata Kodu: 3002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                title = null;
                selectedChart = 'T';
                groupBoxRegisterType.Enabled = false;
                radioButtonMale.Enabled = true;
                radioButtonFemale.Enabled = true;
                startDate = DateTime.MinValue;
                endDate = DateTime.Today;
                chartDict.Clear();
                registerTypeToolStripMenuItem.BackColor = Color.Blue;
                genderToolStripMenuItem.BackColor = Color.Silver;
                courseToolStripMenuItem.BackColor = Color.Silver;

                if (checkBoxSelectDate.Checked) // tarih seçimi aktifse seçilen tarihlere göre liste filtrelenir
                {
                    startDate = dateTimePickerStartDate.Value;
                    endDate = dateTimePickerEndDate.Value;

                    title = $"{startDate.Date:dd.MM.yy} - {endDate.Date:dd.MM.yy} Arasında ";
                }

                title += "Kayıt Durumu Bazında ";
                if (radioButtonMale.Checked)
                    title += "Erkek Kursiyerlerin ";
                else if (radioButtonFemale.Checked)
                    title += "Kadın Kursiyerlerin ";
                title += "Dağılım Grafiği";

                foreach (Register register in _registers)
                {
                    if (!chartDict.ContainsKey(register.STATUSDESC) && _registers.Count(r => r.COURSE == register.COURSE && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate) > 0)
                        chartDict.Add(register.STATUSDESC, _registers.Count(r => r.STATUSDESC == register.STATUSDESC
                           && r.REGISTERDATE >= startDate && r.REGISTERDATE <= endDate));
                }

                DrawChart("Kayıt Tipi", title);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"registerTypeToolStripMenuItem_Click Error Hata Kodu: 3003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Screenshots(string path)
        {
            try
            {
                Control panel = splitContainerChart.Panel2; // Hedef paneli al
                Bitmap chartBitmap = new Bitmap(panel.Width, panel.Height);

                using (Graphics g = Graphics.FromImage(chartBitmap))
                {
                    g.Clear(panel.BackColor); // Arka plan rengini ayarla
                    panel.DrawToBitmap(chartBitmap, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));
                }

                chartBitmap.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                chartBitmap.Dispose(); // Bellek sızıntısını önlemek için
            }
            catch (Exception ex)
            {
                Log.logger.Error($"Screenshots Error Hata Kodu: 3004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton radioButton = (RadioButton)sender;
                selectedStatusRadioButton = radioButton.Checked ? radioButton.Tag.ToString() : null;

                switch (selectedChart)
                {
                    case 'C':
                        courseToolStripMenuItem_Click(sender, e);
                        break;
                    case 'G':
                        genderToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"radioButton_CheckedChanged Error Hata Kodu: 3005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawChart(string axisName, string title) // grafiği çizer
        {
            try
            {
                splitContainerChart.Panel2.Controls.Clear();
                BarSeries barSeries = new()  // Yeni bir bar serisi oluştur
                {
                    Title = "Kayıt Sayısı",
                    ItemsSource = chartDict.Select(kv => new BarItem { Value = kv.Value }).ToList(),
                    LabelPlacement = LabelPlacement.Inside, // Label konumunu ayarla (Inside, Middle, Outside)
                    LabelFormatString = "{0:N0}" // Sayıyı formatla (Tam sayı)
                };

                CategoryAxis categoryAxis = new() // Kategori ekseni (X ekseni) oluştur
                {
                    Position = AxisPosition.Left, // BarSeries için kategori ekseni sol tarafta olmalı
                    Title = axisName
                };

                foreach (var key in chartDict.Keys) // Etiketleri manuel olarak ekleyelim
                    categoryAxis.Labels.Add(key);

                // Y ekseni (Değer ekseni)
                LinearAxis valueAxis = new()
                {
                    Position = AxisPosition.Bottom,
                    Title = "Kayıt Sayısı"
                };

                PlotModel plotModel = new() // Grafik modeli oluştur ve eksenleri/serileri ekle
                {
                    Title = title
                };

                plotModel.Series.Add(barSeries);

                plotModel.Axes.Add(valueAxis);
                plotModel.Axes.Add(categoryAxis);

                PlotView plotView = new()
                {
                    Model = plotModel,
                    Dock = DockStyle.Fill
                };

                splitContainerChart.Panel2.Controls.Add(plotView);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"DrawChartGenders Error Hata Kodu: 3006 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3006", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                switch (selectedChart)
                {
                    case 'C':
                        courseToolStripMenuItem_Click(sender, e);
                        break;
                    case 'G':
                        genderToolStripMenuItem_Click(sender, e);
                        break;
                    case 'T':
                        registerTypeToolStripMenuItem_Click(sender, e);
                        break;
                }

                //comboBoxFilters_SelectedIndexChanged(sender, e); // tarih seçimi yapıldıktan listeleme işlemi tekrar tetiklenir
            }
            catch (Exception ex)
            {
                Log.logger.Error($"dateTimePicker_ValueChanged Error Hata Kodu: 3007 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3007", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                switch (selectedChart)
                {
                    case 'C':
                        courseToolStripMenuItem_Click(sender, e);
                        break;
                    case 'G':
                        genderToolStripMenuItem_Click(sender, e);
                        break;
                    case 'T':
                        registerTypeToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"checkBoxSelectDate_CheckedChanged Error Hata Kodu: 3008 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3008", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonGender_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton radioButtonGender = (RadioButton)sender;
                selectedGenderRadioButton = radioButtonGender.Checked ? radioButtonGender.Tag.ToString() : null;

                switch (selectedChart)
                {
                    case 'C':
                        courseToolStripMenuItem_Click(sender, e);
                        break;
                    case 'T':
                        registerTypeToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"radioButtonMale_CheckedChanged Error Hata Kodu: 3009 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3009", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearGender_Click(object sender, EventArgs e)
        {
            try
            {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                selectedGenderRadioButton = null;

                switch (selectedChart)
                {
                    case 'C':
                        courseToolStripMenuItem_Click(sender, e);
                        break;
                    case 'T':
                        registerTypeToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonClearGender_Click Error Hata Kodu: 3010 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3010", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (splitContainerChart.Panel2.Controls.Count > 0)
                {
                    imagePath = Application.StartupPath + $"ExportCharts";
                    if (!Directory.Exists(imagePath))
                        Directory.CreateDirectory(imagePath);
                    imagePath += $"\\chart_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.png";
                    Screenshots(imagePath);
                    if(ExportToPdf())
                    MessageBox.Show("Grafik Pdf Dosyasına Başarıyla Aktarıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);                                        
                }
                else
                    MessageBox.Show("Çizilmiş Bir Grafik Bulunmamaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            catch (Exception ex)
            {
                Log.logger.Error($"exportToPdfToolStripMenuItem_Click Error Hata Kodu: 3011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExportToPdf()
        {
            try
            {
                
                string pdfPath = Application.StartupPath + "ExportPdf\\";
                if (!Directory.Exists(pdfPath))
                    Directory.CreateDirectory(pdfPath);

                pdfPath += $"chart_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.pdf";

                using (PdfWriter writer = new PdfWriter(new FileInfo(pdfPath)))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        
                        pdf.AddNewPage(iText.Kernel.Geom.PageSize.A4.Rotate());

                        iText.Layout.Document document = new iText.Layout.Document(pdf);
                        document.SetMargins(0, 10, 30, 10);


                        PdfFont font = PdfFontFactory.CreateFont("C:/Windows/Fonts/arial.ttf", PdfEncodings.IDENTITY_H);

                        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(logoPath));
                        img.ScaleToFit(50, 50); // Resmi 100x100 boyutuna ölçeklendirir

                        img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(img);
                        document.Add(new Paragraph("BİGADİÇ BELEDİYESİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));
                        document.Add(new Paragraph("GENÇLİK VE KÜLTÜR MERKEZİ").SetFont(font).SetFontSize(16).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));


                        img = new iText.Layout.Element.Image(ImageDataFactory.Create(imagePath));
                        img.SetAutoScale(true);

                        img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(img);

                        document.Add(new Paragraph());

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
                Log.logger.Error($"ExportToPdf Error Hata Kodu: 3012 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3012", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DeleteOldSS()
        {
            try
            {
                string ssPath = Application.StartupPath + $"ExportCharts";
                var oldSS = Directory.GetFiles(ssPath) ;

                if (oldSS.Length > 0)
                {
                    foreach (var file in oldSS)
                    {
                        if (File.GetLastWriteTime(file) < DateTime.Now.AddDays(-7))
                            File.Delete(file);
                    }
                }

            }
            catch (Exception ex)
            {
                Log.logger.Error($"DeleteOldSS Error Hata Kodu: 3013 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 3013", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
