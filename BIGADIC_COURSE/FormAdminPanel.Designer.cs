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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            groupBoxUsers = new GroupBox();
            buttonShowPassword = new Button();
            imageListShowPassword = new ImageList(components);
            buttonShowAgainPassword = new Button();
            textBoxAgainPassword = new TextBox();
            labelAgainPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            checkBoxIsAdmin = new CheckBox();
            labelPassword = new Label();
            labelUsername = new Label();
            labelUser = new Label();
            comboBoxAllUsers = new ComboBox();
            groupBoxProcesses = new GroupBox();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            groupBoxUsers.SuspendLayout();
            groupBoxProcesses.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsers
            // 
            groupBoxUsers.Controls.Add(buttonShowPassword);
            groupBoxUsers.Controls.Add(buttonShowAgainPassword);
            groupBoxUsers.Controls.Add(textBoxAgainPassword);
            groupBoxUsers.Controls.Add(labelAgainPassword);
            groupBoxUsers.Controls.Add(textBoxPassword);
            groupBoxUsers.Controls.Add(textBoxUsername);
            groupBoxUsers.Controls.Add(checkBoxIsAdmin);
            groupBoxUsers.Controls.Add(labelPassword);
            groupBoxUsers.Controls.Add(labelUsername);
            groupBoxUsers.Controls.Add(labelUser);
            groupBoxUsers.Controls.Add(comboBoxAllUsers);
            groupBoxUsers.Location = new Point(15, 16);
            groupBoxUsers.Margin = new Padding(4);
            groupBoxUsers.Name = "groupBoxUsers";
            groupBoxUsers.Padding = new Padding(4);
            groupBoxUsers.Size = new Size(413, 246);
            groupBoxUsers.TabIndex = 0;
            groupBoxUsers.TabStop = false;
            groupBoxUsers.Text = "Kullanıcılar:";
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.ImageIndex = 0;
            buttonShowPassword.ImageList = imageListShowPassword;
            buttonShowPassword.Location = new Point(329, 139);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(45, 27);
            buttonShowPassword.TabIndex = 10;
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // imageListShowPassword
            // 
            imageListShowPassword.ColorDepth = ColorDepth.Depth32Bit;
            imageListShowPassword.ImageStream = (ImageListStreamer)resources.GetObject("imageListShowPassword.ImageStream");
            imageListShowPassword.TransparentColor = Color.Transparent;
            imageListShowPassword.Images.SetKeyName(0, "unlock.png");
            imageListShowPassword.Images.SetKeyName(1, "lock.png");
            // 
            // buttonShowAgainPassword
            // 
            buttonShowAgainPassword.ImageIndex = 0;
            buttonShowAgainPassword.ImageList = imageListShowPassword;
            buttonShowAgainPassword.Location = new Point(329, 179);
            buttonShowAgainPassword.Name = "buttonShowAgainPassword";
            buttonShowAgainPassword.Size = new Size(45, 27);
            buttonShowAgainPassword.TabIndex = 9;
            buttonShowAgainPassword.UseVisualStyleBackColor = true;
            buttonShowAgainPassword.Click += buttonShowPassword_Click;
            // 
            // textBoxAgainPassword
            // 
            textBoxAgainPassword.Location = new Point(98, 181);
            textBoxAgainPassword.Name = "textBoxAgainPassword";
            textBoxAgainPassword.PasswordChar = '*';
            textBoxAgainPassword.Size = new Size(226, 27);
            textBoxAgainPassword.TabIndex = 8;
            textBoxAgainPassword.KeyDown += textBox_KeyDown;
            // 
            // labelAgainPassword
            // 
            labelAgainPassword.AutoSize = true;
            labelAgainPassword.Location = new Point(8, 182);
            labelAgainPassword.Name = "labelAgainPassword";
            labelAgainPassword.Size = new Size(57, 20);
            labelAgainPassword.TabIndex = 7;
            labelAgainPassword.Text = "Parola:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(98, 137);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(226, 27);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.KeyDown += textBox_KeyDown;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(98, 93);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(276, 27);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.KeyDown += textBox_KeyDown;
            // 
            // checkBoxIsAdmin
            // 
            checkBoxIsAdmin.AutoSize = true;
            checkBoxIsAdmin.Location = new Point(98, 215);
            checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            checkBoxIsAdmin.Size = new Size(73, 24);
            checkBoxIsAdmin.TabIndex = 4;
            checkBoxIsAdmin.Text = "Admin";
            checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(8, 138);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Parola:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(8, 94);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(36, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Adı:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(8, 41);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(71, 20);
            labelUser.TabIndex = 1;
            labelUser.Text = "Kullanıcı:";
            // 
            // comboBoxAllUsers
            // 
            comboBoxAllUsers.FormattingEnabled = true;
            comboBoxAllUsers.Location = new Point(98, 33);
            comboBoxAllUsers.Name = "comboBoxAllUsers";
            comboBoxAllUsers.Size = new Size(276, 28);
            comboBoxAllUsers.TabIndex = 0;
            comboBoxAllUsers.SelectedIndexChanged += comboBoxAllUsers_SelectedIndexChanged;
            // 
            // groupBoxProcesses
            // 
            groupBoxProcesses.Controls.Add(buttonClear);
            groupBoxProcesses.Controls.Add(buttonDelete);
            groupBoxProcesses.Controls.Add(buttonUpdate);
            groupBoxProcesses.Controls.Add(buttonAdd);
            groupBoxProcesses.Location = new Point(450, 16);
            groupBoxProcesses.Name = "groupBoxProcesses";
            groupBoxProcesses.Size = new Size(200, 246);
            groupBoxProcesses.TabIndex = 1;
            groupBoxProcesses.TabStop = false;
            groupBoxProcesses.Text = "İşlemler:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(7, 191);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(187, 38);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Temizle";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(7, 138);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(187, 38);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(7, 85);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(187, 38);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(7, 32);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(187, 38);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(664, 272);
            Controls.Add(groupBoxProcesses);
            Controls.Add(groupBoxUsers);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FormAdminPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yönetici Paneli";
            Load += FormAdminPanel_Load;
            groupBoxUsers.ResumeLayout(false);
            groupBoxUsers.PerformLayout();
            groupBoxProcesses.ResumeLayout(false);
            ResumeLayout(false);
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