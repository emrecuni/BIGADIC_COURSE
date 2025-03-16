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
    public partial class FormDeleteBranch : Form
    {
        public FormDeleteBranch()
        {
            InitializeComponent();
        }

        StringBuilder query = new StringBuilder();
        List<SqlParameter> parameters = new List<SqlParameter>();

        private void FormDeleteBranch_Load(object sender, EventArgs e)
        {
            try
            {
                GetCourses();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormDeleteBranch_Load Error Hata Kodu: 5000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 5000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDeleteBranch_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();

                List<CheckBox> checkboxes = flowLayoutPanelBranches.Controls.OfType<CheckBox>().Where(c => c.Checked == true).ToList();

                //query.Clear();
                //query.Append("DELETE FROM COURSES WHERE ID IN (");

                //for (int i = 0; i < checkboxes.Count; i++)
                //{
                //    query.Append($"@ID{i + 1}");
                //    parameters.Add(new SqlParameter($"@ID{i + 1}", SqlDbType.Int) { Value = checkboxes[i].Tag });
                //    if (i < checkboxes.Count - 1)
                //        query.Append(',');
                //}
                //query.Append(");");

                query.Clear();
                parameters.Clear();
                for (int i = 0; i < checkboxes.Count; i++)
                {
                    query.Append($"IF NOT EXISTS (SELECT * FROM COURSEREGISTER WHERE COURSE_ID = @Id{i + 1}) " +
                        $"AND NOT EXISTS (SELECT * FROM PERSONELS WHERE COURSE_ID = @Id{i + 1}) " +
                        "BEGIN " +
                        $"DELETE FROM COURSES WHERE ID = @Id{i + 1} " +
                        "END " +
                        "ELSE " +
                        "BEGIN " +
                        "SELECT 'MEVCUT KAYIT BULUNMAKTADIR' " +
                        "END ");
                    parameters.Add(new SqlParameter($"@Id{i + 1}", SqlDbType.Int) { Value = checkboxes[i].Tag });
                }

                int returnCode = await sql.EditData(query.ToString(), parameters);
                switch (returnCode)
                {
                    case 0:
                        Log.logger.Error("buttonDeleteBranch_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 5002");
                        MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 5002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        Log.logger.Info($"Seçilen kurs başarıyla silindi.");
                        GetCourses();
                        MessageBox.Show($"Seçilen Kurs(lar) Başarıyla Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        Log.logger.Warn("Bu kursa kayıtlı öğrenci/Personel bulunmaktadı.");
                        MessageBox.Show("Bu Kursa Kayıtlı Öğrenci/Personel Bulunmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case -1:
                        Log.logger.Error("buttonDeleteBranch_Click Error EditData Hatası. Hata Kodu: 5003");
                        MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 5003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonDeleteBranch_Click Error Hata Kodu: 5001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 5001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCourses()
        {
            try
            {
                Sql sql = new Sql();

                query.Clear();
                query.Append("SELECT * FROM COURSES;");

                DataTable branchesTable = await sql.GetFromDb(query.ToString()); // veri tabanından bütün branşlar çekilir

                flowLayoutPanelBranches.Controls.Clear();
                foreach (DataRow branch in branchesTable.Rows) // veri tabanından çekilen bütün branşlar flowlayoutpanel'a eklenir
                {
                    CheckBox addedBranch = new CheckBox();
                    flowLayoutPanelBranches.Controls.Add(addedBranch);
                    addedBranch.Text = branch.ItemArray[1].ToString();
                    addedBranch.Name = $"checkBox{branch.ItemArray[0]}";
                    addedBranch.Tag = branch.ItemArray[0];
                    addedBranch.Location = new Point(10, 10);
                    addedBranch.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourses Error Hata Kodu: 5004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 5004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
