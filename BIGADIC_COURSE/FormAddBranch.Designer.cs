namespace BIGADIC_COURSE
{
    partial class FormAddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBranch));
            groupBoxAddBranch = new GroupBox();
            comboBoxBranchType = new ComboBox();
            labelType = new Label();
            buttonAddBranch = new Button();
            textBoxBranch = new TextBox();
            labelBranch = new Label();
            groupBoxAddBranch.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddBranch
            // 
            groupBoxAddBranch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAddBranch.BackColor = Color.Transparent;
            groupBoxAddBranch.Controls.Add(comboBoxBranchType);
            groupBoxAddBranch.Controls.Add(labelType);
            groupBoxAddBranch.Controls.Add(buttonAddBranch);
            groupBoxAddBranch.Controls.Add(textBoxBranch);
            groupBoxAddBranch.Controls.Add(labelBranch);
            groupBoxAddBranch.Location = new Point(12, 12);
            groupBoxAddBranch.Name = "groupBoxAddBranch";
            groupBoxAddBranch.Size = new Size(307, 167);
            groupBoxAddBranch.TabIndex = 0;
            groupBoxAddBranch.TabStop = false;
            // 
            // comboBoxBranchType
            // 
            comboBoxBranchType.FormattingEnabled = true;
            comboBoxBranchType.Location = new Point(144, 64);
            comboBoxBranchType.Name = "comboBoxBranchType";
            comboBoxBranchType.Size = new Size(146, 26);
            comboBoxBranchType.TabIndex = 20;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(18, 65);
            labelType.Name = "labelType";
            labelType.Size = new Size(120, 18);
            labelType.TabIndex = 19;
            labelType.Text = "Personel Tipi:";
            // 
            // buttonAddBranch
            // 
            buttonAddBranch.BackColor = Color.White;
            buttonAddBranch.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAddBranch.ForeColor = Color.Black;
            buttonAddBranch.Location = new Point(22, 104);
            buttonAddBranch.Name = "buttonAddBranch";
            buttonAddBranch.Size = new Size(268, 45);
            buttonAddBranch.TabIndex = 18;
            buttonAddBranch.Text = "Ekle";
            buttonAddBranch.UseVisualStyleBackColor = false;
            buttonAddBranch.Click += buttonAddBranch_Click;
            // 
            // textBoxBranch
            // 
            textBoxBranch.Location = new Point(144, 25);
            textBoxBranch.Name = "textBoxBranch";
            textBoxBranch.Size = new Size(146, 25);
            textBoxBranch.TabIndex = 1;
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(18, 31);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(88, 18);
            labelBranch.TabIndex = 0;
            labelBranch.Text = "Branş Adı:";
            // 
            // FormAddBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(330, 187);
            Controls.Add(groupBoxAddBranch);
            Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormAddBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Branş Ekle";
            Load += FormAddBranch_Load;
            groupBoxAddBranch.ResumeLayout(false);
            groupBoxAddBranch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAddBranch;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.Button buttonAddBranch;
        private ComboBox comboBoxBranchType;
        private Label labelType;
    }
}