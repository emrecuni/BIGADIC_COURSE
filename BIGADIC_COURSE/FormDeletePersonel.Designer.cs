namespace BIGADIC_COURSE
{
    partial class FormDeletePersonelBranch
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
            groupBoxDelete = new GroupBox();
            buttonDeleteBranch = new Button();
            groupBoxBranches = new GroupBox();
            flowLayoutPanelBranches = new FlowLayoutPanel();
            groupBoxDelete.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDelete.Controls.Add(buttonDeleteBranch);
            groupBoxDelete.Location = new Point(12, 386);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(424, 64);
            groupBoxDelete.TabIndex = 4;
            groupBoxDelete.TabStop = false;
            // 
            // buttonDeleteBranch
            // 
            buttonDeleteBranch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteBranch.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDeleteBranch.Location = new Point(7, 14);
            buttonDeleteBranch.Name = "buttonDeleteBranch";
            buttonDeleteBranch.Size = new Size(414, 44);
            buttonDeleteBranch.TabIndex = 0;
            buttonDeleteBranch.Text = "Sil";
            buttonDeleteBranch.UseVisualStyleBackColor = true;
            buttonDeleteBranch.Click += buttonDeleteBranch_ClickAsync;
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBranches.Controls.Add(flowLayoutPanelBranches);
            groupBoxBranches.Location = new Point(12, 12);
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.Size = new Size(424, 371);
            groupBoxBranches.TabIndex = 3;
            groupBoxBranches.TabStop = false;
            groupBoxBranches.Text = "Branşlar:";
            // 
            // flowLayoutPanelBranches
            // 
            flowLayoutPanelBranches.Dock = DockStyle.Fill;
            flowLayoutPanelBranches.Font = new Font("Segoe UI", 9F);
            flowLayoutPanelBranches.Location = new Point(3, 23);
            flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            flowLayoutPanelBranches.Size = new Size(418, 345);
            flowLayoutPanelBranches.TabIndex = 0;
            // 
            // FormDeletePersonelBranch
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(445, 459);
            Controls.Add(groupBoxDelete);
            Controls.Add(groupBoxBranches);
            Font = new Font("Segoe UI Semibold", 11.25F);
            Margin = new Padding(4);
            Name = "FormDeletePersonelBranch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Branşı Sil";
            Load += FormDeletePersonelBranch_Load;
            groupBoxDelete.ResumeLayout(false);
            groupBoxBranches.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDelete;
        private Button buttonDeleteBranch;
        private GroupBox groupBoxBranches;
        private FlowLayoutPanel flowLayoutPanelBranches;
    }
}