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
            SuspendLayout();
             this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.groupBoxAdminLoginPanel = new System.Windows.Forms.GroupBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.imageListShowPassword = new System.Windows.Forms.ImageList(this.components);
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLoginPage = new System.Windows.Forms.Label();
            this.groupBoxAdminLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdminLoginPanel
            // 
            this.groupBoxAdminLoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdminLoginPanel.Controls.Add(this.buttonShowPassword);
            this.groupBoxAdminLoginPanel.Controls.Add(this.buttonLogin);
            this.groupBoxAdminLoginPanel.Controls.Add(this.textBoxPassword);
            this.groupBoxAdminLoginPanel.Controls.Add(this.textBoxUser);
            this.groupBoxAdminLoginPanel.Controls.Add(this.labelPassword);
            this.groupBoxAdminLoginPanel.Controls.Add(this.labelKullanici);
            this.groupBoxAdminLoginPanel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAdminLoginPanel.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAdminLoginPanel.Location = new System.Drawing.Point(89, 160);
            this.groupBoxAdminLoginPanel.Name = "groupBoxAdminLoginPanel";
            this.groupBoxAdminLoginPanel.Size = new System.Drawing.Size(438, 195);
            this.groupBoxAdminLoginPanel.TabIndex = 0;
            this.groupBoxAdminLoginPanel.TabStop = false;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.ImageIndex = 0;
            this.buttonShowPassword.ImageList = this.imageListShowPassword;
            this.buttonShowPassword.Location = new System.Drawing.Point(387, 73);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(45, 30);
            this.buttonShowPassword.TabIndex = 7;
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
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.Location = new System.Drawing.Point(177, 109);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(204, 49);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(177, 73);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(204, 30);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.White;
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(177, 37);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(204, 30);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.Location = new System.Drawing.Point(55, 76);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 22);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Parola:";
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullanici.Location = new System.Drawing.Point(25, 40);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(110, 22);
            this.labelKullanici.TabIndex = 1;
            this.labelKullanici.Text = "Kullanıcı:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(560, 160);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(238, 195);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLoginPage
            // 
            this.labelLoginPage.AutoSize = true;
            this.labelLoginPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelLoginPage.Location = new System.Drawing.Point(13, 13);
            this.labelLoginPage.Name = "labelLoginPage";
            this.labelLoginPage.Size = new System.Drawing.Size(100, 21);
            this.labelLoginPage.TabIndex = 3;
            this.labelLoginPage.Text = "LOGIN PAGE";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 510);
            this.Controls.Add(this.labelLoginPage);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBoxAdminLoginPanel);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi_İşlem_Ali AYTEKİN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBoxAdminLoginPanel.ResumeLayout(false);
            this.groupBoxAdminLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            ResumeLayout(false);
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
