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
            listViewBirthDate = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderTckn = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            columnHeaderBirthDate = new ColumnHeader();
            menuStripExport = new MenuStrip();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportToExcelToolStripMenuItem = new ToolStripMenuItem();
            exportToPdfToolStripMenuItem = new ToolStripMenuItem();
            menuStripExport.SuspendLayout();
            SuspendLayout();
            // 
            // listViewBirthDate
            // 
            listViewBirthDate.BackColor = Color.Silver;
            listViewBirthDate.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderTckn, columnHeaderName, columnHeaderSurname, columnHeaderPhone, columnHeaderBirthDate });
            listViewBirthDate.Dock = DockStyle.Fill;
            listViewBirthDate.Location = new Point(0, 28);
            listViewBirthDate.Name = "listViewBirthDate";
            listViewBirthDate.Size = new Size(769, 371);
            listViewBirthDate.TabIndex = 0;
            listViewBirthDate.UseCompatibleStateImageBehavior = false;
            listViewBirthDate.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 100;
            // 
            // columnHeaderTckn
            // 
            columnHeaderTckn.Text = "TC. No";
            columnHeaderTckn.Width = 110;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Adı";
            columnHeaderName.Width = 150;
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Soyadı";
            columnHeaderSurname.Width = 150;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Telefon";
            columnHeaderPhone.Width = 125;
            // 
            // columnHeaderBirthDate
            // 
            columnHeaderBirthDate.Text = "Doğum Tarihi";
            columnHeaderBirthDate.Width = 130;
            // 
            // menuStripExport
            // 
            menuStripExport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStripExport.Items.AddRange(new ToolStripItem[] { exportToolStripMenuItem });
            menuStripExport.Location = new Point(0, 0);
            menuStripExport.Name = "menuStripExport";
            menuStripExport.Size = new Size(769, 28);
            menuStripExport.TabIndex = 1;
            menuStripExport.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToExcelToolStripMenuItem, exportToPdfToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(101, 24);
            exportToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // exportToExcelToolStripMenuItem
            // 
            exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            exportToExcelToolStripMenuItem.Size = new Size(166, 24);
            exportToExcelToolStripMenuItem.Text = "Excel'e Aktar";
            exportToExcelToolStripMenuItem.Click += exportToExcelToolStripMenuItem_Click;
            // 
            // exportToPdfToolStripMenuItem
            // 
            exportToPdfToolStripMenuItem.Name = "exportToPdfToolStripMenuItem";
            exportToPdfToolStripMenuItem.Size = new Size(166, 24);
            exportToPdfToolStripMenuItem.Text = "Pdf'e Aktar";
            exportToPdfToolStripMenuItem.Click += exportToPdfToolStripMenuItem_Click;
            // 
            // FormBirthDates
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(769, 399);
            Controls.Add(listViewBirthDate);
            Controls.Add(menuStripExport);
            Font = new Font("Segoe UI Semibold", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripExport;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormBirthDates";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Doğum Günleri";
            Load += FormBirthDates_Load;
            menuStripExport.ResumeLayout(false);
            menuStripExport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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