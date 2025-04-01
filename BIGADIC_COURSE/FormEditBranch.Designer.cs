namespace BIGADIC_COURSE
{
    partial class FormEditBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBranch));
            groupBoxAddBranch = new GroupBox();
            comboBoxBranches = new ComboBox();
            comboBoxBranchType = new ComboBox();
            labelType = new Label();
            buttonUpdateBranch = new Button();
            label1 = new Label();
            groupBoxAddBranch.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddBranch
            // 
            groupBoxAddBranch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAddBranch.BackColor = Color.Transparent;
            groupBoxAddBranch.Controls.Add(comboBoxBranches);
            groupBoxAddBranch.Controls.Add(comboBoxBranchType);
            groupBoxAddBranch.Controls.Add(labelType);
            groupBoxAddBranch.Controls.Add(buttonUpdateBranch);
            groupBoxAddBranch.Controls.Add(label1);
            groupBoxAddBranch.Location = new Point(12, 12);
            groupBoxAddBranch.Name = "groupBoxAddBranch";
            groupBoxAddBranch.Size = new Size(307, 167);
            groupBoxAddBranch.TabIndex = 1;
            groupBoxAddBranch.TabStop = false;
            // 
            // comboBoxBranches
            // 
            comboBoxBranches.FormattingEnabled = true;
            comboBoxBranches.Location = new Point(144, 28);
            comboBoxBranches.Name = "comboBoxBranches";
            comboBoxBranches.Size = new Size(146, 28);
            comboBoxBranches.TabIndex = 21;
            comboBoxBranches.SelectedIndexChanged += comboBoxBranches_SelectedIndexChanged;
            // 
            // comboBoxBranchType
            // 
            comboBoxBranchType.Enabled = false;
            comboBoxBranchType.FormattingEnabled = true;
            comboBoxBranchType.Location = new Point(144, 64);
            comboBoxBranchType.Name = "comboBoxBranchType";
            comboBoxBranchType.Size = new Size(146, 28);
            comboBoxBranchType.TabIndex = 20;
            comboBoxBranchType.SelectedIndexChanged += comboBoxBranchType_SelectedIndexChanged;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(18, 65);
            labelType.Name = "labelType";
            labelType.Size = new Size(100, 20);
            labelType.TabIndex = 19;
            labelType.Text = "Personel Tipi:";
            // 
            // buttonUpdateBranch
            // 
            buttonUpdateBranch.BackColor = Color.White;
            buttonUpdateBranch.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonUpdateBranch.ForeColor = Color.Black;
            buttonUpdateBranch.Location = new Point(22, 104);
            buttonUpdateBranch.Name = "buttonUpdateBranch";
            buttonUpdateBranch.Size = new Size(268, 45);
            buttonUpdateBranch.TabIndex = 18;
            buttonUpdateBranch.Text = "Güncelle";
            buttonUpdateBranch.UseVisualStyleBackColor = false;
            buttonUpdateBranch.Click += buttonUpdateBranch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Branş Adı:";
            // 
            // FormEditBranch
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(332, 191);
            Controls.Add(groupBoxAddBranch);
            Font = new Font("Segoe UI Semibold", 11.25F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormEditBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Branş Düzenle";
            Load += FormEditBranch_Load;
            groupBoxAddBranch.ResumeLayout(false);
            groupBoxAddBranch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddBranch;
        private ComboBox comboBoxBranches;
        private ComboBox comboBoxBranchType;
        private Label labelType;
        private Button buttonUpdateBranch;
        private Label label1;
    }
}