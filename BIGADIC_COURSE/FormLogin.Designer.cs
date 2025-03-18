namespace BIGADIC_COURSE
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            groupBoxAdminLoginPanel = new GroupBox();
            buttonShowPassword = new Button();
            imageListShowPassword = new ImageList(components);
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            labelPassword = new Label();
            labelKullanici = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxLogo = new PictureBox();
            labelLoginPage = new Label();
            groupBoxAdminLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAdminLoginPanel
            // 
            groupBoxAdminLoginPanel.BackColor = Color.Transparent;
            groupBoxAdminLoginPanel.Controls.Add(buttonShowPassword);
            groupBoxAdminLoginPanel.Controls.Add(buttonLogin);
            groupBoxAdminLoginPanel.Controls.Add(textBoxPassword);
            groupBoxAdminLoginPanel.Controls.Add(textBoxUser);
            groupBoxAdminLoginPanel.Controls.Add(labelPassword);
            groupBoxAdminLoginPanel.Controls.Add(labelKullanici);
            groupBoxAdminLoginPanel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBoxAdminLoginPanel.ForeColor = Color.Black;
            groupBoxAdminLoginPanel.Location = new Point(89, 160);
            groupBoxAdminLoginPanel.Name = "groupBoxAdminLoginPanel";
            groupBoxAdminLoginPanel.Size = new Size(438, 195);
            groupBoxAdminLoginPanel.TabIndex = 0;
            groupBoxAdminLoginPanel.TabStop = false;
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.ImageIndex = 0;
            buttonShowPassword.ImageList = imageListShowPassword;
            buttonShowPassword.Location = new Point(387, 73);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(45, 30);
            buttonShowPassword.TabIndex = 7;
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
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.White;
            buttonLogin.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonLogin.Location = new Point(177, 109);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(204, 49);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Giriş Yap";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(177, 73);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(204, 30);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.KeyDown += textBox_KeyDown;
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.White;
            textBoxUser.ForeColor = Color.Black;
            textBoxUser.Location = new Point(177, 37);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(204, 30);
            textBoxUser.TabIndex = 0;
            textBoxUser.KeyDown += textBox_KeyDown;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelPassword.Location = new Point(55, 76);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(80, 22);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Parola:";
            // 
            // labelKullanici
            // 
            labelKullanici.AutoSize = true;
            labelKullanici.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelKullanici.Location = new Point(25, 40);
            labelKullanici.Name = "labelKullanici";
            labelKullanici.Size = new Size(110, 22);
            labelKullanici.TabIndex = 1;
            labelKullanici.Text = "Kullanıcı:";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.None;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(560, 160);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(238, 195);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // labelLoginPage
            // 
            labelLoginPage.AutoSize = true;
            labelLoginPage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelLoginPage.Location = new Point(13, 13);
            labelLoginPage.Name = "labelLoginPage";
            labelLoginPage.Size = new Size(100, 21);
            labelLoginPage.TabIndex = 3;
            labelLoginPage.Text = "LOGIN PAGE";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(897, 510);
            Controls.Add(labelLoginPage);
            Controls.Add(pictureBoxLogo);
            Controls.Add(groupBoxAdminLoginPanel);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi_İşlem_Ali AYTEKİN";
            FormClosing += FormLogin_FormClosing;
            Load += FormLogin_Load;
            groupBoxAdminLoginPanel.ResumeLayout(false);
            groupBoxAdminLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAdminLoginPanel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ImageList imageListShowPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelLoginPage;
        private System.Windows.Forms.Button buttonShowPassword;
    }
}
