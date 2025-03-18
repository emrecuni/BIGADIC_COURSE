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
            flowLayoutPanelBranches = new FlowLayoutPanel();
            groupBoxBranches = new GroupBox();
            groupBoxDelete = new GroupBox();
            buttonDeleteBranch = new Button();
            groupBoxBranches.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBranches
            // 
            flowLayoutPanelBranches.Dock = DockStyle.Fill;
            flowLayoutPanelBranches.Font = new Font("Segoe UI", 9F);
            flowLayoutPanelBranches.Location = new Point(3, 21);
            flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            flowLayoutPanelBranches.Size = new Size(418, 347);
            flowLayoutPanelBranches.TabIndex = 0;
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBranches.Controls.Add(flowLayoutPanelBranches);
            groupBoxBranches.Location = new Point(12, 12);
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.Size = new Size(424, 371);
            groupBoxBranches.TabIndex = 1;
            groupBoxBranches.TabStop = false;
            groupBoxBranches.Text = "Branşlar:";
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDelete.Controls.Add(buttonDeleteBranch);
            groupBoxDelete.Location = new Point(12, 387);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(424, 64);
            groupBoxDelete.TabIndex = 2;
            groupBoxDelete.TabStop = false;
            // 
            // buttonDeleteBranch
            // 
            buttonDeleteBranch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteBranch.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDeleteBranch.Location = new Point(7, 14);
            buttonDeleteBranch.Name = "buttonDeleteBranch";
            buttonDeleteBranch.Size = new Size(408, 44);
            buttonDeleteBranch.TabIndex = 0;
            buttonDeleteBranch.Text = "Sil";
            buttonDeleteBranch.UseVisualStyleBackColor = true;
            buttonDeleteBranch.Click += buttonDeleteBranch_Click;
            // 
            // FormDeleteBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(448, 463);
            Controls.Add(groupBoxDelete);
            Controls.Add(groupBoxBranches);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormDeleteBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Branş Sil";
            Load += FormDeleteBranch_Load;
            groupBoxBranches.ResumeLayout(false);
            groupBoxDelete.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBranches;
        private System.Windows.Forms.GroupBox groupBoxBranches;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDeleteBranch;
    }
}