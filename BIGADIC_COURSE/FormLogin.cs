using BIGADIC_COURSE.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Log = BIGADIC_COURSE.Classes.Log;
using User = BIGADIC_COURSE.Classes.User;
using Microsoft.Data.SqlClient;

namespace BIGADIC_COURSE
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        bool isExit = false;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.logger.Error($"Login Load Error Hata Kodu: 0001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluþtu. Hata Kodu: 0001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                StringBuilder query = new StringBuilder();
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (textBoxUser.Text != null && textBoxPassword.Text != null) // kullanýcý adý ve parolanýn doluluðunu kontrol eder
                {
                    query.Clear();
                    query.Append($"SELECT * FROM USERS WHERE USERNAME = @Username AND PASSWORD = @Password;");

                    parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = $"{textBoxUser.Text.Trim()}" });
                    parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 32) { Value = $"{AESService.Encrypt(textBoxPassword.Text.Trim())}" });

                    DataTable result = await sql.GetFromDb(query.ToString(), parameters);

                    if (result.Rows.Count > 0) // giriþ yapan kullanýcý parola bilgileri doðruysa 
                    {
                        MessageBox.Show($"Hoþgeldiniz {textBoxUser.Text}!", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        User user = new User()
                        {
                            Id = int.Parse(result.Rows[0].ItemArray[0].ToString()),
                            Username = result.Rows[0].ItemArray[1].ToString(),
                            Password = result.Rows[0].ItemArray[2].ToString(),
                            IsAdmin = bool.Parse(result.Rows[0].ItemArray[3].ToString()) ? true : false
                        };

                        textBoxUser.Text = string.Empty;
                        textBoxPassword.Text = string.Empty;
                        textBoxUser.Focus();

                        FormMain formMain = new FormMain(user);
                        Hide();
                        formMain.ShowDialog();
                        Show();
                    }
                    else
                        MessageBox.Show("Hatalý Giriþ!\nGirdiðiniz Deðerleri Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonLogin_Click Error Hata Kodu: 0002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Giriþ Yaparken Bir Hata Oluþtu. Hata Kodu: 0002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isExit) // sadece login ekranýndan kapatýlýrken çýkacak bir pop-up
                {
                    DialogResult dialogResult = MessageBox.Show("Çýkmak Ýstediðinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dialogResult != DialogResult.Yes) // evet dýþýnda bir seçenek seçildiyse kapatýlma event'i iptal edilir
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormLogin_FormClosing Error Hata Kodu: 0003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Giriþ Yaparken Bir Hata Oluþtu. Hata Kodu: 0003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonShowPassword.ImageIndex == 0) // parolayý açar ve ikonu deðiþtirir
                {
                    buttonShowPassword.ImageIndex = 1;
                    textBoxPassword.PasswordChar = '\0';
                }
                else if (buttonShowPassword.ImageIndex == 1) // parolayý gizler ve ikonu deðiþtirir
                {
                    buttonShowPassword.ImageIndex = 0;
                    textBoxPassword.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonShowPassword_Click Error Hata Kodu: 0004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Giriþ Yaparken Bir Hata Oluþtu. Hata Kodu: 0004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    buttonLogin_Click(sender, e);
                else if (e.KeyCode == Keys.Down)
                    SendKeys.Send("{Tab}");
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_KeyDown Error Hata Kodu: 0005 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Giriþ Yaparken Bir Hata Oluþtu. Hata Kodu: 0005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
