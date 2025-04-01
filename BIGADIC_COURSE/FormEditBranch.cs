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
        StringBuilder type = new();
        List<SqlParameter> parameters = new();
        List<Course> allCourses = new();
        Dictionary<int, string> types = new();

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

        private async Task GetBranchTypes() // veri tabanından branş tiplerini çeker
        {
            try
            {
                comboBoxBranchType.Items.Clear();
                comboBoxBranchType.Items.Add("Seçiniz");
                comboBoxBranchType.SelectedIndex = 0;

                types.Clear();

                query.Clear();
                query.Append("SELECT * FROM PERSONELTYPES WHERE ID <> 1;");

                DataTable? results = await sql.GetFromDb(query.ToString());

                if (results != null)
                {
                    foreach (DataRow type in results.Rows) // combobox ve dict'e ekler
                    {
                        comboBoxBranchType.Items.Add(type!.ItemArray[1]!.ToString()!);
                        types.Add(int.Parse(type!.ItemArray[0]!.ToString()!), type!.ItemArray[1]!.ToString()!);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetBranchTypes Error Hata Kodu: 12001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetCourses() // veri tabanından kursları çeker
        {
            try
            {
                comboBoxBranches.Items.Clear();
                comboBoxBranches.Items.Add("Seçiniz");
                comboBoxBranches.SelectedIndex = 0;

                allCourses.Clear();

                query.Clear();
                query.Append("SELECT C.ID, C.NAME, C.TYPE, T.NAME FROM COURSES C " +
                    "LEFT JOIN PERSONELTYPES T ON T.ID = C.TYPE " +
                    "WHERE C.TYPE <> 1 OR C.TYPE IS NULL;");

                DataTable? courses = await sql.GetFromDb(query.ToString());

                if (courses != null)
                {
                    foreach (DataRow course in courses.Rows) // combobox'a ve list'e ekler
                    { 
                        comboBoxBranches.Items.Add(course!.ItemArray[1]!.ToString()!);

                        int.TryParse(course!.ItemArray[2]!.ToString()!, out int typeId);
                        allCourses.Add(new Course
                        {
                            COURSEID = int.Parse(course!.ItemArray[0]!.ToString()!),
                            COURSE = course!.ItemArray[1]!.ToString()!,
                            TYPE = typeId,
                            TYPEDESCRIPTION = course!.ItemArray[3]!.ToString()!
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetCourses Error Hata Kodu: 12002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBranches.SelectedIndex > 0)
                {
                    type.Clear();
                    type.Append(allCourses?.FirstOrDefault
                        (c => c.COURSE == comboBoxBranches.SelectedItem?.ToString())?.TYPEDESCRIPTION);
                    comboBoxBranchType.SelectedItem = type.ToString() != string.Empty ? type.ToString() : "Seçiniz";
                    comboBoxBranchType.Enabled = true;
                }
                else
                {
                    comboBoxBranchType.SelectedIndex = 0;
                    comboBoxBranchType.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"comboBoxBranches_SelectedIndexChanged Error Hata Kodu: 12003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBranchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void buttonUpdateBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBranches.SelectedIndex > 0 && comboBoxBranchType.SelectedIndex > 0)
                {

                    if (allCourses?.FirstOrDefault(c => c.COURSE == comboBoxBranches?.SelectedItem?.ToString())?
                        .TYPEDESCRIPTION != comboBoxBranchType?.SelectedItem?.ToString())
                    {
                        query.Clear();
                        query.Append("UPDATE COURSES SET TYPE = @TypeId WHERE ID = @CourseId;");

                        parameters.Clear();
                        parameters.Add(new SqlParameter("@TypeId", SqlDbType.Int)
                        {
                            Value = types.FirstOrDefault(t => t.Value == comboBoxBranchType?.SelectedItem?.ToString()).Key
                        });
                        parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int)
                        {
                            Value = allCourses!.Find(c => c.COURSE == comboBoxBranches.SelectedItem?.ToString())!.COURSEID
                        });

                        int resultCode = await sql.EditData(query.ToString(), parameters);

                        switch (resultCode)
                        {
                            case 0:
                                Log.logger.Error("Sql Bağlantısı Açılamadı. Hata Kodu: 12005");
                                MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 12005", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            case 1:
                                Log.logger.Info($"Branş Başarıyla Güncellendi. {comboBoxBranches?.SelectedItem?.ToString()}");
                                await GetBranchTypes();
                                await GetCourses();
                                MessageBox.Show("Branş Başarıyla Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("Kayıt Güncellenirken Bir Hata Oluştu. Hata Kodu: 12006");
                                MessageBox.Show("Bir Hata Oluştu. Tekrar Deneyiniz.\nHata Kodu: 12006", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                        MessageBox.Show("Branş Tipi Değiştirilmedi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lütfen Branş ve Tipini Seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonUpdateBranch_Click Error Hata Kodu: 12004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 12004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
