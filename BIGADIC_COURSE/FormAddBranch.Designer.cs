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
            buttonAddBranch = new Button();
            textBoxBranch = new TextBox();
            labelBranch = new Label();
            groupBoxAddBranch.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddBranch
            // 
            groupBoxAddBranch.BackColor = Color.Transparent;
            groupBoxAddBranch.Controls.Add(buttonAddBranch);
            groupBoxAddBranch.Controls.Add(textBoxBranch);
            groupBoxAddBranch.Controls.Add(labelBranch);
            groupBoxAddBranch.Location = new Point(12, 12);
            groupBoxAddBranch.Name = "groupBoxAddBranch";
            groupBoxAddBranch.Size = new Size(274, 127);
            groupBoxAddBranch.TabIndex = 0;
            groupBoxAddBranch.TabStop = false;
            // 
            // buttonAddBranch
            // 
            buttonAddBranch.BackColor = Color.White;
            buttonAddBranch.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonAddBranch.ForeColor = Color.Black;
            buttonAddBranch.Location = new Point(22, 67);
            buttonAddBranch.Name = "buttonAddBranch";
            buttonAddBranch.Size = new Size(236, 45);
            buttonAddBranch.TabIndex = 18;
            buttonAddBranch.Text = "Ekle";
            buttonAddBranch.UseVisualStyleBackColor = false;
            buttonAddBranch.Click += buttonAddBranch_Click;
            // 
            // textBoxBranch
            // 
            textBoxBranch.Location = new Point(113, 25);
            textBoxBranch.Name = "textBoxBranch";
            textBoxBranch.Size = new Size(145, 25);
            textBoxBranch.TabIndex = 1;
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(19, 31);
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
            ClientSize = new Size(298, 147);
            Controls.Add(groupBoxAddBranch);
            Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormAddBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Branş Ekle";
            groupBoxAddBranch.ResumeLayout(false);
            groupBoxAddBranch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAddBranch;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.Button buttonAddBranch;
    }
}