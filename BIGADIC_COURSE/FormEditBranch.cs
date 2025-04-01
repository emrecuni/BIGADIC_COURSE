using BIGADIC_COURSE.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIGADIC_COURSE
{
    public partial class FormEditBranch : Form
    {
        public FormEditBranch()
        {
            InitializeComponent();
        }

        Sql sql = new();
        StringBuilder query = new();
        List<SqlParameter> parameters = new();
        Dictionary<int, string> types = new();
        List<Course> allCourses = new();

        private async void FormEditBranch_Load(object sender, EventArgs e)
        {
            try
            {
                await GetBranchTypes();
                await GetCourses();
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormEditBranch_Load Error Hata Kodu: 12000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log.logger.Error($"GetBranchTypes Error Hata Kodu: 12001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetCourses()
        {
            try
            {
                comboBoxBranches.Items.Clear();
                comboBoxBranches.Items.Add("Seçiniz");
                comboBoxBranches.SelectedIndex = 0;

                query.Clear();
                query.Append("SELECT C.ID, C.NAME, C.TYPE, T.NAME FROM COURSES C " +
                    "LEFT JOIN PERSONELTYPES T ON T.ID = C.TYPE;");

                DataTable? courses = await sql.GetFromDb(query.ToString());

                if (courses != null)
                {
                    foreach(DataRow course in courses.Rows)
                    {
                        comboBoxBranches.Items.Add(course.ItemArray[1].ToString());
                        allCourses.Add(new Course
                        {
                            COURSEID = int.Parse(course.ItemArray[0].ToString()),
                            COURSE = course.ItemArray[1].ToString(),
                            
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetBranchTypes Error Hata Kodu: 12001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBranchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateBranch_Click(object sender, EventArgs e)
        {

        }
    }
}
