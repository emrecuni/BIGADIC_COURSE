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

namespace BIGADIC_COURSE
{
    public partial class FormAddBranch : Form
    {
        public FormAddBranch()
        {
            InitializeComponent();
        }

        Sql sql = new();
        StringBuilder query = new();
        List<SqlParameter> parameters = new();
        Dictionary<int, string> types = new();

        private async void FormAddBranch_Load(object sender, EventArgs e)
        {
            try
            {
                await GetBranchTypes();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormAddBranch_Load Error Hata Kodu: 4000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 4000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonAddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBranch.Text != null && comboBoxBranchType.SelectedIndex > 0)
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
                    parameters.Add(new SqlParameter("@Type", SqlDbType.TinyInt) { Value = types.First(t => t.Value == comboBoxBranchType.SelectedItem.ToString()).Key });

                    int resultCode = await sql.EditData(query.ToString(), parameters);

                    switch (resultCode)
                    {
                        case 0:
                            Log.logger.Error("Sql Bağlantısı Açılamadı. Hata Kodu: 4001");
                            MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 4001", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            Log.logger.Error("Kayıt Eklenirken Bir Hata Oluştu. Hata Kodu: 4002");
                            MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 4002", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                    MessageBox.Show("Lütfen Bir Branş Adı ve Tipini Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonAddBranch_Click Error Hata Kodu: 4003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 4003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetBranchTypes()
        {
            try
            {
                comboBoxBranchType.Items.Clear();
                comboBoxBranchType.Items.Add("Seçiniz");
                comboBoxBranchType.SelectedIndex = 0;

                query.Clear();
                query.Append("SELECT * FROM PERSONELTYPES WHERE ID <> 1;");

                DataTable? results = await sql.GetFromDb(query.ToString());

                if (results != null)
                {
                    foreach (DataRow type in results.Rows)
                    {
                        comboBoxBranchType.Items.Add(type.ItemArray[1].ToString());
                        types.Add(int.Parse(type.ItemArray[0].ToString()), type.ItemArray[1].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetBranchTypes Error Hata Kodu: 4004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 4004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
