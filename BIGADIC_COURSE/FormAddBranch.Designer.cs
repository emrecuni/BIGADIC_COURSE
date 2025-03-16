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
            this.groupBoxAddBranch = new System.Windows.Forms.GroupBox();
            this.buttonAddBranch = new System.Windows.Forms.Button();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.labelBranch = new System.Windows.Forms.Label();
            this.groupBoxAddBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddBranch
            // 
            this.groupBoxAddBranch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddBranch.Controls.Add(this.buttonAddBranch);
            this.groupBoxAddBranch.Controls.Add(this.textBoxBranch);
            this.groupBoxAddBranch.Controls.Add(this.labelBranch);
            this.groupBoxAddBranch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddBranch.Name = "groupBoxAddBranch";
            this.groupBoxAddBranch.Size = new System.Drawing.Size(274, 127);
            this.groupBoxAddBranch.TabIndex = 0;
            this.groupBoxAddBranch.TabStop = false;
            // 
            // buttonAddBranch
            // 
            this.buttonAddBranch.BackColor = System.Drawing.Color.White;
            this.buttonAddBranch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddBranch.ForeColor = System.Drawing.Color.Black;
            this.buttonAddBranch.Location = new System.Drawing.Point(22, 67);
            this.buttonAddBranch.Name = "buttonAddBranch";
            this.buttonAddBranch.Size = new System.Drawing.Size(236, 45);
            this.buttonAddBranch.TabIndex = 18;
            this.buttonAddBranch.Text = "Ekle";
            this.buttonAddBranch.UseVisualStyleBackColor = false;
            this.buttonAddBranch.Click += new System.EventHandler(this.buttonAddBranch_Click);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(113, 25);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(145, 25);
            this.textBoxBranch.TabIndex = 1;
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(19, 31);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(88, 18);
            this.labelBranch.TabIndex = 0;
            this.labelBranch.Text = "Branş Adı:";
            // 
            // FormAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 147);
            this.Controls.Add(this.groupBoxAddBranch);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAddBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Branş Ekle";
            this.groupBoxAddBranch.ResumeLayout(false);
            this.groupBoxAddBranch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAddBranch;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.Button buttonAddBranch;
    }
}