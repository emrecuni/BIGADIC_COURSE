namespace BIGADIC_COURSE
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            branchToolStripMenuItem = new ToolStripMenuItem();
            addBranchToolStripMenuItem = new ToolStripMenuItem();
            deleteBranchToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            graphicToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            personelToolStripMenuItem = new ToolStripMenuItem();
            addPersonelToolStripMenuItem = new ToolStripMenuItem();
            deletePersonelToolStripMenuItem = new ToolStripMenuItem();
            listPersonelToolStripMenuItem = new ToolStripMenuItem();
            birthDatesToolStripMenuItem = new ToolStripMenuItem();
            adminPanelToolStripMenuItem = new ToolStripMenuItem();
            groupBoxPerson = new GroupBox();
            labelEndDate = new Label();
            labelStartDate = new Label();
            dateTimePickerRegisterDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            buttonOrder = new Button();
            dateTimePickerStartDate = new DateTimePicker();
            checkBoxSelectDate = new CheckBox();
            textBoxId = new TextBox();
            labelId = new Label();
            buttonBackup = new Button();
            maskedTextBoxPhone = new MaskedTextBox();
            dateTimePickerBirthDate = new DateTimePicker();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            buttonRegister = new Button();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            textBoxSelectionBranches = new TextBox();
            maskedTextBoxTckn = new MaskedTextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            labelSelectionBranches = new Label();
            labelRegisterDate = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            labelBirthDate = new Label();
            labelTckn = new Label();
            labelSurname = new Label();
            labelName = new Label();
            groupBoxTotal = new GroupBox();
            radioButtonTotal = new RadioButton();
            radioButtonWaiting = new RadioButton();
            radioButtonPassive = new RadioButton();
            radioButtonActive = new RadioButton();
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
            groupBoxListGraphicsPrint = new GroupBox();
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
            groupBoxMain = new GroupBox();
            textBoxTitle = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            groupBoxPerson.SuspendLayout();
            groupBoxTotal.SuspendLayout();
            groupBoxBranches.SuspendLayout();
            groupBoxListGraphicsPrint.SuspendLayout();
            groupBoxList.SuspendLayout();
            groupBoxMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.Items.AddRange(new ToolStripItem[] { branchToolStripMenuItem, reportToolStripMenuItem, graphicToolStripMenuItem, importToolStripMenuItem, personelToolStripMenuItem, birthDatesToolStripMenuItem, adminPanelToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1260, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBranchToolStripMenuItem, deleteBranchToolStripMenuItem });
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(91, 24);
            branchToolStripMenuItem.Text = "Branş Ekle";
            // 
            // addBranchToolStripMenuItem
            // 
            addBranchToolStripMenuItem.Name = "addBranchToolStripMenuItem";
            addBranchToolStripMenuItem.Size = new Size(106, 24);
            addBranchToolStripMenuItem.Text = "Ekle";
            addBranchToolStripMenuItem.Click += addBranchToolStripMenuItem_Click;
            // 
            // deleteBranchToolStripMenuItem
            // 
            deleteBranchToolStripMenuItem.Name = "deleteBranchToolStripMenuItem";
            deleteBranchToolStripMenuItem.Size = new Size(106, 24);
            deleteBranchToolStripMenuItem.Text = "Sil";
            deleteBranchToolStripMenuItem.Click += deleteBranchToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(62, 24);
            reportToolStripMenuItem.Text = "Rapor";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // graphicToolStripMenuItem
            // 
            graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            graphicToolStripMenuItem.Size = new Size(62, 24);
            graphicToolStripMenuItem.Text = "Grafik";
            graphicToolStripMenuItem.Click += graphicToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(91, 24);
            importToolStripMenuItem.Text = "İçeri Aktar";
            importToolStripMenuItem.Visible = false;
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // personelToolStripMenuItem
            // 
            personelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPersonelToolStripMenuItem, deletePersonelToolStripMenuItem, listPersonelToolStripMenuItem });
            personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            personelToolStripMenuItem.Size = new Size(79, 24);
            personelToolStripMenuItem.Text = "Personel";
            // 
            // addPersonelToolStripMenuItem
            // 
            addPersonelToolStripMenuItem.Name = "addPersonelToolStripMenuItem";
            addPersonelToolStripMenuItem.Size = new Size(120, 24);
            addPersonelToolStripMenuItem.Text = "Ekle";
            addPersonelToolStripMenuItem.Click += addPersonelToolStripMenuItem_Click;
            // 
            // deletePersonelToolStripMenuItem
            // 
            deletePersonelToolStripMenuItem.Name = "deletePersonelToolStripMenuItem";
            deletePersonelToolStripMenuItem.Size = new Size(120, 24);
            deletePersonelToolStripMenuItem.Text = "Sil";
            deletePersonelToolStripMenuItem.Click += deletePersonelToolStripMenuItem_Click;
            // 
            // listPersonelToolStripMenuItem
            // 
            listPersonelToolStripMenuItem.Name = "listPersonelToolStripMenuItem";
            listPersonelToolStripMenuItem.Size = new Size(120, 24);
            listPersonelToolStripMenuItem.Text = "Listele";
            listPersonelToolStripMenuItem.Click += listPersonelToolStripMenuItem_Click;
            // 
            // birthDatesToolStripMenuItem
            // 
            birthDatesToolStripMenuItem.Name = "birthDatesToolStripMenuItem";
            birthDatesToolStripMenuItem.Size = new Size(126, 24);
            birthDatesToolStripMenuItem.Text = "Doğum Günleri";
            birthDatesToolStripMenuItem.Click += birthDatesToolStripMenuItem_Click;
            // 
            // adminPanelToolStripMenuItem
            // 
            adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            adminPanelToolStripMenuItem.Size = new Size(123, 24);
            adminPanelToolStripMenuItem.Text = "Yönetim Paneli";
            adminPanelToolStripMenuItem.Visible = false;
            adminPanelToolStripMenuItem.Click += adminPanelToolStripMenuItem_Click;
            // 
            // groupBoxPerson
            // 
            groupBoxPerson.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxPerson.Controls.Add(labelEndDate);
            groupBoxPerson.Controls.Add(labelStartDate);
            groupBoxPerson.Controls.Add(dateTimePickerRegisterDate);
            groupBoxPerson.Controls.Add(dateTimePickerEndDate);
            groupBoxPerson.Controls.Add(buttonOrder);
            groupBoxPerson.Controls.Add(dateTimePickerStartDate);
            groupBoxPerson.Controls.Add(checkBoxSelectDate);
            groupBoxPerson.Controls.Add(textBoxId);
            groupBoxPerson.Controls.Add(labelId);
            groupBoxPerson.Controls.Add(buttonBackup);
            groupBoxPerson.Controls.Add(maskedTextBoxPhone);
            groupBoxPerson.Controls.Add(dateTimePickerBirthDate);
            groupBoxPerson.Controls.Add(buttonClear);
            groupBoxPerson.Controls.Add(buttonDelete);
            groupBoxPerson.Controls.Add(buttonUpdate);
            groupBoxPerson.Controls.Add(buttonSearch);
            groupBoxPerson.Controls.Add(buttonRegister);
            groupBoxPerson.Controls.Add(radioButtonMale);
            groupBoxPerson.Controls.Add(radioButtonFemale);
            groupBoxPerson.Controls.Add(textBoxSelectionBranches);
            groupBoxPerson.Controls.Add(maskedTextBoxTckn);
            groupBoxPerson.Controls.Add(textBoxSurname);
            groupBoxPerson.Controls.Add(textBoxName);
            groupBoxPerson.Controls.Add(labelSelectionBranches);
            groupBoxPerson.Controls.Add(labelRegisterDate);
            groupBoxPerson.Controls.Add(labelGender);
            groupBoxPerson.Controls.Add(labelPhone);
            groupBoxPerson.Controls.Add(labelBirthDate);
            groupBoxPerson.Controls.Add(labelTckn);
            groupBoxPerson.Controls.Add(labelSurname);
            groupBoxPerson.Controls.Add(labelName);
            groupBoxPerson.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBoxPerson.ForeColor = SystemColors.Desktop;
            groupBoxPerson.Location = new Point(13, 50);
            groupBoxPerson.Margin = new Padding(3, 2, 3, 2);
            groupBoxPerson.Name = "groupBoxPerson";
            groupBoxPerson.Padding = new Padding(3, 2, 3, 2);
            groupBoxPerson.Size = new Size(602, 460);
            groupBoxPerson.TabIndex = 0;
            groupBoxPerson.TabStop = false;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(15, 408);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(83, 20);
            labelEndDate.TabIndex = 37;
            labelEndDate.Text = "Bitiş Tarihi:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(15, 377);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(119, 20);
            labelStartDate.TabIndex = 36;
            labelStartDate.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerRegisterDate
            // 
            dateTimePickerRegisterDate.CalendarMonthBackground = Color.White;
            dateTimePickerRegisterDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRegisterDate.Enabled = false;
            dateTimePickerRegisterDate.Format = DateTimePickerFormat.Short;
            dateTimePickerRegisterDate.Location = new Point(140, 258);
            dateTimePickerRegisterDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerRegisterDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            dateTimePickerRegisterDate.Size = new Size(199, 27);
            dateTimePickerRegisterDate.TabIndex = 35;
            dateTimePickerRegisterDate.Value = new DateTime(2025, 2, 11, 23, 6, 0, 0);
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(140, 404);
            dateTimePickerEndDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEndDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(100, 27);
            dateTimePickerEndDate.TabIndex = 33;
            dateTimePickerEndDate.Value = new DateTime(2025, 2, 15, 0, 0, 0, 0);
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.Silver;
            buttonOrder.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonOrder.Location = new Point(442, 211);
            buttonOrder.Margin = new Padding(3, 2, 3, 2);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(149, 41);
            buttonOrder.TabIndex = 12;
            buttonOrder.Text = "Listele";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(140, 373);
            dateTimePickerStartDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStartDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(100, 27);
            dateTimePickerStartDate.TabIndex = 32;
            dateTimePickerStartDate.Value = new DateTime(2025, 2, 15, 0, 0, 0, 0);
            // 
            // checkBoxSelectDate
            // 
            checkBoxSelectDate.AutoSize = true;
            checkBoxSelectDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            checkBoxSelectDate.Location = new Point(140, 344);
            checkBoxSelectDate.Name = "checkBoxSelectDate";
            checkBoxSelectDate.Size = new Size(89, 24);
            checkBoxSelectDate.TabIndex = 31;
            checkBoxSelectDate.Text = "Tarih Seç";
            checkBoxSelectDate.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxId.ForeColor = Color.Black;
            textBoxId.Location = new Point(140, 18);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(151, 25);
            textBoxId.TabIndex = 27;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelId.ForeColor = Color.Black;
            labelId.Location = new Point(16, 20);
            labelId.Name = "labelId";
            labelId.Size = new Size(51, 20);
            labelId.TabIndex = 26;
            labelId.Text = "Id No:";
            // 
            // buttonBackup
            // 
            buttonBackup.BackColor = Color.Silver;
            buttonBackup.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonBackup.ForeColor = Color.Red;
            buttonBackup.Location = new Point(442, 311);
            buttonBackup.Margin = new Padding(3, 2, 3, 2);
            buttonBackup.Name = "buttonBackup";
            buttonBackup.Size = new Size(149, 41);
            buttonBackup.TabIndex = 25;
            buttonBackup.Text = "Yedekle";
            buttonBackup.UseVisualStyleBackColor = false;
            buttonBackup.Click += buttonBackup_Click;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.BackColor = Color.White;
            maskedTextBoxPhone.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            maskedTextBoxPhone.ForeColor = Color.Black;
            maskedTextBoxPhone.Location = new Point(140, 190);
            maskedTextBoxPhone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPhone.Mask = "0000000000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.PromptChar = ' ';
            maskedTextBoxPhone.Size = new Size(199, 25);
            maskedTextBoxPhone.TabIndex = 5;
            maskedTextBoxPhone.Click += maskedTextBox_Click;
            maskedTextBoxPhone.Enter += textBox_Enter;
            maskedTextBoxPhone.KeyDown += textBox_KeyDown;
            maskedTextBoxPhone.Leave += textBox_Leave;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.CalendarMonthBackground = Color.White;
            dateTimePickerBirthDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(140, 153);
            dateTimePickerBirthDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(199, 27);
            dateTimePickerBirthDate.TabIndex = 4;
            dateTimePickerBirthDate.Value = new DateTime(2025, 2, 11, 23, 6, 0, 0);
            dateTimePickerBirthDate.Enter += textBox_Enter;
            dateTimePickerBirthDate.Leave += textBox_Leave;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Silver;
            buttonClear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonClear.ForeColor = Color.Black;
            buttonClear.Location = new Point(442, 259);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(149, 41);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Temizleme";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Silver;
            buttonDelete.Enabled = false;
            buttonDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.Red;
            buttonDelete.Location = new Point(442, 163);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(149, 41);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Silver;
            buttonUpdate.Enabled = false;
            buttonUpdate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(442, 115);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(149, 41);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Silver;
            buttonSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(442, 67);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(149, 41);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Bul";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Silver;
            buttonRegister.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.Black;
            buttonRegister.Location = new Point(442, 19);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(149, 41);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "Kaydet";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            radioButtonMale.ForeColor = Color.Red;
            radioButtonMale.Location = new Point(216, 229);
            radioButtonMale.Margin = new Padding(3, 2, 3, 2);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(65, 24);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.Text = "Erkek";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            radioButtonFemale.ForeColor = Color.Red;
            radioButtonFemale.Location = new Point(140, 229);
            radioButtonFemale.Margin = new Padding(3, 2, 3, 2);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(66, 24);
            radioButtonFemale.TabIndex = 6;
            radioButtonFemale.Text = "Kadın";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxSelectionBranches
            // 
            textBoxSelectionBranches.Enabled = false;
            textBoxSelectionBranches.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSelectionBranches.ForeColor = Color.Black;
            textBoxSelectionBranches.Location = new Point(140, 298);
            textBoxSelectionBranches.Margin = new Padding(3, 2, 3, 2);
            textBoxSelectionBranches.Name = "textBoxSelectionBranches";
            textBoxSelectionBranches.Size = new Size(274, 25);
            textBoxSelectionBranches.TabIndex = 14;
            // 
            // maskedTextBoxTckn
            // 
            maskedTextBoxTckn.BackColor = Color.White;
            maskedTextBoxTckn.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            maskedTextBoxTckn.ForeColor = Color.Black;
            maskedTextBoxTckn.Location = new Point(140, 121);
            maskedTextBoxTckn.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxTckn.Mask = "00000000000";
            maskedTextBoxTckn.Name = "maskedTextBoxTckn";
            maskedTextBoxTckn.PromptChar = ' ';
            maskedTextBoxTckn.Size = new Size(199, 25);
            maskedTextBoxTckn.TabIndex = 3;
            maskedTextBoxTckn.Click += maskedTextBox_Click;
            maskedTextBoxTckn.Enter += textBox_Enter;
            maskedTextBoxTckn.KeyDown += textBox_KeyDown;
            maskedTextBoxTckn.Leave += textBox_Leave;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.White;
            textBoxSurname.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSurname.ForeColor = Color.Black;
            textBoxSurname.Location = new Point(140, 85);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(199, 25);
            textBoxSurname.TabIndex = 2;
            textBoxSurname.Enter += textBox_Enter;
            textBoxSurname.KeyDown += textBox_KeyDown;
            textBoxSurname.Leave += textBox_Leave;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(140, 50);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 25);
            textBoxName.TabIndex = 1;
            textBoxName.Enter += textBox_Enter;
            textBoxName.KeyDown += textBox_KeyDown;
            textBoxName.Leave += textBox_Leave;
            // 
            // labelSelectionBranches
            // 
            labelSelectionBranches.AutoSize = true;
            labelSelectionBranches.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelSelectionBranches.ForeColor = Color.Black;
            labelSelectionBranches.Location = new Point(15, 300);
            labelSelectionBranches.Name = "labelSelectionBranches";
            labelSelectionBranches.Size = new Size(51, 20);
            labelSelectionBranches.TabIndex = 7;
            labelSelectionBranches.Text = "Branş:";
            // 
            // labelRegisterDate
            // 
            labelRegisterDate.AutoSize = true;
            labelRegisterDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelRegisterDate.ForeColor = Color.Black;
            labelRegisterDate.Location = new Point(16, 262);
            labelRegisterDate.Name = "labelRegisterDate";
            labelRegisterDate.Size = new Size(89, 20);
            labelRegisterDate.TabIndex = 6;
            labelRegisterDate.Text = "Kayıt Tarihi:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelGender.ForeColor = Color.Black;
            labelGender.Location = new Point(16, 227);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(66, 20);
            labelGender.TabIndex = 5;
            labelGender.Text = "Cinsiyet:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelPhone.ForeColor = Color.Black;
            labelPhone.Location = new Point(16, 192);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(63, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Telefon:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelBirthDate.ForeColor = Color.Black;
            labelBirthDate.Location = new Point(16, 157);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(106, 20);
            labelBirthDate.TabIndex = 3;
            labelBirthDate.Text = "Doğum Tarihi:";
            // 
            // labelTckn
            // 
            labelTckn.AutoSize = true;
            labelTckn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelTckn.ForeColor = Color.Black;
            labelTckn.Location = new Point(16, 122);
            labelTckn.Name = "labelTckn";
            labelTckn.Size = new Size(62, 20);
            labelTckn.TabIndex = 2;
            labelTckn.Text = "T.C. No:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelSurname.ForeColor = Color.Black;
            labelSurname.Location = new Point(16, 87);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(59, 20);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Soyadı:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(16, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Adı:";
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(radioButtonTotal);
            groupBoxTotal.Controls.Add(radioButtonWaiting);
            groupBoxTotal.Controls.Add(radioButtonPassive);
            groupBoxTotal.Controls.Add(radioButtonActive);
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
            groupBoxTotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBoxTotal.ForeColor = Color.Black;
            groupBoxTotal.Location = new Point(625, 50);
            groupBoxTotal.Margin = new Padding(3, 2, 3, 2);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Padding = new Padding(3, 2, 3, 2);
            groupBoxTotal.Size = new Size(193, 460);
            groupBoxTotal.TabIndex = 1;
            groupBoxTotal.TabStop = false;
            // 
            // radioButtonTotal
            // 
            radioButtonTotal.AutoSize = true;
            radioButtonTotal.Enabled = false;
            radioButtonTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonTotal.ForeColor = Color.Black;
            radioButtonTotal.Location = new Point(36, 343);
            radioButtonTotal.Margin = new Padding(3, 2, 3, 2);
            radioButtonTotal.Name = "radioButtonTotal";
            radioButtonTotal.Size = new Size(79, 24);
            radioButtonTotal.TabIndex = 15;
            radioButtonTotal.Text = "Toplam";
            radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaiting
            // 
            radioButtonWaiting.AutoSize = true;
            radioButtonWaiting.Checked = true;
            radioButtonWaiting.Enabled = false;
            radioButtonWaiting.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonWaiting.ForeColor = Color.Yellow;
            radioButtonWaiting.Location = new Point(36, 418);
            radioButtonWaiting.Margin = new Padding(3, 2, 3, 2);
            radioButtonWaiting.Name = "radioButtonWaiting";
            radioButtonWaiting.Size = new Size(90, 24);
            radioButtonWaiting.TabIndex = 14;
            radioButtonWaiting.TabStop = true;
            radioButtonWaiting.Text = "Bekleyen";
            radioButtonWaiting.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassive
            // 
            radioButtonPassive.AutoSize = true;
            radioButtonPassive.Enabled = false;
            radioButtonPassive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonPassive.ForeColor = Color.Red;
            radioButtonPassive.Location = new Point(36, 393);
            radioButtonPassive.Margin = new Padding(3, 2, 3, 2);
            radioButtonPassive.Name = "radioButtonPassive";
            radioButtonPassive.Size = new Size(61, 24);
            radioButtonPassive.TabIndex = 13;
            radioButtonPassive.Text = "Pasif";
            radioButtonPassive.UseVisualStyleBackColor = true;
            // 
            // radioButtonActive
            // 
            radioButtonActive.AutoSize = true;
            radioButtonActive.Enabled = false;
            radioButtonActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButtonActive.ForeColor = SystemColors.Highlight;
            radioButtonActive.Location = new Point(36, 368);
            radioButtonActive.Margin = new Padding(3, 2, 3, 2);
            radioButtonActive.Name = "radioButtonActive";
            radioButtonActive.Size = new Size(62, 24);
            radioButtonActive.TabIndex = 12;
            radioButtonActive.Text = "Aktif";
            radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // textBoxMale
            // 
            textBoxMale.Enabled = false;
            textBoxMale.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxMale.ForeColor = Color.Black;
            textBoxMale.Location = new Point(31, 276);
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
            textBoxFemale.Location = new Point(31, 230);
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
            textBoxWaitingRegisters.Location = new Point(31, 184);
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
            textBoxPassiveRegisters.Location = new Point(31, 138);
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
            textBoxActiveRegisters.Location = new Point(31, 92);
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
            textBoxTotalRegister.Location = new Point(31, 47);
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
            labelMale.Location = new Point(33, 256);
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
            labelFemale.Location = new Point(33, 210);
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
            labelWaitingRegisters.Location = new Point(33, 164);
            labelWaitingRegisters.Name = "labelWaitingRegisters";
            labelWaitingRegisters.Size = new Size(72, 18);
            labelWaitingRegisters.TabIndex = 3;
            labelWaitingRegisters.Text = "Bekleyen";
            // 
            // labelPassiveRegisters
            // 
            labelPassiveRegisters.AutoSize = true;
            labelPassiveRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPassiveRegisters.ForeColor = Color.Black;
            labelPassiveRegisters.Location = new Point(33, 118);
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
            labelActiveRegisters.Location = new Point(33, 72);
            labelActiveRegisters.Name = "labelActiveRegisters";
            labelActiveRegisters.Size = new Size(48, 18);
            labelActiveRegisters.TabIndex = 1;
            labelActiveRegisters.Text = "Aktif";
            // 
            // labelTotalRegisters
            // 
            labelTotalRegisters.AutoSize = true;
            labelTotalRegisters.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelTotalRegisters.ForeColor = Color.Black;
            labelTotalRegisters.Location = new Point(33, 27);
            labelTotalRegisters.Name = "labelTotalRegisters";
            labelTotalRegisters.Size = new Size(56, 18);
            labelTotalRegisters.TabIndex = 0;
            labelTotalRegisters.Text = "Toplam";
            // 
            // groupBoxBranches
            // 
            groupBoxBranches.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBranches.Controls.Add(flowLayoutPanelBranches);
            groupBoxBranches.FlatStyle = FlatStyle.Popup;
            groupBoxBranches.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBoxBranches.Location = new Point(827, 50);
            groupBoxBranches.Margin = new Padding(3, 2, 3, 2);
            groupBoxBranches.Name = "groupBoxBranches";
            groupBoxBranches.Padding = new Padding(3, 2, 3, 2);
            groupBoxBranches.Size = new Size(399, 460);
            groupBoxBranches.TabIndex = 2;
            groupBoxBranches.TabStop = false;
            // 
            // flowLayoutPanelBranches
            // 
            flowLayoutPanelBranches.AutoScroll = true;
            flowLayoutPanelBranches.Dock = DockStyle.Fill;
            flowLayoutPanelBranches.Location = new Point(3, 22);
            flowLayoutPanelBranches.Margin = new Padding(1);
            flowLayoutPanelBranches.Name = "flowLayoutPanelBranches";
            flowLayoutPanelBranches.Size = new Size(393, 436);
            flowLayoutPanelBranches.TabIndex = 0;
            // 
            // groupBoxListGraphicsPrint
            // 
            groupBoxListGraphicsPrint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxListGraphicsPrint.Controls.Add(groupBoxList);
            groupBoxListGraphicsPrint.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            groupBoxListGraphicsPrint.Location = new Point(13, 514);
            groupBoxListGraphicsPrint.Margin = new Padding(3, 2, 3, 2);
            groupBoxListGraphicsPrint.Name = "groupBoxListGraphicsPrint";
            groupBoxListGraphicsPrint.Padding = new Padding(3, 2, 3, 2);
            groupBoxListGraphicsPrint.Size = new Size(1213, 271);
            groupBoxListGraphicsPrint.TabIndex = 5;
            groupBoxListGraphicsPrint.TabStop = false;
            groupBoxListGraphicsPrint.Text = "Listeler";
            // 
            // groupBoxList
            // 
            groupBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxList.BackColor = SystemColors.ControlDark;
            groupBoxList.Controls.Add(listViewAllRegister);
            groupBoxList.Location = new Point(6, 24);
            groupBoxList.Margin = new Padding(3, 2, 3, 2);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.Padding = new Padding(3, 2, 3, 2);
            groupBoxList.Size = new Size(1202, 242);
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
            listViewAllRegister.Size = new Size(1196, 220);
            listViewAllRegister.TabIndex = 0;
            listViewAllRegister.UseCompatibleStateImageBehavior = false;
            listViewAllRegister.View = View.Details;
            listViewAllRegister.Click += listViewAllRegister_Click;
            listViewAllRegister.KeyDown += listViewAllRegister_Key;
            listViewAllRegister.KeyUp += listViewAllRegister_Key;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "ID";
            columnHeaderId.Width = 90;
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
            columnHeaderBranch.Width = 150;
            // 
            // columnHeaderBirthDate
            // 
            columnHeaderBirthDate.Text = "Doğum Tarihi";
            columnHeaderBirthDate.Width = 130;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.Text = "Telefon";
            columnHeaderPhone.Width = 130;
            // 
            // columnHeaderRegisterDate
            // 
            columnHeaderRegisterDate.Text = "Kayıt Tarihi";
            columnHeaderRegisterDate.Width = 130;
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Durumu";
            columnHeaderStatus.Width = 70;
            // 
            // groupBoxMain
            // 
            groupBoxMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMain.BackColor = Color.Transparent;
            groupBoxMain.Controls.Add(textBoxTitle);
            groupBoxMain.Controls.Add(groupBoxListGraphicsPrint);
            groupBoxMain.Controls.Add(groupBoxBranches);
            groupBoxMain.Controls.Add(groupBoxTotal);
            groupBoxMain.Controls.Add(groupBoxPerson);
            groupBoxMain.Location = new Point(8, 30);
            groupBoxMain.Margin = new Padding(3, 2, 3, 2);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Padding = new Padding(3, 2, 3, 2);
            groupBoxMain.Size = new Size(1240, 799);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.DarkGray;
            textBoxTitle.Enabled = false;
            textBoxTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            textBoxTitle.Location = new Point(13, 13);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(339, 28);
            textBoxTitle.TabIndex = 6;
            textBoxTitle.Text = "BİGADİÇ GENÇLİK VE KÜLTÜR MERKEZİ";
            textBoxTitle.TextAlign = HorizontalAlignment.Right;
            // 
            // timer
            // 
            timer.Interval = 350;
            timer.Tick += timer_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1260, 840);
            Controls.Add(groupBoxMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bigadiç Belediyesi_Bilgi_İşlem";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxPerson.ResumeLayout(false);
            groupBoxPerson.PerformLayout();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            groupBoxBranches.ResumeLayout(false);
            groupBoxListGraphicsPrint.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPerson;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox textBoxSelectionBranches;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTckn;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSelectionBranches;
        private System.Windows.Forms.Label labelRegisterDate;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelTckn;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.RadioButton radioButtonWaiting;
        private System.Windows.Forms.RadioButton radioButtonPassive;
        private System.Windows.Forms.RadioButton radioButtonActive;
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
        private System.Windows.Forms.GroupBox groupBoxListGraphicsPrint;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.ListView listViewAllRegister;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderTCKN;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderBranch;
        private System.Windows.Forms.ColumnHeader columnHeaderRegisterDate;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.ToolStripMenuItem addBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBranchToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.CheckBox checkBoxSelectDate;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem birthDatesToolStripMenuItem;
        private ToolStripMenuItem addPersonelToolStripMenuItem;
        private ToolStripMenuItem deletePersonelToolStripMenuItem;
        private ToolStripMenuItem listPersonelToolStripMenuItem;
    }
}