namespace BIGADIC_COURSE
{
    partial class FormAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.imageListShowPassword = new System.Windows.Forms.ImageList(this.components);
            this.buttonShowAgainPassword = new System.Windows.Forms.Button();
            this.textBoxAgainPassword = new System.Windows.Forms.TextBox();
            this.labelAgainPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxAllUsers = new System.Windows.Forms.ComboBox();
            this.groupBoxProcesses = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxUsers.SuspendLayout();
            this.groupBoxProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.buttonShowPassword);
            this.groupBoxUsers.Controls.Add(this.buttonShowAgainPassword);
            this.groupBoxUsers.Controls.Add(this.textBoxAgainPassword);
            this.groupBoxUsers.Controls.Add(this.labelAgainPassword);
            this.groupBoxUsers.Controls.Add(this.textBoxPassword);
            this.groupBoxUsers.Controls.Add(this.textBoxUsername);
            this.groupBoxUsers.Controls.Add(this.checkBoxIsAdmin);
            this.groupBoxUsers.Controls.Add(this.labelPassword);
            this.groupBoxUsers.Controls.Add(this.labelUsername);
            this.groupBoxUsers.Controls.Add(this.labelUser);
            this.groupBoxUsers.Controls.Add(this.comboBoxAllUsers);
            this.groupBoxUsers.Location = new System.Drawing.Point(15, 16);
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUsers.Size = new System.Drawing.Size(413, 246);
            this.groupBoxUsers.TabIndex = 0;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Kullanıcılar:";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.ImageIndex = 0;
            this.buttonShowPassword.ImageList = this.imageListShowPassword;
            this.buttonShowPassword.Location = new System.Drawing.Point(329, 139);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(45, 27);
            this.buttonShowPassword.TabIndex = 10;
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // imageListShowPassword
            // 
            this.imageListShowPassword.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListShowPassword.ImageStream")));
            this.imageListShowPassword.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListShowPassword.Images.SetKeyName(0, "unlock.png");
            this.imageListShowPassword.Images.SetKeyName(1, "lock.png");
            // 
            // buttonShowAgainPassword
            // 
            this.buttonShowAgainPassword.ImageIndex = 0;
            this.buttonShowAgainPassword.ImageList = this.imageListShowPassword;
            this.buttonShowAgainPassword.Location = new System.Drawing.Point(329, 179);
            this.buttonShowAgainPassword.Name = "buttonShowAgainPassword";
            this.buttonShowAgainPassword.Size = new System.Drawing.Size(45, 27);
            this.buttonShowAgainPassword.TabIndex = 9;
            this.buttonShowAgainPassword.UseVisualStyleBackColor = true;
            this.buttonShowAgainPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // textBoxAgainPassword
            // 
            this.textBoxAgainPassword.Location = new System.Drawing.Point(98, 181);
            this.textBoxAgainPassword.Name = "textBoxAgainPassword";
            this.textBoxAgainPassword.PasswordChar = '*';
            this.textBoxAgainPassword.Size = new System.Drawing.Size(226, 27);
            this.textBoxAgainPassword.TabIndex = 8;
            this.textBoxAgainPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelAgainPassword
            // 
            this.labelAgainPassword.AutoSize = true;
            this.labelAgainPassword.Location = new System.Drawing.Point(8, 182);
            this.labelAgainPassword.Name = "labelAgainPassword";
            this.labelAgainPassword.Size = new System.Drawing.Size(57, 20);
            this.labelAgainPassword.TabIndex = 7;
            this.labelAgainPassword.Text = "Parola:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(98, 137);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(226, 27);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(98, 93);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(276, 27);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(98, 215);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(73, 24);
            this.checkBoxIsAdmin.TabIndex = 4;
            this.checkBoxIsAdmin.Text = "Admin";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 138);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Parola:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(8, 94);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(36, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Adı:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(8, 41);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Kullanıcı:";
            // 
            // comboBoxAllUsers
            // 
            this.comboBoxAllUsers.FormattingEnabled = true;
            this.comboBoxAllUsers.Location = new System.Drawing.Point(98, 33);
            this.comboBoxAllUsers.Name = "comboBoxAllUsers";
            this.comboBoxAllUsers.Size = new System.Drawing.Size(276, 28);
            this.comboBoxAllUsers.TabIndex = 0;
            this.comboBoxAllUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllUsers_SelectedIndexChanged);
            // 
            // groupBoxProcesses
            // 
            this.groupBoxProcesses.Controls.Add(this.buttonClear);
            this.groupBoxProcesses.Controls.Add(this.buttonDelete);
            this.groupBoxProcesses.Controls.Add(this.buttonUpdate);
            this.groupBoxProcesses.Controls.Add(this.buttonAdd);
            this.groupBoxProcesses.Location = new System.Drawing.Point(450, 16);
            this.groupBoxProcesses.Name = "groupBoxProcesses";
            this.groupBoxProcesses.Size = new System.Drawing.Size(200, 246);
            this.groupBoxProcesses.TabIndex = 1;
            this.groupBoxProcesses.TabStop = false;
            this.groupBoxProcesses.Text = "İşlemler:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(7, 191);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(187, 38);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Temizle";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 138);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(187, 38);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(7, 85);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(187, 38);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(664, 272);
            this.Controls.Add(this.groupBoxProcesses);
            this.Controls.Add(this.groupBoxUsers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.groupBoxUsers.ResumeLayout(false);
            this.groupBoxUsers.PerformLayout();
            this.groupBoxProcesses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.GroupBox groupBoxProcesses;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxAllUsers;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.TextBox textBoxAgainPassword;
        private System.Windows.Forms.Label labelAgainPassword;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ImageList imageListShowPassword;
        private System.Windows.Forms.Button buttonShowAgainPassword;
        private System.Windows.Forms.Button buttonShowPassword;
    }
}