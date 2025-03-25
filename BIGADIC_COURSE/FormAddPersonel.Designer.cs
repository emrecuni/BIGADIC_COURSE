namespace BIGADIC_COURSE
{
    partial class FormAddPersonelBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPersonelBranch));
            groupBoxAddBranch = new GroupBox();
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
            groupBoxAddBranch.Controls.Add(buttonAddBranch);
            groupBoxAddBranch.Controls.Add(textBoxBranch);
            groupBoxAddBranch.Controls.Add(labelBranch);
            groupBoxAddBranch.Location = new Point(12, 12);
            groupBoxAddBranch.Name = "groupBoxAddBranch";
            groupBoxAddBranch.Size = new Size(307, 121);
            groupBoxAddBranch.TabIndex = 1;
            groupBoxAddBranch.TabStop = false;
            // 
            // buttonAddBranch
            // 
            buttonAddBranch.BackColor = Color.White;
            buttonAddBranch.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAddBranch.ForeColor = Color.Black;
            buttonAddBranch.Location = new Point(22, 63);
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
            textBoxBranch.Size = new Size(146, 27);
            textBoxBranch.TabIndex = 1;
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(18, 31);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(78, 20);
            labelBranch.TabIndex = 0;
            labelBranch.Text = "Branş Adı:";
            // 
            // FormAddPersonelBranch
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(334, 149);
            Controls.Add(groupBoxAddBranch);
            Font = new Font("Segoe UI Semibold", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormAddPersonelBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Branşı Ekle";
            groupBoxAddBranch.ResumeLayout(false);
            groupBoxAddBranch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAddBranch;
        private Button buttonAddBranch;
        private TextBox textBoxBranch;
        private Label labelBranch;
    }
}