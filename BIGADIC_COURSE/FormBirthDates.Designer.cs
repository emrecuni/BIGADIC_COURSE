namespace BIGADIC_COURSE
{
    partial class FormBirthDates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirthDates));
            this.listViewBirthDate = new System.Windows.Forms.ListView();
            this.columnHeaderTckn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripExport = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBirthDate
            // 
            this.listViewBirthDate.BackColor = System.Drawing.Color.Silver;
            this.listViewBirthDate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderTckn,
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderPhone,
            this.columnHeaderBirthDate});
            this.listViewBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBirthDate.HideSelection = false;
            this.listViewBirthDate.Location = new System.Drawing.Point(0, 28);
            this.listViewBirthDate.Name = "listViewBirthDate";
            this.listViewBirthDate.Size = new System.Drawing.Size(769, 371);
            this.listViewBirthDate.TabIndex = 0;
            this.listViewBirthDate.UseCompatibleStateImageBehavior = false;
            this.listViewBirthDate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTckn
            // 
            this.columnHeaderTckn.Text = "TC. No";
            this.columnHeaderTckn.Width = 110;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Adı";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Soyadı";
            this.columnHeaderSurname.Width = 150;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Telefon";
            this.columnHeaderPhone.Width = 125;
            // 
            // columnHeaderBirthDate
            // 
            this.columnHeaderBirthDate.Text = "Doğum Tarihi";
            this.columnHeaderBirthDate.Width = 130;
            // 
            // menuStripExport
            // 
            this.menuStripExport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStripExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.menuStripExport.Location = new System.Drawing.Point(0, 0);
            this.menuStripExport.Name = "menuStripExport";
            this.menuStripExport.Size = new System.Drawing.Size(769, 28);
            this.menuStripExport.TabIndex = 1;
            this.menuStripExport.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.exportToPdfToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.exportToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exportToExcelToolStripMenuItem.Text = "Excel\'e Aktar";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportToPdfToolStripMenuItem
            // 
            this.exportToPdfToolStripMenuItem.Name = "exportToPdfToolStripMenuItem";
            this.exportToPdfToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exportToPdfToolStripMenuItem.Text = "Pdf\'e Aktar";
            this.exportToPdfToolStripMenuItem.Click += new System.EventHandler(this.exportToPdfToolStripMenuItem_Click);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 100;
            // 
            // FormBirthDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(769, 399);
            this.Controls.Add(this.listViewBirthDate);
            this.Controls.Add(this.menuStripExport);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripExport;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormBirthDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doğum Günleri";
            this.Load += new System.EventHandler(this.FormBirthDates_Load);
            this.menuStripExport.ResumeLayout(false);
            this.menuStripExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBirthDate;
        private System.Windows.Forms.ColumnHeader columnHeaderTckn;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
        private System.Windows.Forms.MenuStrip menuStripExport;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPdfToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
    }
}