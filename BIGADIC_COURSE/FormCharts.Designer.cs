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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharts));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.buttonClearGender = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.radioButtonWaiting = new System.Windows.Forms.RadioButton();
            this.radioButtonPassive = new System.Windows.Forms.RadioButton();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.splitContainerChart = new System.Windows.Forms.SplitContainer();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChart)).BeginInit();
            this.splitContainerChart.Panel1.SuspendLayout();
            this.splitContainerChart.Panel2.SuspendLayout();
            this.splitContainerChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.Color.Silver;
            this.chart.Location = new System.Drawing.Point(0, 35);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart.Size = new System.Drawing.Size(1215, 803);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseToolStripMenuItem,
            this.genderToolStripMenuItem,
            this.registerTypeToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripGraphics";
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.courseToolStripMenuItem.Text = "Kurs Bazında";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(143, 25);
            this.genderToolStripMenuItem.Text = "Cinsiyet Bazında";
            this.genderToolStripMenuItem.Click += new System.EventHandler(this.genderToolStripMenuItem_Click);
            // 
            // registerTypeToolStripMenuItem
            // 
            this.registerTypeToolStripMenuItem.Name = "registerTypeToolStripMenuItem";
            this.registerTypeToolStripMenuItem.Size = new System.Drawing.Size(186, 25);
            this.registerTypeToolStripMenuItem.Text = "Kayıt Durumu Bazında";
            this.registerTypeToolStripMenuItem.Click += new System.EventHandler(this.registerTypeToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.printToolStripMenuItem.Text = "Yazdır";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Controls.Add(this.groupBoxGender);
            this.groupBoxFilters.Controls.Add(this.groupBoxFilter);
            this.groupBoxFilters.Controls.Add(this.groupBoxDate);
            this.groupBoxFilters.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.groupBoxFilters.Location = new System.Drawing.Point(6, 3);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(1203, 84);
            this.groupBoxFilters.TabIndex = 11;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filtreler";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.buttonClearGender);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(947, 17);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(246, 59);
            this.groupBoxGender.TabIndex = 46;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Cinsiyet";
            // 
            // buttonClearGender
            // 
            this.buttonClearGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearGender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearGender.Location = new System.Drawing.Point(154, 19);
            this.buttonClearGender.Name = "buttonClearGender";
            this.buttonClearGender.Size = new System.Drawing.Size(86, 33);
            this.buttonClearGender.TabIndex = 24;
            this.buttonClearGender.Text = "Temizle";
            this.buttonClearGender.UseVisualStyleBackColor = true;
            this.buttonClearGender.Click += new System.EventHandler(this.buttonClearGender_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Enabled = false;
            this.radioButtonFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonFemale.Location = new System.Drawing.Point(82, 23);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(66, 24);
            this.radioButtonFemale.TabIndex = 23;
            this.radioButtonFemale.Tag = "K";
            this.radioButtonFemale.Text = "Kadın";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonGender_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Enabled = false;
            this.radioButtonMale.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonMale.Location = new System.Drawing.Point(11, 23);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(65, 24);
            this.radioButtonMale.TabIndex = 22;
            this.radioButtonMale.Tag = "E";
            this.radioButtonMale.Text = "Erkek";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonGender_CheckedChanged);
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.radioButtonTotal);
            this.groupBoxFilter.Controls.Add(this.radioButtonWaiting);
            this.groupBoxFilter.Controls.Add(this.radioButtonPassive);
            this.groupBoxFilter.Controls.Add(this.radioButtonActive);
            this.groupBoxFilter.Location = new System.Drawing.Point(624, 17);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(314, 59);
            this.groupBoxFilter.TabIndex = 45;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filtre:";
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTotal.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTotal.Location = new System.Drawing.Point(8, 25);
            this.radioButtonTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(77, 24);
            this.radioButtonTotal.TabIndex = 19;
            this.radioButtonTotal.Tag = "T";
            this.radioButtonTotal.Text = "Toplam";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            this.radioButtonTotal.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonWaiting
            // 
            this.radioButtonWaiting.AutoSize = true;
            this.radioButtonWaiting.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.radioButtonWaiting.Location = new System.Drawing.Point(224, 25);
            this.radioButtonWaiting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonWaiting.Name = "radioButtonWaiting";
            this.radioButtonWaiting.Size = new System.Drawing.Size(89, 24);
            this.radioButtonWaiting.TabIndex = 18;
            this.radioButtonWaiting.Tag = "B";
            this.radioButtonWaiting.Text = "Bekleyen";
            this.radioButtonWaiting.UseVisualStyleBackColor = true;
            this.radioButtonWaiting.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPassive
            // 
            this.radioButtonPassive.AutoSize = true;
            this.radioButtonPassive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonPassive.ForeColor = System.Drawing.Color.Red;
            this.radioButtonPassive.Location = new System.Drawing.Point(158, 25);
            this.radioButtonPassive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPassive.Name = "radioButtonPassive";
            this.radioButtonPassive.Size = new System.Drawing.Size(59, 24);
            this.radioButtonPassive.TabIndex = 17;
            this.radioButtonPassive.Tag = "P";
            this.radioButtonPassive.Text = "Pasif";
            this.radioButtonPassive.UseVisualStyleBackColor = true;
            this.radioButtonPassive.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonActive.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonActive.Location = new System.Drawing.Point(92, 25);
            this.radioButtonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(59, 24);
            this.radioButtonActive.TabIndex = 16;
            this.radioButtonActive.Tag = "A";
            this.radioButtonActive.Text = "Aktif";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            this.radioButtonActive.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.checkBoxSelectDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxDate.Controls.Add(this.labelStartDate);
            this.groupBoxDate.Controls.Add(this.labelEndDate);
            this.groupBoxDate.Location = new System.Drawing.Point(10, 17);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(605, 59);
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
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(240, 22);
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
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(479, 20);
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
            this.labelStartDate.Location = new System.Drawing.Point(99, 29);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(123, 20);
            this.labelStartDate.TabIndex = 39;
            this.labelStartDate.Text = "Başlangıç Tarihi:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEndDate.Location = new System.Drawing.Point(376, 27);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(85, 20);
            this.labelEndDate.TabIndex = 40;
            this.labelEndDate.Text = "Bitiş Tarihi:";
            // 
            // splitContainerChart
            // 
            this.splitContainerChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChart.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerChart.Location = new System.Drawing.Point(0, 29);
            this.splitContainerChart.Name = "splitContainerChart";
            this.splitContainerChart.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChart.Panel1
            // 
            this.splitContainerChart.Panel1.Controls.Add(this.groupBoxFilters);
            // 
            // splitContainerChart.Panel2
            // 
            this.splitContainerChart.Panel2.Controls.Add(this.labelTitle);
            this.splitContainerChart.Panel2.Controls.Add(this.chart);
            this.splitContainerChart.Size = new System.Drawing.Size(1215, 932);
            this.splitContainerChart.SplitterDistance = 90;
            this.splitContainerChart.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Italic);
            this.labelTitle.Location = new System.Drawing.Point(539, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(24, 21);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "la";
            // 
            // FormCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 961);
            this.Controls.Add(this.splitContainerChart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCharts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.FormCharts_Load);
            this.ResizeEnd += new System.EventHandler(this.FormCharts_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FormCharts_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.splitContainerChart.Panel1.ResumeLayout(false);
            this.splitContainerChart.Panel2.ResumeLayout(false);
            this.splitContainerChart.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChart)).EndInit();
            this.splitContainerChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.CheckBox checkBoxSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.SplitContainer splitContainerChart;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.RadioButton radioButtonWaiting;
        private System.Windows.Forms.RadioButton radioButtonPassive;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonClearGender;
        private System.Windows.Forms.Label labelTitle;
    }
}