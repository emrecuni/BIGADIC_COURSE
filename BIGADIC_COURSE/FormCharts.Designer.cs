namespace BIGADIC_COURSE
{
    partial class FormCharts
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
            menuStripChart = new MenuStrip();
            courseToolStripMenuItem = new ToolStripMenuItem();
            genderToolStripMenuItem = new ToolStripMenuItem();
            registerTypeToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            splitContainerChart = new SplitContainer();
            groupBoxFilters = new GroupBox();
            groupBoxGender = new GroupBox();
            buttonClearGender = new Button();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            groupBoxRegisterType = new GroupBox();
            radioButtonWaiting = new RadioButton();
            radioButtonPassive = new RadioButton();
            radioButtonActive = new RadioButton();
            radioButtonTotal = new RadioButton();
            groupBoxDate = new GroupBox();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            labelEndDate = new Label();
            labelStartDate = new Label();
            checkBoxSelectDate = new CheckBox();
            labelTitle = new Label();
            menuStripChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChart).BeginInit();
            splitContainerChart.Panel1.SuspendLayout();
            splitContainerChart.Panel2.SuspendLayout();
            splitContainerChart.SuspendLayout();
            groupBoxFilters.SuspendLayout();
            groupBoxGender.SuspendLayout();
            groupBoxRegisterType.SuspendLayout();
            groupBoxDate.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripChart
            // 
            menuStripChart.BackColor = SystemColors.Control;
            menuStripChart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            menuStripChart.Items.AddRange(new ToolStripItem[] { courseToolStripMenuItem, genderToolStripMenuItem, registerTypeToolStripMenuItem, printToolStripMenuItem });
            menuStripChart.Location = new Point(0, 0);
            menuStripChart.Name = "menuStripChart";
            menuStripChart.Padding = new Padding(8, 3, 0, 3);
            menuStripChart.Size = new Size(1214, 31);
            menuStripChart.TabIndex = 0;
            menuStripChart.Text = "menuStrip1";
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(117, 25);
            courseToolStripMenuItem.Text = "Kurs Bazında";
            // 
            // genderToolStripMenuItem
            // 
            genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            genderToolStripMenuItem.Size = new Size(143, 25);
            genderToolStripMenuItem.Text = "Cinsiyet Bazında";
            // 
            // registerTypeToolStripMenuItem
            // 
            registerTypeToolStripMenuItem.Name = "registerTypeToolStripMenuItem";
            registerTypeToolStripMenuItem.Size = new Size(186, 25);
            registerTypeToolStripMenuItem.Text = "Kayıt Durumu Bazında";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(68, 25);
            printToolStripMenuItem.Text = "Yazdır";
            // 
            // splitContainerChart
            // 
            splitContainerChart.Dock = DockStyle.Fill;
            splitContainerChart.Location = new Point(0, 31);
            splitContainerChart.Margin = new Padding(4);
            splitContainerChart.Name = "splitContainerChart";
            splitContainerChart.Orientation = Orientation.Horizontal;
            // 
            // splitContainerChart.Panel1
            // 
            splitContainerChart.Panel1.Controls.Add(groupBoxFilters);
            // 
            // splitContainerChart.Panel2
            // 
            splitContainerChart.Panel2.Controls.Add(labelTitle);
            splitContainerChart.Size = new Size(1214, 633);
            splitContainerChart.SplitterDistance = 105;
            splitContainerChart.SplitterWidth = 5;
            splitContainerChart.TabIndex = 1;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.Controls.Add(groupBoxGender);
            groupBoxFilters.Controls.Add(groupBoxRegisterType);
            groupBoxFilters.Controls.Add(groupBoxDate);
            groupBoxFilters.Location = new Point(4, 4);
            groupBoxFilters.Margin = new Padding(4);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Padding = new Padding(4);
            groupBoxFilters.Size = new Size(1206, 98);
            groupBoxFilters.TabIndex = 0;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Filtreler";
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(buttonClearGender);
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Location = new Point(922, 21);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(276, 67);
            groupBoxGender.TabIndex = 2;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Cinsiyet";
            // 
            // buttonClearGender
            // 
            buttonClearGender.Location = new Point(184, 23);
            buttonClearGender.Name = "buttonClearGender";
            buttonClearGender.Size = new Size(86, 33);
            buttonClearGender.TabIndex = 2;
            buttonClearGender.Text = "Temizle";
            buttonClearGender.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(93, 26);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(66, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Kadın";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(10, 26);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(65, 24);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Erkek";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // groupBoxRegisterType
            // 
            groupBoxRegisterType.Controls.Add(radioButtonWaiting);
            groupBoxRegisterType.Controls.Add(radioButtonPassive);
            groupBoxRegisterType.Controls.Add(radioButtonActive);
            groupBoxRegisterType.Controls.Add(radioButtonTotal);
            groupBoxRegisterType.Location = new Point(593, 21);
            groupBoxRegisterType.Name = "groupBoxRegisterType";
            groupBoxRegisterType.Size = new Size(323, 67);
            groupBoxRegisterType.TabIndex = 1;
            groupBoxRegisterType.TabStop = false;
            groupBoxRegisterType.Text = "Kayıt Durumu";
            // 
            // radioButtonWaiting
            // 
            radioButtonWaiting.AutoSize = true;
            radioButtonWaiting.ForeColor = Color.Yellow;
            radioButtonWaiting.Location = new Point(219, 26);
            radioButtonWaiting.Name = "radioButtonWaiting";
            radioButtonWaiting.Size = new Size(89, 24);
            radioButtonWaiting.TabIndex = 3;
            radioButtonWaiting.TabStop = true;
            radioButtonWaiting.Text = "Bekleyen";
            radioButtonWaiting.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassive
            // 
            radioButtonPassive.AutoSize = true;
            radioButtonPassive.ForeColor = Color.Red;
            radioButtonPassive.Location = new Point(155, 26);
            radioButtonPassive.Name = "radioButtonPassive";
            radioButtonPassive.Size = new Size(59, 24);
            radioButtonPassive.TabIndex = 2;
            radioButtonPassive.TabStop = true;
            radioButtonPassive.Text = "Pasif";
            radioButtonPassive.UseVisualStyleBackColor = true;
            // 
            // radioButtonActive
            // 
            radioButtonActive.AutoSize = true;
            radioButtonActive.ForeColor = SystemColors.Highlight;
            radioButtonActive.Location = new Point(91, 26);
            radioButtonActive.Name = "radioButtonActive";
            radioButtonActive.Size = new Size(59, 24);
            radioButtonActive.TabIndex = 1;
            radioButtonActive.TabStop = true;
            radioButtonActive.Text = "Aktif";
            radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonTotal
            // 
            radioButtonTotal.AutoSize = true;
            radioButtonTotal.Location = new Point(9, 26);
            radioButtonTotal.Name = "radioButtonTotal";
            radioButtonTotal.Size = new Size(77, 24);
            radioButtonTotal.TabIndex = 0;
            radioButtonTotal.TabStop = true;
            radioButtonTotal.Text = "Toplam";
            radioButtonTotal.UseVisualStyleBackColor = true;
            // 
            // groupBoxDate
            // 
            groupBoxDate.Controls.Add(dateTimePickerEndDate);
            groupBoxDate.Controls.Add(dateTimePickerStartDate);
            groupBoxDate.Controls.Add(labelEndDate);
            groupBoxDate.Controls.Add(labelStartDate);
            groupBoxDate.Controls.Add(checkBoxSelectDate);
            groupBoxDate.Location = new Point(8, 21);
            groupBoxDate.Name = "groupBoxDate";
            groupBoxDate.Size = new Size(579, 67);
            groupBoxDate.TabIndex = 0;
            groupBoxDate.TabStop = false;
            groupBoxDate.Text = "Tarih";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(449, 31);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(116, 27);
            dateTimePickerEndDate.TabIndex = 4;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(236, 31);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(110, 27);
            dateTimePickerStartDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(356, 34);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(83, 20);
            labelEndDate.TabIndex = 2;
            labelEndDate.Text = "Bitiş Tarihi:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(107, 34);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(119, 20);
            labelStartDate.TabIndex = 1;
            labelStartDate.Text = "Başlangıç Tarihi:";
            // 
            // checkBoxSelectDate
            // 
            checkBoxSelectDate.AutoSize = true;
            checkBoxSelectDate.Location = new Point(13, 32);
            checkBoxSelectDate.Name = "checkBoxSelectDate";
            checkBoxSelectDate.Size = new Size(89, 24);
            checkBoxSelectDate.TabIndex = 0;
            checkBoxSelectDate.Text = "Tarih Seç";
            checkBoxSelectDate.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(545, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // FormCharts
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1214, 664);
            Controls.Add(splitContainerChart);
            Controls.Add(menuStripChart);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MainMenuStrip = menuStripChart;
            Margin = new Padding(4);
            Name = "FormCharts";
            Text = "FormCharts";
            menuStripChart.ResumeLayout(false);
            menuStripChart.PerformLayout();
            splitContainerChart.Panel1.ResumeLayout(false);
            splitContainerChart.Panel2.ResumeLayout(false);
            splitContainerChart.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChart).EndInit();
            splitContainerChart.ResumeLayout(false);
            groupBoxFilters.ResumeLayout(false);
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            groupBoxRegisterType.ResumeLayout(false);
            groupBoxRegisterType.PerformLayout();
            groupBoxDate.ResumeLayout(false);
            groupBoxDate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripChart;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem genderToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private SplitContainer splitContainerChart;
        private GroupBox groupBoxFilters;
        private GroupBox groupBoxDate;
        private DateTimePicker dateTimePickerStartDate;
        private Label labelEndDate;
        private Label labelStartDate;
        private CheckBox checkBoxSelectDate;
        private GroupBox groupBoxGender;
        private GroupBox groupBoxRegisterType;
        private DateTimePicker dateTimePickerEndDate;
        private Button buttonClearGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonWaiting;
        private RadioButton radioButtonPassive;
        private RadioButton radioButtonActive;
        private RadioButton radioButtonTotal;
        private ToolStripMenuItem registerTypeToolStripMenuItem;
        private Label labelTitle;
    }
}