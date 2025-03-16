namespace BIGADIC_COURSE
{
    partial class FormDeleteBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteBranch));
            this.flowLayoutPanelBranches = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxBranches = new System.Windows.Forms.GroupBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDeleteBranch = new System.Windows.Forms.Button();
            this.groupBoxBranches.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBranches
            // 
            this.flowLayoutPanelBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBranches.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flowLayoutPanelBranches.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            this.flowLayoutPanelBranches.Size = new System.Drawing.Size(418, 347);
            this.flowLayoutPanelBranches.TabIndex = 0;
            // 
            // groupBoxBranches
            // 
            this.groupBoxBranches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBranches.Controls.Add(this.flowLayoutPanelBranches);
            this.groupBoxBranches.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBranches.Name = "groupBoxBranches";
            this.groupBoxBranches.Size = new System.Drawing.Size(424, 371);
            this.groupBoxBranches.TabIndex = 1;
            this.groupBoxBranches.TabStop = false;
            this.groupBoxBranches.Text = "Branşlar:";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDelete.Controls.Add(this.buttonDeleteBranch);
            this.groupBoxDelete.Location = new System.Drawing.Point(12, 387);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(424, 64);
            this.groupBoxDelete.TabIndex = 2;
            this.groupBoxDelete.TabStop = false;
            // 
            // buttonDeleteBranch
            // 
            this.buttonDeleteBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteBranch.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteBranch.Location = new System.Drawing.Point(7, 14);
            this.buttonDeleteBranch.Name = "buttonDeleteBranch";
            this.buttonDeleteBranch.Size = new System.Drawing.Size(408, 44);
            this.buttonDeleteBranch.TabIndex = 0;
            this.buttonDeleteBranch.Text = "Sil";
            this.buttonDeleteBranch.UseVisualStyleBackColor = true;
            this.buttonDeleteBranch.Click += new System.EventHandler(this.buttonDeleteBranch_Click);
            // 
            // FormDeleteBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(448, 463);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxBranches);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDeleteBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Branş Sil";
            this.Load += new System.EventHandler(this.FormDeleteBranch_Load);
            this.groupBoxBranches.ResumeLayout(false);
            this.groupBoxDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBranches;
        private System.Windows.Forms.GroupBox groupBoxBranches;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDeleteBranch;
    }
}