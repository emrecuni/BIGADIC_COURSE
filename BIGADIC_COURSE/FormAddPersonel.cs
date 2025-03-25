using BIGADIC_COURSE.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.IO.Image.Jpeg2000ImageData;

namespace BIGADIC_COURSE
{
    public partial class FormAddPersonelBranch : Form
    {
        public FormAddPersonelBranch()
        {
            InitializeComponent();
        }

        Sql sql = new();
        StringBuilder query = new();
        List<SqlParameter> parameters = new();

        private async void buttonAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBranch.Text != null)
                {
                    query.Clear();
                    query.Append("IF NOT EXISTS (SELECT * FROM COURSES WHERE NAME = @Name) " +
                        "BEGIN " +
                        "INSERT INTO COURSES (NAME, TYPE, ADDITION_TIME) VALUES (@Name, @Type, GETDATE()) " +
                        "END " +
                        "ELSE " +
                    "BEGIN " +
                    "SELECT 'MEVCUT KAYIT BULUNMAKTADIR' " +
                    "END ");

                    parameters.Clear();
                    parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50) { Value = textBoxBranch.Text });
                    parameters.Add(new SqlParameter("@Type", SqlDbType.TinyInt) { Value = 1 });
                    int resultCode = await sql.EditData(query.ToString(), parameters);

                    switch (resultCode)
                    {
                        case 0:
                            Log.logger.Error("Sql Bağlantısı Açılamadı. Hata Kodu: 10001");
                            MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 10001", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            Log.logger.Info($"Branş Başarıyla Eklendi. {textBoxBranch.Text}");
                            MessageBox.Show("Branş Başarıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 2:
                            Log.logger.Warn("Branş zaten kayıtlı.");
                            MessageBox.Show($"'{textBoxBranch.Text}' Branşı Zaten Kayıtlı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case -1:
                            Log.logger.Error("Kayıt Eklenirken Bir Hata Oluştu. Hata Kodu: 10002");
                            MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 10002", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                    MessageBox.Show("Lütfen Bir Branş Adı ve Tipini Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonAddBranch_Click Error Hata Kodu: 10000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 10000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
