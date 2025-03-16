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

namespace BIGADIC_COURSE
{
    public partial class FormAdminPanel : Form
    {
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        StringBuilder query = new StringBuilder();
        List<SqlParameter> parameters = new List<SqlParameter>();
        List<User> allUsers = new List<User>();

        private async void FormAdminPanel_Load(object sender, EventArgs e) // form yüklenirken veri tabanındaki bütün kullanıcılar çekilir ve combobox'a eklenir
        {
            try
            {
                await Task.Run(() => { GetUsers(); });// bütün kullanıcıları db'den çeker ve combobox'a ekler               
            }
            catch (Exception ex)
            {
                Log.logger.Error($"FormAdminPanel_Load Error Hata Kodu: 7000 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7000", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty && textBoxAgainPassword.Text != string.Empty)
                {
                    if (textBoxPassword.Text == textBoxAgainPassword.Text)
                    {
                        Sql sql = new Sql();

                        query.Clear();
                        query.Append("SELECT TOP 1 * FROM USERS WHERE USERNAME = @User;");

                        parameters.Clear();
                        parameters.Add(new SqlParameter("@User", SqlDbType.NVarChar, 50) { Value = textBoxUsername.Text.Trim() });
                        DataTable user = await sql.GetFromDb(query.ToString(), parameters);
                        if (user.Rows.Count == 0)
                        {
                            query.Clear();
                            query.Append("INSERT INTO USERS (USERNAME, PASSWORD, ISADMIN, ADDITION_TIME) VALUES (@User, @Password, @IsAdmin, GETDATE());");

                            parameters.Clear();
                            parameters.Add(new SqlParameter("@User", SqlDbType.NVarChar, 50) { Value = textBoxUsername.Text.Trim() });
                            parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 32) { Value = AESService.Encrypt(textBoxPassword.Text) });
                            parameters.Add(new SqlParameter("@IsAdmin", SqlDbType.Bit) { Value = checkBoxIsAdmin.Checked ? 1 : 0 });

                            int returnCode = await sql.EditData(query.ToString(), parameters);

                            switch (returnCode)
                            {
                                case 0:
                                    Log.logger.Error("buttonAdd_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 7007");
                                    MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7007", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 1:
                                    Log.logger.Info($"Kayıt Başarıyla Eklendi. {comboBoxAllUsers.SelectedItem}");
                                    GetUsers(); // kullanıcı listesini günceller
                                    MessageBox.Show($"Kayıt Başarıyla Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case -1:
                                    Log.logger.Error("buttonAdd_Click Error EditData Hatası. Hata Kodu: 7008");
                                    MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7008", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                            MessageBox.Show("Girilen Kullanıcı Adıyla Kayıtlı Kullanıcı Bulunmaktadır.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Girilen Parolalar Eşleşmiyor. Lütfen Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lütfen Kullanıcı Adı ve Parola Bilgilerini Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonAdd_Click Error Hata Kodu: 7001 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7001", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != string.Empty)
                {
                    if (textBoxPassword.Text == textBoxAgainPassword.Text)
                    {
                        Sql sql = new Sql();

                        query.Clear();
                        query.Append(@"UPDATE USERS SET ");

                        parameters.Clear();

                        if (textBoxPassword.Text != string.Empty) // kullanıcı parolayı da güncellemek isterse
                        {
                            query.Append("PASSWORD = @Password, ");
                            parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 32) { Value = AESService.Encrypt(textBoxPassword.Text) });
                        }

                        query.Append(@"ISADMIN = @IsAdmin, UPDATED_TIME = GETDATE() 
                        WHERE ID = @Id;");

                        parameters.Add(new SqlParameter("@IsAdmin", SqlDbType.Bit) { Value = checkBoxIsAdmin.Checked ? 1 : 0 });
                        parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = allUsers.Find(u => u.Username == comboBoxAllUsers.SelectedItem.ToString()).Id });

                        int returnCode = await sql.EditData(query.ToString(), parameters);

                        switch (returnCode)
                        {
                            case 0:
                                Log.logger.Error("buttonUpdate_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 7009");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7009", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Kayıt Başarıyla Güncellendi. {comboBoxAllUsers.SelectedItem}");
                                GetUsers(); // kullanıcı listesini günceller
                                MessageBox.Show($"Kayıt Başarıyla Güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("buttonUpdate_Click Error EditData Hatası. Hata Kodu: 7010");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7010", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                        MessageBox.Show("Girilen Parolalar Eşleşmiyor. Lütfen Kontrol Ediniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Lütfen Kullanıcı Adı Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonUpdate_Click Error Hata Kodu: 7002 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7002", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAllUsers.SelectedIndex > 0)
                {
                    DialogResult dialogResult = MessageBox.Show($"{comboBoxAllUsers.SelectedItem} Adlı Kullanıcıyı Silmek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes) // kullanıcı evet'e tıklarsa kullanıcıyı siler
                    {
                        Sql sql = new Sql();

                        query.Clear();
                        query.Append("DELETE FROM USERS WHERE ID = @Id;");

                        parameters.Clear();
                        parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = allUsers.Find(u => u.Username == comboBoxAllUsers.SelectedItem.ToString()).Id });

                        int returnCode = await sql.EditData(query.ToString(), parameters);

                        switch (returnCode)
                        {
                            case 0:
                                Log.logger.Error("buttonDelete_Click Error Sql Bağlantısı Açılamadı. Hata Kodu: 7005");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7005", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case 1:
                                Log.logger.Info($"Kayıt Başarıyla Silindi. {comboBoxAllUsers.SelectedItem}");
                                GetUsers(); // kullanıcı listesini günceller
                                textBoxAgainPassword.Text = string.Empty;
                                textBoxPassword.Text = string.Empty;
                                textBoxUsername.Text = string.Empty;
                                checkBoxIsAdmin.Checked = false;
                                comboBoxAllUsers.SelectedIndex = 0;
                                MessageBox.Show($"Kayıt Başarıyla Silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1:
                                Log.logger.Error("buttonDelete_Click Error EditData Hatası. Hata Kodu: 7006");
                                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7006", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonDelete_Click Error Hata Kodu: 7003 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7003", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAllUsers.SelectedIndex > 0) // combobox'ta seçilen kullanıcıyı list içinde arar ve eşleşen kaydı textbox ve checkbox'a ekler
                {
                    textBoxUsername.Text = allUsers.Find(u => u.Username == comboBoxAllUsers.SelectedItem.ToString()).Username;
                    checkBoxIsAdmin.Checked = allUsers.Find(u => u.Username == comboBoxAllUsers.SelectedItem.ToString()).IsAdmin;
                    textBoxUsername.Enabled = false;
                    textBoxPassword.Text = string.Empty;
                    textBoxAgainPassword.Text = string.Empty;
                }
                else if (comboBoxAllUsers.SelectedIndex == 0)
                    buttonClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"comboBoxAllUsers_SelectedIndexChanged Error Hata Kodu: 7004 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7004", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) // ekranı temizler
        {
            try
            {
                comboBoxAllUsers.SelectedIndex = 0;
                textBoxUsername.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxAgainPassword.Text = string.Empty;
                checkBoxIsAdmin.Checked = false;
                textBoxUsername.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonClear_Click Error Hata Kodu: 7011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetUsers()
        {
            try
            {
                Sql sql = new Sql();

                query.Clear();
                query.Append("SELECT * FROM USERS;");

                DataTable usersTable = await sql.GetFromDb(query.ToString());

                comboBoxAllUsers.Items.Clear();
                comboBoxAllUsers.Items.Add("Seçiniz");
                foreach (DataRow user in usersTable.Rows)
                {
                    comboBoxAllUsers.Items.Add(user.ItemArray[1].ToString());
                    allUsers.Add(new User
                    {
                        Id = int.Parse(user.ItemArray[0].ToString()),
                        Username = user.ItemArray[1].ToString(),
                        Password = user.ItemArray[2].ToString(),
                        IsAdmin = bool.Parse(user.ItemArray[3].ToString()) ? true : false
                    });
                }
                comboBoxAllUsers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetUsers Error Hata Kodu: 7011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (sender) as Button; // hangi butondan tetiklendiğini bulmak için kullanılır
                if (button.Name == "buttonShowPassword")
                {
                    if (button.ImageIndex == 0) // parolayı açar ve ikonu değiştirir
                    {
                        button.ImageIndex = 1;
                        textBoxPassword.PasswordChar = '\0';
                    }
                    else if (button.ImageIndex == 1) // parolayı gizler ve ikonu değiştirir
                    {
                        button.ImageIndex = 0;
                        textBoxPassword.PasswordChar = '*';
                    }
                }
                else if (button.Name == "buttonShowAgainPassword")
                {
                    if (button.ImageIndex == 0) // parolayı açar ve ikonu değiştirir
                    {
                        button.ImageIndex = 1;
                        textBoxAgainPassword.PasswordChar = '\0';
                    }
                    else if (button.ImageIndex == 1) // parolayı gizler ve ikonu değiştirir
                    {
                        button.ImageIndex = 0;
                        textBoxAgainPassword.PasswordChar = '*';
                    }
                }
            }
            catch (Exception ex)
            {
                Log.logger.Error($"buttonShowPassword_Click Error Hata Kodu: 7011 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7011", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                    SendKeys.Send("{Tab}");
            }
            catch (Exception ex)
            {
                Log.logger.Error($"textBox_KeyDown Error Hata Kodu: 7012 ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                MessageBox.Show("Bir Hata Oluştu. Hata Kodu: 7012", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
