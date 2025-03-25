namespace BIGADIC_COURSE
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            groupBoxPersonel = new GroupBox();
            groupBoxList = new GroupBox();
            listViewPersonels = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            columnHeaderBranch = new ColumnHeader();
            columnHeaderRegisterDate = new ColumnHeader();
            groupBoxRegister = new GroupBox();
            labelBranch = new Label();
            comboBoxBranch = new ComboBox();
            textBoxId = new TextBox();
            buttonOrder = new Button();
            labelName = new Label();
            buttonClear = new Button();
            labelSurname = new Label();
            buttonDelete = new Button();
            labelPhone = new Label();
            buttonUpdate = new Button();
            labelPersonelType = new Label();
            buttonSearch = new Button();
            labelId = new Label();
            buttonRegister = new Button();
            textBoxName = new TextBox();
            comboBoxPersonelType = new ComboBox();
            textBoxSurname = new TextBox();
            maskedTextBoxPhone = new MaskedTextBox();
            menuStrip1 = new MenuStrip();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportToExcelToolStripMenuItem = new ToolStripMenuItem();
            exportToPdfToolStripMenuItem = new ToolStripMenuItem();
            groupBoxPersonel.SuspendLayout();
            groupBoxList.SuspendLayout();
            groupBoxRegister.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPersonel
            // 
            groupBoxPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPersonel.Controls.Add(groupBoxList);
            groupBoxPersonel.Controls.Add(groupBoxRegister);
            groupBoxPersonel.Location = new Point(17, 39);
            groupBoxPersonel.Margin = new Padding(4);
            groupBoxPersonel.Name = "groupBoxPersonel";
            groupBoxPersonel.Padding = new Padding(4);
            groupBoxPersonel.Size = new Size(718, 551);
            groupBoxPersonel.TabIndex = 0;
            groupBoxPersonel.TabStop = false;
            groupBoxPersonel.Text = "Personel";
            // 
            // groupBoxList
            // 
            groupBoxList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxList.Controls.Add(listViewPersonels);
            groupBoxList.Location = new Point(8, 255);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Size = new Size(702, 289);
            groupBoxList.TabIndex = 21;
            groupBoxList.TabStop = false;
            groupBoxList.Text = "Liste";
            // 
            // listViewPersonels
            // 
            listViewPersonels.BackColor = SystemColors.ControlDark;
            listViewPersonels.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderName, columnHeaderSurname, columnHeaderPhone, columnHeaderType, columnHeaderBranch, columnHeaderRegisterDate });
            listViewPersonels.Dock = DockStyle.Fill;
            listViewPersonels.FullRowSelect = true;
            listViewPersonels.Location = new Point(3, 23);
            listViewPersonels.Name = "listViewPersonels";
            listViewPersonels.Size = new Size(696, 263);
            listViewPersonels.TabIndex = 0;
            listViewPersonels.UseCompatibleStateImageBehavior = false;
            listViewPersonels.View = View.Details;
            listViewPersonels.Click += listViewPersonels_Click;
            listViewPersonels.KeyDown += listViewPersonels_Key;
            listViewPersonels.KeyUp += listViewPersonels_Key;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Adı";
            columnHeaderName.Width = 110;
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Soyadı";
            columnHeaderSurname.Width = 110;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Telefon";
            columnHeaderPhone.Width = 100;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Tipi";
            columnHeaderType.Width = 90;
            // 
            // columnHeaderBranch
            // 
            columnHeaderBranch.Text = "Branş";
            columnHeaderBranch.Width = 120;
            // 
            // columnHeaderRegisterDate
            // 
            columnHeaderRegisterDate.Text = "Kayıt Tarihi";
            columnHeaderRegisterDate.Width = 100;
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRegister.Controls.Add(labelBranch);
            groupBoxRegister.Controls.Add(comboBoxBranch);
            groupBoxRegister.Controls.Add(textBoxId);
            groupBoxRegister.Controls.Add(buttonOrder);
            groupBoxRegister.Controls.Add(labelName);
            groupBoxRegister.Controls.Add(buttonClear);
            groupBoxRegister.Controls.Add(labelSurname);
            groupBoxRegister.Controls.Add(buttonDelete);
            groupBoxRegister.Controls.Add(labelPhone);
            groupBoxRegister.Controls.Add(buttonUpdate);
            groupBoxRegister.Controls.Add(labelPersonelType);
            groupBoxRegister.Controls.Add(buttonSearch);
            groupBoxRegister.Controls.Add(labelId);
            groupBoxRegister.Controls.Add(buttonRegister);
            groupBoxRegister.Controls.Add(textBoxName);
            groupBoxRegister.Controls.Add(comboBoxPersonelType);
            groupBoxRegister.Controls.Add(textBoxSurname);
            groupBoxRegister.Controls.Add(maskedTextBoxPhone);
            groupBoxRegister.Location = new Point(7, 20);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(703, 232);
            groupBoxRegister.TabIndex = 20;
            groupBoxRegister.TabStop = false;
            groupBoxRegister.Text = "Kayıt";
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(13, 197);
            labelBranch.Margin = new Padding(4, 0, 4, 0);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(51, 20);
            labelBranch.TabIndex = 20;
            labelBranch.Text = "Branş:";
            // 
            // comboBoxBranch
            // 
            comboBoxBranch.Enabled = false;
            comboBoxBranch.Font = new Font("Segoe UI Semibold", 11.25F);
            comboBoxBranch.FormattingEnabled = true;
            comboBoxBranch.Location = new Point(126, 195);
            comboBoxBranch.Name = "comboBoxBranch";
            comboBoxBranch.Size = new Size(157, 28);
            comboBoxBranch.TabIndex = 21;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Segoe UI Semibold", 11.25F);
            textBoxId.Location = new Point(126, 24);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 27);
            textBoxId.TabIndex = 5;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.Silver;
            buttonOrder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonOrder.Location = new Point(510, 81);
            buttonOrder.Margin = new Padding(3, 2, 3, 2);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(149, 41);
            buttonOrder.TabIndex = 18;
            buttonOrder.Text = "Listele";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 61);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Adı:";
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Silver;
            buttonClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonClear.ForeColor = Color.Black;
            buttonClear.Location = new Point(510, 129);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(149, 41);
            buttonClear.TabIndex = 19;
            buttonClear.Text = "Temizleme";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(13, 95);
            labelSurname.Margin = new Padding(4, 0, 4, 0);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(59, 20);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Soyadı:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Silver;
            buttonDelete.Enabled = false;
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(327, 129);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(149, 41);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(13, 129);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 20);
            labelPhone.TabIndex = 2;
            labelPhone.Text = "Telefon:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Silver;
            buttonUpdate.Enabled = false;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(327, 81);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(149, 41);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelPersonelType
            // 
            labelPersonelType.AutoSize = true;
            labelPersonelType.Location = new Point(13, 163);
            labelPersonelType.Margin = new Padding(4, 0, 4, 0);
            labelPersonelType.Name = "labelPersonelType";
            labelPersonelType.Size = new Size(100, 20);
            labelPersonelType.TabIndex = 3;
            labelPersonelType.Text = "Personel Tipi:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Silver;
            buttonSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(510, 33);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(149, 41);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Bul";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(13, 27);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(26, 20);
            labelId.TabIndex = 4;
            labelId.Text = "Id:";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Silver;
            buttonRegister.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.Black;
            buttonRegister.Location = new Point(327, 33);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(149, 41);
            buttonRegister.TabIndex = 14;
            buttonRegister.Text = "Kaydet";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI Semibold", 11.25F);
            textBoxName.Location = new Point(126, 58);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(157, 27);
            textBoxName.TabIndex = 6;
            textBoxName.Enter += textBox_Enter;
            textBoxName.KeyDown += textBox_KeyDown;
            textBoxName.Leave += textBox_Leave;
            // 
            // comboBoxPersonelType
            // 
            comboBoxPersonelType.Font = new Font("Segoe UI Semibold", 11.25F);
            comboBoxPersonelType.FormattingEnabled = true;
            comboBoxPersonelType.Items.AddRange(new object[] { "Seçiniz", "Personel", "Antrenör", "Öğretmen" });
            comboBoxPersonelType.Location = new Point(126, 160);
            comboBoxPersonelType.Name = "comboBoxPersonelType";
            comboBoxPersonelType.Size = new Size(157, 28);
            comboBoxPersonelType.TabIndex = 9;
            comboBoxPersonelType.SelectedIndexChanged += comboBoxPersonelType_SelectedIndexChanged;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI Semibold", 11.25F);
            textBoxSurname.Location = new Point(126, 92);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(157, 27);
            textBoxSurname.TabIndex = 7;
            textBoxSurname.Enter += textBox_Enter;
            textBoxSurname.KeyDown += textBox_KeyDown;
            textBoxSurname.Leave += textBox_Leave;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.BackColor = Color.White;
            maskedTextBoxPhone.Font = new Font("Segoe UI Semibold", 11.25F);
            maskedTextBoxPhone.ForeColor = Color.Black;
            maskedTextBoxPhone.Location = new Point(126, 126);
            maskedTextBoxPhone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPhone.Mask = "0000000000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.PromptChar = ' ';
            maskedTextBoxPhone.Size = new Size(157, 27);
            maskedTextBoxPhone.TabIndex = 8;
            maskedTextBoxPhone.Click += maskedTextBoxPhone_Click;
            maskedTextBoxPhone.Enter += textBox_Enter;
            maskedTextBoxPhone.KeyDown += textBox_KeyDown;
            maskedTextBoxPhone.Leave += textBox_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(751, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            // FormPersonel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(751, 606);
            Controls.Add(groupBoxPersonel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "FormPersonel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel";
            Load += FormPersonel_Load;
            groupBoxPersonel.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPersonelType;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox comboBoxPersonelType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxRegister;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ListView listViewPersonels;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderRegisterDate;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.ColumnHeader columnHeaderBranch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportToExcelToolStripMenuItem;
        private ToolStripMenuItem exportToPdfToolStripMenuItem;
    }
}