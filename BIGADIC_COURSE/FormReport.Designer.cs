namespace BIGADIC_COURSE
{
    partial class FormReport
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            groupBoxLists = new GroupBox();
            groupBoxList = new GroupBox();
            listViewAllRegister = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderTCKN = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderBranch = new ColumnHeader();
            columnHeaderBirthDate = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            columnHeaderRegisterDate = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportToExcelToolStripMenuItem = new ToolStripMenuItem();
            exportToPdfToolStripMenuItem = new ToolStripMenuItem();
            graphicToolStripMenuItem = new ToolStripMenuItem();
            groupBoxTotal = new GroupBox();
            textBoxMale = new TextBox();
            textBoxFemale = new TextBox();
            textBoxWaitingRegisters = new TextBox();
            textBoxPassiveRegisters = new TextBox();
            textBoxActiveRegisters = new TextBox();
            textBoxTotalRegister = new TextBox();
            labelMale = new Label();
            labelFemale = new Label();
            labelWaitingRegisters = new Label();
            labelPassiveRegisters = new Label();
            labelActiveRegisters = new Label();
            labelTotalRegisters = new Label();
            groupBoxBranches = new GroupBox();
            flowLayoutPanelBranches = new FlowLayoutPanel();
            groupBoxFilters = new GroupBox();
            groupBoxButtons = new GroupBox();
            buttonClearAllFilter = new Button();
            groupBoxReport = new GroupBox();
            comboBoxFilters = new ComboBox();
            label1 = new Label();
            groupBoxDate = new GroupBox();
            checkBoxSelectDate = new CheckBox();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            labelStartDate = new Label();
            labelEndDate = new Label();
            imageList = new ImageList(components);
            groupBoxLists.SuspendLayout();
            groupBoxList.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBoxTotal.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            groupBoxReport.SuspendLayout();
            groupBoxDate.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLists
            // 
            groupBoxLists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxLists.Controls.Add(groupBoxList);
            groupBoxLists.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBoxLists.Location = new Point(12, 393);
            groupBoxLists.Margin = new Padding(3, 2, 3, 2);
            groupBoxLists.Name = "groupBoxLists";
            groupBoxLists.Padding = new Padding(3, 2, 3, 2);
            groupBoxLists.Size = new Size(1139, 317);
            groupBoxLists.TabIndex = 6;
            groupBoxLists.TabStop = false;
            groupBoxLists.Text = "Listeler";
            // 
            // groupBoxList
            // 
            groupBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxList.BackColor = SystemColors.ControlDark;
            groupBoxList.Controls.Add(listViewAllRegister);
            groupBoxList.Location = new Point(6, 14);
            groupBoxList.Margin = new Padding(3, 2, 3, 2);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Padding = new Padding(3, 2, 3, 2);
            groupBoxList.Size = new Size(1128, 298);
            groupBoxList.TabIndex = 0;
            groupBoxList.TabStop = false;
            // 
            // listViewAllRegister
            // 
            listViewAllRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewAllRegister.BackColor = SystemColors.ControlDark;
            listViewAllRegister.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderTCKN, columnHeaderName, columnHeaderSurname, columnHeaderBranch, columnHeaderBirthDate, columnHeaderPhone, columnHeaderRegisterDate, columnHeaderStatus });
            listViewAllRegister.FullRowSelect = true;
            listViewAllRegister.Location = new Point(3, 20);
            listViewAllRegister.Margin = new Padding(3, 2, 3, 2);
            listViewAllRegister.Name = "listViewAllRegister";
            listViewAllRegister.Size = new Size(1122, 276);
            listViewAllRegister.TabIndex = 0;
            listViewAllRegister.UseCompatibleStateImageBehavior = false;
            listViewAllRegister.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 100;
            // 
            // columnHeaderTCKN
            // 
            columnHeaderTCKN.Text = "T.C. No";
            columnHeaderTCKN.Width = 120;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Adı";
            columnHeaderName.Width = 175;
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Soyadı";
            columnHeaderSurname.Width = 175;
            // 
            // columnHeaderBranch
            // 
            columnHeaderBranch.Text = "Branş";
            columnHeaderBranch.Width = 120;
            // 
            // columnHeaderBirthDate
            // 
            columnHeaderBirthDate.Text = "Doğum Tarihi";
            columnHeaderBirthDate.Width = 120;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Telefon";
            columnHeaderPhone.Width = 100;
            // 
            // columnHeaderRegisterDate
            // 
            columnHeaderRegisterDate.Text = "Kayıt Tarihi";
            columnHeaderRegisterDate.Width = 130;
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Durumu";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exportToolStripMenuItem, graphicToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1163, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToExcelToolStripMenuItem, exportToPdfToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(103, 24);
            exportToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // exportToExcelToolStripMenuItem
            // 
            exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            exportToExcelToolStripMenuItem.Size = new Size(167, 24);
            exportToExcelToolStripMenuItem.Text = "Excel'e Aktar";
            exportToExcelToolStripMenuItem.Click += exportToExcelToolStripMenuItem_Click;
            // 
            // exportToPdfToolStripMenuItem
            // 
            exportToPdfToolStripMenuItem.Name = "exportToPdfToolStripMenuItem";
            exportToPdfToolStripMenuItem.Size = new Size(167, 24);
            exportToPdfToolStripMenuItem.Text = "Pdf'e Aktar";
            exportToPdfToolStripMenuItem.Click += exportToPdfToolStripMenuItem_Click;
            // 
            // graphicToolStripMenuItem
            // 
            graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            graphicToolStripMenuItem.Size = new Size(63, 24);
            graphicToolStripMenuItem.Text = "Grafik";
            graphicToolStripMenuItem.Click += graphicToolStripMenuItem_Click;
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(textBoxMale);
            groupBoxTotal.Controls.Add(textBoxFemale);
            groupBoxTotal.Controls.Add(textBoxWaitingRegisters);
            groupBoxTotal.Controls.Add(textBoxPassiveRegisters);
            groupBoxTotal.Controls.Add(textBoxActiveRegisters);
            groupBoxTotal.Controls.Add(textBoxTotalRegister);
            groupBoxTotal.Controls.Add(labelMale);
            groupBoxTotal.Controls.Add(labelFemale);
            groupBoxTotal.Controls.Add(labelWaitingRegisters);
            groupBoxTotal.Controls.Add(labelPassiveRegisters);
            groupBoxTotal.Controls.Add(labelActiveRegisters);
            groupBoxTotal.Controls.Add(labelTotalRegisters);
            groupBoxTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBoxTotal.ForeColor = Color.Black;
            groupBoxTotal.Location = new Point(12, 39);
            groupBoxTotal.Margin = new Padding(3, 2, 3, 2);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Padding = new Padding(3, 2, 3, 2);
            groupBoxTotal.Size = new Size(193, 349);
            groupBoxTotal.TabIndex = 8;
            groupBoxTotal.TabStop = false;
            groupBoxTotal.Text = "Toplamlar...";
            // 
            // textBoxMale
            // 
            textBoxMale.Enabled = false;
            textBoxMale.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxMale.ForeColor = Color.Black;
            textBoxMale.Location = new Point(31, 290);
            textBoxMale.Margin = new Padding(3, 2, 3, 2);
            textBoxMale.Name = "textBoxMale";
            textBoxMale.Size = new Size(124, 25);
            textBoxMale.TabIndex = 11;
            // 
            // textBoxFemale
            // 
            textBoxFemale.Enabled = false;
            textBoxFemale.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxFemale.ForeColor = Color.Black;
            textBoxFemale.Location = new Point(31, 244);
            textBoxFemale.Margin = new Padding(3, 2, 3, 2);
            textBoxFemale.Name = "textBoxFemale";
            textBoxFemale.Size = new Size(124, 25);
            textBoxFemale.TabIndex = 10;
            // 
            // textBoxWaitingRegisters
            // 
            textBoxWaitingRegisters.Enabled = false;
            textBoxWaitingRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxWaitingRegisters.ForeColor = Color.Black;
            textBoxWaitingRegisters.Location = new Point(31, 198);
            textBoxWaitingRegisters.Margin = new Padding(3, 2, 3, 2);
            textBoxWaitingRegisters.Name = "textBoxWaitingRegisters";
            textBoxWaitingRegisters.Size = new Size(124, 25);
            textBoxWaitingRegisters.TabIndex = 9;
            // 
            // textBoxPassiveRegisters
            // 
            textBoxPassiveRegisters.Enabled = false;
            textBoxPassiveRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxPassiveRegisters.ForeColor = Color.Black;
            textBoxPassiveRegisters.Location = new Point(31, 152);
            textBoxPassiveRegisters.Margin = new Padding(3, 2, 3, 2);
            textBoxPassiveRegisters.Name = "textBoxPassiveRegisters";
            textBoxPassiveRegisters.Size = new Size(124, 25);
            textBoxPassiveRegisters.TabIndex = 8;
            // 
            // textBoxActiveRegisters
            // 
            textBoxActiveRegisters.Enabled = false;
            textBoxActiveRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxActiveRegisters.ForeColor = Color.Black;
            textBoxActiveRegisters.Location = new Point(31, 106);
            textBoxActiveRegisters.Margin = new Padding(3, 2, 3, 2);
            textBoxActiveRegisters.Name = "textBoxActiveRegisters";
            textBoxActiveRegisters.Size = new Size(124, 25);
            textBoxActiveRegisters.TabIndex = 7;
            // 
            // textBoxTotalRegister
            // 
            textBoxTotalRegister.Enabled = false;
            textBoxTotalRegister.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTotalRegister.ForeColor = Color.Black;
            textBoxTotalRegister.Location = new Point(31, 61);
            textBoxTotalRegister.Margin = new Padding(3, 2, 3, 2);
            textBoxTotalRegister.Name = "textBoxTotalRegister";
            textBoxTotalRegister.Size = new Size(124, 25);
            textBoxTotalRegister.TabIndex = 6;
            // 
            // labelMale
            // 
            labelMale.AutoSize = true;
            labelMale.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelMale.ForeColor = Color.Black;
            labelMale.Location = new Point(33, 270);
            labelMale.Name = "labelMale";
            labelMale.Size = new Size(48, 18);
            labelMale.TabIndex = 5;
            labelMale.Text = "Erkek";
            // 
            // labelFemale
            // 
            labelFemale.AutoSize = true;
            labelFemale.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelFemale.ForeColor = Color.Black;
            labelFemale.Location = new Point(33, 224);
            labelFemale.Name = "labelFemale";
            labelFemale.Size = new Size(48, 18);
            labelFemale.TabIndex = 4;
            labelFemale.Text = "Kadın";
            // 
            // labelWaitingRegisters
            // 
            labelWaitingRegisters.AutoSize = true;
            labelWaitingRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelWaitingRegisters.ForeColor = Color.Black;
            labelWaitingRegisters.Location = new Point(33, 178);
            labelWaitingRegisters.Name = "labelWaitingRegisters";
            labelWaitingRegisters.Size = new Size(80, 18);
            labelWaitingRegisters.TabIndex = 3;
            labelWaitingRegisters.Text = "Bekleyen ";
            // 
            // labelPassiveRegisters
            // 
            labelPassiveRegisters.AutoSize = true;
            labelPassiveRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPassiveRegisters.ForeColor = Color.Black;
            labelPassiveRegisters.Location = new Point(33, 132);
            labelPassiveRegisters.Name = "labelPassiveRegisters";
            labelPassiveRegisters.Size = new Size(48, 18);
            labelPassiveRegisters.TabIndex = 2;
            labelPassiveRegisters.Text = "Pasif";
            // 
            // labelActiveRegisters
            // 
            labelActiveRegisters.AutoSize = true;
            labelActiveRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelActiveRegisters.ForeColor = Color.Black;
            labelActiveRegisters.Location = new Point(33, 86);
            labelActiveRegisters.Name = "labelActiveRegisters";
            labelActiveRegisters.Size = new Size(56, 18);
            labelActiveRegisters.TabIndex = 1;
            labelActiveRegisters.Text = "Aktif ";
            // 
            // labelTotalRegisters
            // 
            labelTotalRegisters.AutoSize = true;
            labelTotalRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelTotalRegisters.ForeColor = Color.Black;
            labelTotalRegisters.Location = new Point(33, 41);
            labelTotalRegisters.Name = "labelTotalRegisters";
            labelTotalRegisters.Size = new Size(56, 18);
            labelTotalRegisters.TabIndex = 0;
            labelTotalRegisters.Text = "Toplam";
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Controls.Add(flowLayoutPanelBranches);
            groupBoxBranches.Font = new Font("Segoe UI", 11.25F);
            groupBoxBranches.Location = new Point(667, 39);
            groupBoxBranches.Margin = new Padding(3, 2, 3, 2);
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.Padding = new Padding(3, 2, 3, 2);
            groupBoxBranches.Size = new Size(484, 349);
            groupBoxBranches.TabIndex = 9;
            groupBoxBranches.TabStop = false;
            groupBoxBranches.Text = "Branş Seçimleri...";
            // 
            // flowLayoutPanelBranches
            // 
            flowLayoutPanelBranches.Dock = DockStyle.Fill;
            flowLayoutPanelBranches.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBranches.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            flowLayoutPanelBranches.Location = new Point(3, 22);
            flowLayoutPanelBranches.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            flowLayoutPanelBranches.Size = new Size(478, 325);
            flowLayoutPanelBranches.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(groupBoxButtons);
            groupBoxFilters.Controls.Add(groupBoxReport);
            groupBoxFilters.Controls.Add(groupBoxDate);
            groupBoxFilters.Font = new Font("Segoe UI", 11.25F);
            groupBoxFilters.Location = new Point(236, 39);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(400, 349);
            groupBoxFilters.TabIndex = 10;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Filtreler";
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonClearAllFilter);
            groupBoxButtons.Location = new Point(16, 255);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(368, 70);
            groupBoxButtons.TabIndex = 46;
            groupBoxButtons.TabStop = false;
            // 
            // buttonClearAllFilter
            // 
            buttonClearAllFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClearAllFilter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonClearAllFilter.Location = new Point(10, 25);
            buttonClearAllFilter.Name = "buttonClearAllFilter";
            buttonClearAllFilter.Size = new Size(347, 34);
            buttonClearAllFilter.TabIndex = 42;
            buttonClearAllFilter.Text = "Tüm Filtreleri Temizle";
            buttonClearAllFilter.UseVisualStyleBackColor = true;
            buttonClearAllFilter.Click += buttonClearAllFilter_Click;
            // 
            // groupBoxReport
            // 
            groupBoxReport.Controls.Add(comboBoxFilters);
            groupBoxReport.Controls.Add(label1);
            groupBoxReport.Location = new Point(16, 173);
            groupBoxReport.Name = "groupBoxReport";
            groupBoxReport.Size = new Size(368, 70);
            groupBoxReport.TabIndex = 45;
            groupBoxReport.TabStop = false;
            groupBoxReport.Text = "Rapor Seçimi:";
            // 
            // comboBoxFilters
            // 
            comboBoxFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxFilters.FormattingEnabled = true;
            comboBoxFilters.Items.AddRange(new object[] { "Toplam_Listele", "Aktif_Listele", "Bekleyen_Listele", "Pasif_Listele", "Kadın_Kayıtlar_Listele_Toplam", "Kadın_Kayıtlar_Listele_Aktif", "Kadın_Kayıtlar_Listele_Bekleyen", "Kadın_Kayıtlar_Listele_Pasif", "Erkek_Kayıtlar_Listele_Toplam", "Erkek_Kayıtlar_Listele_Aktif", "Erkek_Kayıtlar_Listele_Bekleyen", "Erkek_Kayıtlar_Listele_Pasif", "Branşlara_Göre_Toplam", "Branşlara_Göre_Aktif", "Branşlara_Göre_Bekleyen", "Branşlara_Göre_Pasif", "Haftalık_Rapor", "Günsonu_Rapor", "Aysonu_Rapor", "Yılsonu_Rapor", "Anlık_Rapor" });
            comboBoxFilters.Location = new Point(117, 26);
            comboBoxFilters.Name = "comboBoxFilters";
            comboBoxFilters.Size = new Size(240, 28);
            comboBoxFilters.TabIndex = 38;
            comboBoxFilters.SelectedIndexChanged += comboBoxFilters_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 43;
            label1.Text = "Rapor Seçiniz:";
            // 
            // groupBoxDate
            // 
            groupBoxDate.Controls.Add(checkBoxSelectDate);
            groupBoxDate.Controls.Add(dateTimePickerStartDate);
            groupBoxDate.Controls.Add(dateTimePickerEndDate);
            groupBoxDate.Controls.Add(labelStartDate);
            groupBoxDate.Controls.Add(labelEndDate);
            groupBoxDate.Location = new Point(16, 31);
            groupBoxDate.Name = "groupBoxDate";
            groupBoxDate.Size = new Size(368, 130);
            groupBoxDate.TabIndex = 44;
            groupBoxDate.TabStop = false;
            groupBoxDate.Text = "Tarih:";
            // 
            // checkBoxSelectDate
            // 
            checkBoxSelectDate.AutoSize = true;
            checkBoxSelectDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            checkBoxSelectDate.Location = new Point(6, 26);
            checkBoxSelectDate.Name = "checkBoxSelectDate";
            checkBoxSelectDate.Size = new Size(89, 24);
            checkBoxSelectDate.TabIndex = 35;
            checkBoxSelectDate.Text = "Tarih Seç";
            checkBoxSelectDate.UseVisualStyleBackColor = true;
            checkBoxSelectDate.CheckedChanged += checkBoxSelectDate_CheckedChanged;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(167, 50);
            dateTimePickerStartDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(118, 27);
            dateTimePickerStartDate.TabIndex = 36;
            dateTimePickerStartDate.Value = new DateTime(2025, 2, 15, 0, 0, 0, 0);
            dateTimePickerStartDate.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(167, 81);
            dateTimePickerEndDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(118, 27);
            dateTimePickerEndDate.TabIndex = 37;
            dateTimePickerEndDate.Value = new DateTime(2025, 2, 15, 0, 0, 0, 0);
            dateTimePickerEndDate.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelStartDate.Location = new Point(6, 57);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(123, 20);
            labelStartDate.TabIndex = 39;
            labelStartDate.Text = "Başlangıç Tarihi:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelEndDate.Location = new Point(6, 88);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(85, 20);
            labelEndDate.TabIndex = 40;
            labelEndDate.Text = "Bitiş Tarihi:";
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "LOGO.png");
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1163, 721);
            Controls.Add(groupBoxFilters);
            Controls.Add(groupBoxBranches);
            Controls.Add(groupBoxTotal);
            Controls.Add(groupBoxLists);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 11.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rapor";
            Load += FormReport_Load;
            groupBoxLists.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            groupBoxBranches.ResumeLayout(false);
            groupBoxFilters.ResumeLayout(false);
            groupBoxButtons.ResumeLayout(false);
            groupBoxReport.ResumeLayout(false);
            groupBoxReport.PerformLayout();
            groupBoxDate.ResumeLayout(false);
            groupBoxDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLists;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.ListView listViewAllRegister;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderTCKN;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderBranch;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderRegisterDate;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.TextBox textBoxMale;
        private System.Windows.Forms.TextBox textBoxFemale;
        private System.Windows.Forms.TextBox textBoxWaitingRegisters;
        private System.Windows.Forms.TextBox textBoxPassiveRegisters;
        private System.Windows.Forms.TextBox textBoxActiveRegisters;
        private System.Windows.Forms.TextBox textBoxTotalRegister;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label labelWaitingRegisters;
        private System.Windows.Forms.Label labelPassiveRegisters;
        private System.Windows.Forms.Label labelActiveRegisters;
        private System.Windows.Forms.Label labelTotalRegisters;
        private System.Windows.Forms.GroupBox groupBoxBranches;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBranches;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.CheckBox checkBoxSelectDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Button buttonClearAllFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.ImageList imageList;
    }
}