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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.groupBoxLists = new System.Windows.Forms.GroupBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.listViewAllRegister = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTCKN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegisterDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.textBoxMale = new System.Windows.Forms.TextBox();
            this.textBoxFemale = new System.Windows.Forms.TextBox();
            this.textBoxWaitingRegisters = new System.Windows.Forms.TextBox();
            this.textBoxPassiveRegisters = new System.Windows.Forms.TextBox();
            this.textBoxActiveRegisters = new System.Windows.Forms.TextBox();
            this.textBoxTotalRegister = new System.Windows.Forms.TextBox();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.labelWaitingRegisters = new System.Windows.Forms.Label();
            this.labelPassiveRegisters = new System.Windows.Forms.Label();
            this.labelActiveRegisters = new System.Windows.Forms.Label();
            this.labelTotalRegisters = new System.Windows.Forms.Label();
            this.groupBoxBranches = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelBranches = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.buttonClearAllFilter = new System.Windows.Forms.Button();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxLists.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            this.groupBoxBranches.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLists
            // 
            this.groupBoxLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLists.Controls.Add(this.groupBoxList);
            this.groupBoxLists.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxLists.Location = new System.Drawing.Point(12, 393);
            this.groupBoxLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLists.Name = "groupBoxLists";
            this.groupBoxLists.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLists.Size = new System.Drawing.Size(1139, 317);
            this.groupBoxLists.TabIndex = 6;
            this.groupBoxLists.TabStop = false;
            this.groupBoxLists.Text = "Listeler";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxList.Controls.Add(this.listViewAllRegister);
            this.groupBoxList.Location = new System.Drawing.Point(6, 14);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxList.Size = new System.Drawing.Size(1128, 298);
            this.groupBoxList.TabIndex = 0;
            this.groupBoxList.TabStop = false;
            // 
            // listViewAllRegister
            // 
            this.listViewAllRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAllRegister.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewAllRegister.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderTCKN,
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderBranch,
            this.columnHeaderBirthDate,
            this.columnHeaderPhone,
            this.columnHeaderRegisterDate,
            this.columnHeaderStatus});
            this.listViewAllRegister.FullRowSelect = true;
            this.listViewAllRegister.HideSelection = false;
            this.listViewAllRegister.Location = new System.Drawing.Point(3, 20);
            this.listViewAllRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewAllRegister.Name = "listViewAllRegister";
            this.listViewAllRegister.Size = new System.Drawing.Size(1122, 276);
            this.listViewAllRegister.TabIndex = 0;
            this.listViewAllRegister.UseCompatibleStateImageBehavior = false;
            this.listViewAllRegister.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 100;
            // 
            // columnHeaderTCKN
            // 
            this.columnHeaderTCKN.Text = "T.C. No";
            this.columnHeaderTCKN.Width = 120;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Adı";
            this.columnHeaderName.Width = 175;
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Soyadı";
            this.columnHeaderSurname.Width = 175;
            // 
            // columnHeaderBranch
            // 
            this.columnHeaderBranch.Text = "Branş";
            this.columnHeaderBranch.Width = 120;
            // 
            // columnHeaderBirthDate
            // 
            this.columnHeaderBirthDate.Text = "Doğum Tarihi";
            this.columnHeaderBirthDate.Width = 120;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Telefon";
            this.columnHeaderPhone.Width = 100;
            // 
            // columnHeaderRegisterDate
            // 
            this.columnHeaderRegisterDate.Text = "Kayıt Tarihi";
            this.columnHeaderRegisterDate.Width = 130;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Durumu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.graphicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.exportToPdfToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.exportToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exportToExcelToolStripMenuItem.Text = "Excel\'e Aktar";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportToPdfToolStripMenuItem
            // 
            this.exportToPdfToolStripMenuItem.Name = "exportToPdfToolStripMenuItem";
            this.exportToPdfToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exportToPdfToolStripMenuItem.Text = "Pdf\'e Aktar";
            this.exportToPdfToolStripMenuItem.Click += new System.EventHandler(this.exportToPdfToolStripMenuItem_Click);
            // 
            // graphicToolStripMenuItem
            // 
            this.graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            this.graphicToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.graphicToolStripMenuItem.Text = "Grafik";
            this.graphicToolStripMenuItem.Click += new System.EventHandler(this.graphicToolStripMenuItem_Click);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.textBoxMale);
            this.groupBoxTotal.Controls.Add(this.textBoxFemale);
            this.groupBoxTotal.Controls.Add(this.textBoxWaitingRegisters);
            this.groupBoxTotal.Controls.Add(this.textBoxPassiveRegisters);
            this.groupBoxTotal.Controls.Add(this.textBoxActiveRegisters);
            this.groupBoxTotal.Controls.Add(this.textBoxTotalRegister);
            this.groupBoxTotal.Controls.Add(this.labelMale);
            this.groupBoxTotal.Controls.Add(this.labelFemale);
            this.groupBoxTotal.Controls.Add(this.labelWaitingRegisters);
            this.groupBoxTotal.Controls.Add(this.labelPassiveRegisters);
            this.groupBoxTotal.Controls.Add(this.labelActiveRegisters);
            this.groupBoxTotal.Controls.Add(this.labelTotalRegisters);
            this.groupBoxTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxTotal.ForeColor = System.Drawing.Color.Black;
            this.groupBoxTotal.Location = new System.Drawing.Point(12, 39);
            this.groupBoxTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTotal.Size = new System.Drawing.Size(193, 349);
            this.groupBoxTotal.TabIndex = 8;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "Toplamlar...";
            // 
            // textBoxMale
            // 
            this.textBoxMale.Enabled = false;
            this.textBoxMale.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMale.ForeColor = System.Drawing.Color.Black;
            this.textBoxMale.Location = new System.Drawing.Point(31, 290);
            this.textBoxMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMale.Name = "textBoxMale";
            this.textBoxMale.Size = new System.Drawing.Size(124, 25);
            this.textBoxMale.TabIndex = 11;
            // 
            // textBoxFemale
            // 
            this.textBoxFemale.Enabled = false;
            this.textBoxFemale.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFemale.ForeColor = System.Drawing.Color.Black;
            this.textBoxFemale.Location = new System.Drawing.Point(31, 244);
            this.textBoxFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFemale.Name = "textBoxFemale";
            this.textBoxFemale.Size = new System.Drawing.Size(124, 25);
            this.textBoxFemale.TabIndex = 10;
            // 
            // textBoxWaitingRegisters
            // 
            this.textBoxWaitingRegisters.Enabled = false;
            this.textBoxWaitingRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxWaitingRegisters.ForeColor = System.Drawing.Color.Black;
            this.textBoxWaitingRegisters.Location = new System.Drawing.Point(31, 198);
            this.textBoxWaitingRegisters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWaitingRegisters.Name = "textBoxWaitingRegisters";
            this.textBoxWaitingRegisters.Size = new System.Drawing.Size(124, 25);
            this.textBoxWaitingRegisters.TabIndex = 9;
            // 
            // textBoxPassiveRegisters
            // 
            this.textBoxPassiveRegisters.Enabled = false;
            this.textBoxPassiveRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPassiveRegisters.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassiveRegisters.Location = new System.Drawing.Point(31, 152);
            this.textBoxPassiveRegisters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassiveRegisters.Name = "textBoxPassiveRegisters";
            this.textBoxPassiveRegisters.Size = new System.Drawing.Size(124, 25);
            this.textBoxPassiveRegisters.TabIndex = 8;
            // 
            // textBoxActiveRegisters
            // 
            this.textBoxActiveRegisters.Enabled = false;
            this.textBoxActiveRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxActiveRegisters.ForeColor = System.Drawing.Color.Black;
            this.textBoxActiveRegisters.Location = new System.Drawing.Point(31, 106);
            this.textBoxActiveRegisters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxActiveRegisters.Name = "textBoxActiveRegisters";
            this.textBoxActiveRegisters.Size = new System.Drawing.Size(124, 25);
            this.textBoxActiveRegisters.TabIndex = 7;
            // 
            // textBoxTotalRegister
            // 
            this.textBoxTotalRegister.Enabled = false;
            this.textBoxTotalRegister.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTotalRegister.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalRegister.Location = new System.Drawing.Point(31, 61);
            this.textBoxTotalRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTotalRegister.Name = "textBoxTotalRegister";
            this.textBoxTotalRegister.Size = new System.Drawing.Size(124, 25);
            this.textBoxTotalRegister.TabIndex = 6;
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMale.ForeColor = System.Drawing.Color.Black;
            this.labelMale.Location = new System.Drawing.Point(33, 270);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(48, 18);
            this.labelMale.TabIndex = 5;
            this.labelMale.Text = "Erkek";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFemale.ForeColor = System.Drawing.Color.Black;
            this.labelFemale.Location = new System.Drawing.Point(33, 224);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(48, 18);
            this.labelFemale.TabIndex = 4;
            this.labelFemale.Text = "Kadın";
            // 
            // labelWaitingRegisters
            // 
            this.labelWaitingRegisters.AutoSize = true;
            this.labelWaitingRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWaitingRegisters.ForeColor = System.Drawing.Color.Black;
            this.labelWaitingRegisters.Location = new System.Drawing.Point(33, 178);
            this.labelWaitingRegisters.Name = "labelWaitingRegisters";
            this.labelWaitingRegisters.Size = new System.Drawing.Size(80, 18);
            this.labelWaitingRegisters.TabIndex = 3;
            this.labelWaitingRegisters.Text = "Bekleyen ";
            // 
            // labelPassiveRegisters
            // 
            this.labelPassiveRegisters.AutoSize = true;
            this.labelPassiveRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassiveRegisters.ForeColor = System.Drawing.Color.Black;
            this.labelPassiveRegisters.Location = new System.Drawing.Point(33, 132);
            this.labelPassiveRegisters.Name = "labelPassiveRegisters";
            this.labelPassiveRegisters.Size = new System.Drawing.Size(48, 18);
            this.labelPassiveRegisters.TabIndex = 2;
            this.labelPassiveRegisters.Text = "Pasif";
            // 
            // labelActiveRegisters
            // 
            this.labelActiveRegisters.AutoSize = true;
            this.labelActiveRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveRegisters.ForeColor = System.Drawing.Color.Black;
            this.labelActiveRegisters.Location = new System.Drawing.Point(33, 86);
            this.labelActiveRegisters.Name = "labelActiveRegisters";
            this.labelActiveRegisters.Size = new System.Drawing.Size(56, 18);
            this.labelActiveRegisters.TabIndex = 1;
            this.labelActiveRegisters.Text = "Aktif ";
            // 
            // labelTotalRegisters
            // 
            this.labelTotalRegisters.AutoSize = true;
            this.labelTotalRegisters.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalRegisters.ForeColor = System.Drawing.Color.Black;
            this.labelTotalRegisters.Location = new System.Drawing.Point(33, 41);
            this.labelTotalRegisters.Name = "labelTotalRegisters";
            this.labelTotalRegisters.Size = new System.Drawing.Size(56, 18);
            this.labelTotalRegisters.TabIndex = 0;
            this.labelTotalRegisters.Text = "Toplam";
            // 
            // groupBoxBranches
            // 
            this.groupBoxBranches.Controls.Add(this.flowLayoutPanelBranches);
            this.groupBoxBranches.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxBranches.Location = new System.Drawing.Point(667, 39);
            this.groupBoxBranches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBranches.Name = "groupBoxBranches";
            this.groupBoxBranches.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBranches.Size = new System.Drawing.Size(484, 349);
            this.groupBoxBranches.TabIndex = 9;
            this.groupBoxBranches.TabStop = false;
            this.groupBoxBranches.Text = "Branş Seçimleri...";
            // 
            // flowLayoutPanelBranches
            // 
            this.flowLayoutPanelBranches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBranches.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBranches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowLayoutPanelBranches.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanelBranches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            this.flowLayoutPanelBranches.Size = new System.Drawing.Size(478, 325);
            this.flowLayoutPanelBranches.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.groupBoxButtons);
            this.groupBoxFilters.Controls.Add(this.groupBoxReport);
            this.groupBoxFilters.Controls.Add(this.groupBoxDate);
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxFilters.Location = new System.Drawing.Point(236, 39);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(400, 349);
            this.groupBoxFilters.TabIndex = 10;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filtreler";
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.buttonClearAllFilter);
            this.groupBoxButtons.Location = new System.Drawing.Point(16, 255);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(368, 70);
            this.groupBoxButtons.TabIndex = 46;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonClearAllFilter
            // 
            this.buttonClearAllFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAllFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearAllFilter.Location = new System.Drawing.Point(10, 25);
            this.buttonClearAllFilter.Name = "buttonClearAllFilter";
            this.buttonClearAllFilter.Size = new System.Drawing.Size(347, 34);
            this.buttonClearAllFilter.TabIndex = 42;
            this.buttonClearAllFilter.Text = "Tüm Filtreleri Temizle";
            this.buttonClearAllFilter.UseVisualStyleBackColor = true;
            this.buttonClearAllFilter.Click += new System.EventHandler(this.buttonClearAllFilter_Click);
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.comboBoxFilters);
            this.groupBoxReport.Controls.Add(this.label1);
            this.groupBoxReport.Location = new System.Drawing.Point(16, 173);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(368, 70);
            this.groupBoxReport.TabIndex = 45;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Rapor Seçimi:";
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Items.AddRange(new object[] {
            "Toplam_Listele",
            "Aktif_Listele",
            "Bekleyen_Listele",
            "Pasif_Listele",
            "Kadın_Kayıtlar_Listele_Toplam",
            "Kadın_Kayıtlar_Listele_Aktif",
            "Kadın_Kayıtlar_Listele_Bekleyen",
            "Kadın_Kayıtlar_Listele_Pasif",
            "Erkek_Kayıtlar_Listele_Toplam",
            "Erkek_Kayıtlar_Listele_Aktif",
            "Erkek_Kayıtlar_Listele_Bekleyen",
            "Erkek_Kayıtlar_Listele_Pasif",
            "Branşlara_Göre_Toplam",
            "Branşlara_Göre_Aktif",
            "Branşlara_Göre_Bekleyen",
            "Branşlara_Göre_Pasif",
            "Haftalık_Rapor",
            "Günsonu_Rapor",
            "Aysonu_Rapor",
            "Yılsonu_Rapor",
            "Anlık_Rapor"});
            this.comboBoxFilters.Location = new System.Drawing.Point(117, 26);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(240, 28);
            this.comboBoxFilters.TabIndex = 38;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Rapor Seçiniz:";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.checkBoxSelectDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxDate.Controls.Add(this.labelStartDate);
            this.groupBoxDate.Controls.Add(this.labelEndDate);
            this.groupBoxDate.Location = new System.Drawing.Point(16, 31);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(368, 130);
            this.groupBoxDate.TabIndex = 44;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Tarih:";
            // 
            // checkBoxSelectDate
            // 
            this.checkBoxSelectDate.AutoSize = true;
            this.checkBoxSelectDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.checkBoxSelectDate.Location = new System.Drawing.Point(6, 26);
            this.checkBoxSelectDate.Name = "checkBoxSelectDate";
            this.checkBoxSelectDate.Size = new System.Drawing.Size(89, 24);
            this.checkBoxSelectDate.TabIndex = 35;
            this.checkBoxSelectDate.Text = "Tarih Seç";
            this.checkBoxSelectDate.UseVisualStyleBackColor = true;
            this.checkBoxSelectDate.CheckedChanged += new System.EventHandler(this.checkBoxSelectDate_CheckedChanged);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerStartDate.Enabled = false;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(167, 50);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(118, 27);
            this.dateTimePickerStartDate.TabIndex = 36;
            this.dateTimePickerStartDate.Value = new System.DateTime(2025, 2, 15, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerEndDate.Enabled = false;
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(167, 81);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(118, 27);
            this.dateTimePickerEndDate.TabIndex = 37;
            this.dateTimePickerEndDate.Value = new System.DateTime(2025, 2, 15, 0, 0, 0, 0);
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStartDate.Location = new System.Drawing.Point(6, 57);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(123, 20);
            this.labelStartDate.TabIndex = 39;
            this.labelStartDate.Text = "Başlangıç Tarihi:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEndDate.Location = new System.Drawing.Point(6, 88);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(85, 20);
            this.labelEndDate.TabIndex = 40;
            this.labelEndDate.Text = "Bitiş Tarihi:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "LOGO.png");
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1163, 721);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.groupBoxBranches);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxLists);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.groupBoxLists.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.groupBoxBranches.ResumeLayout(false);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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