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
            this.groupBoxPersonel = new System.Windows.Forms.GroupBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.listViewPersonels = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegisterDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxRegister = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelPersonelType = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxPersonelType = new System.Windows.Forms.ComboBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelBranch = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.columnHeaderBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxPersonel.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPersonel.Controls.Add(this.groupBoxList);
            this.groupBoxPersonel.Controls.Add(this.groupBoxRegister);
            this.groupBoxPersonel.Location = new System.Drawing.Point(17, 17);
            this.groupBoxPersonel.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPersonel.Size = new System.Drawing.Size(652, 555);
            this.groupBoxPersonel.TabIndex = 0;
            this.groupBoxPersonel.TabStop = false;
            this.groupBoxPersonel.Text = "Personel";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.Controls.Add(this.listViewPersonels);
            this.groupBoxList.Location = new System.Drawing.Point(8, 259);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(636, 289);
            this.groupBoxList.TabIndex = 21;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Liste";
            // 
            // listViewPersonels
            // 
            this.listViewPersonels.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listViewPersonels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderPhone,
            this.columnHeaderType,
            this.columnHeaderBranch,
            this.columnHeaderRegisterDate});
            this.listViewPersonels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPersonels.FullRowSelect = true;
            this.listViewPersonels.HideSelection = false;
            this.listViewPersonels.Location = new System.Drawing.Point(3, 23);
            this.listViewPersonels.Name = "listViewPersonels";
            this.listViewPersonels.Size = new System.Drawing.Size(630, 263);
            this.listViewPersonels.TabIndex = 0;
            this.listViewPersonels.UseCompatibleStateImageBehavior = false;
            this.listViewPersonels.View = System.Windows.Forms.View.Details;
            this.listViewPersonels.Click += new System.EventHandler(this.listViewPersonels_Click);
            this.listViewPersonels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewPersonels_Key);
            this.listViewPersonels.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewPersonels_Key);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Adı";
            this.columnHeaderName.Width = 110;
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Soyadı";
            this.columnHeaderSurname.Width = 110;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Telefon";
            this.columnHeaderPhone.Width = 100;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Tipi";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderRegisterDate
            // 
            this.columnHeaderRegisterDate.Text = "Kayıt Tarihi";
            this.columnHeaderRegisterDate.Width = 100;
            // 
            // groupBoxRegister
            // 
            this.groupBoxRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegister.Controls.Add(this.labelBranch);
            this.groupBoxRegister.Controls.Add(this.comboBoxBranch);
            this.groupBoxRegister.Controls.Add(this.textBoxId);
            this.groupBoxRegister.Controls.Add(this.buttonOrder);
            this.groupBoxRegister.Controls.Add(this.labelName);
            this.groupBoxRegister.Controls.Add(this.buttonClear);
            this.groupBoxRegister.Controls.Add(this.labelSurname);
            this.groupBoxRegister.Controls.Add(this.buttonDelete);
            this.groupBoxRegister.Controls.Add(this.labelPhone);
            this.groupBoxRegister.Controls.Add(this.buttonUpdate);
            this.groupBoxRegister.Controls.Add(this.labelPersonelType);
            this.groupBoxRegister.Controls.Add(this.buttonSearch);
            this.groupBoxRegister.Controls.Add(this.labelId);
            this.groupBoxRegister.Controls.Add(this.buttonRegister);
            this.groupBoxRegister.Controls.Add(this.textBoxName);
            this.groupBoxRegister.Controls.Add(this.comboBoxPersonelType);
            this.groupBoxRegister.Controls.Add(this.textBoxSurname);
            this.groupBoxRegister.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxRegister.Location = new System.Drawing.Point(7, 20);
            this.groupBoxRegister.Name = "groupBoxRegister";
            this.groupBoxRegister.Size = new System.Drawing.Size(637, 232);
            this.groupBoxRegister.TabIndex = 20;
            this.groupBoxRegister.TabStop = false;
            this.groupBoxRegister.Text = "Kayıt";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.textBoxId.Location = new System.Drawing.Point(126, 24);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 27);
            this.textBoxId.TabIndex = 5;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Silver;
            this.buttonOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonOrder.Location = new System.Drawing.Point(473, 91);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(149, 41);
            this.buttonOrder.TabIndex = 18;
            this.buttonOrder.Text = "Listele";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 61);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Adı:";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Silver;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(473, 139);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(149, 41);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Temizleme";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(13, 95);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 20);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Soyadı:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Silver;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(303, 139);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 41);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Sil";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(13, 129);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(63, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Telefon:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Silver;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(303, 91);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 41);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelPersonelType
            // 
            this.labelPersonelType.AutoSize = true;
            this.labelPersonelType.Location = new System.Drawing.Point(13, 163);
            this.labelPersonelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonelType.Name = "labelPersonelType";
            this.labelPersonelType.Size = new System.Drawing.Size(100, 20);
            this.labelPersonelType.TabIndex = 3;
            this.labelPersonelType.Text = "Personel Tipi:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Silver;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(473, 43);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 41);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Bul";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 27);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 20);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Silver;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(303, 43);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(149, 41);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Kaydet";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.textBoxName.Location = new System.Drawing.Point(126, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(157, 27);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // comboBoxPersonelType
            // 
            this.comboBoxPersonelType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.comboBoxPersonelType.FormattingEnabled = true;
            this.comboBoxPersonelType.Items.AddRange(new object[] {
            "Seçiniz",
            "Personel",
            "Antrenör",
            "Öğretmen"});
            this.comboBoxPersonelType.Location = new System.Drawing.Point(126, 160);
            this.comboBoxPersonelType.Name = "comboBoxPersonelType";
            this.comboBoxPersonelType.Size = new System.Drawing.Size(157, 28);
            this.comboBoxPersonelType.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.textBoxSurname.Location = new System.Drawing.Point(126, 92);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(157, 27);
            this.textBoxSurname.TabIndex = 7;
            this.textBoxSurname.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.maskedTextBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(126, 126);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPhone.Mask = "0000000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.PromptChar = ' ';
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(157, 27);
            this.maskedTextBoxPhone.TabIndex = 8;
            this.maskedTextBoxPhone.Enter += new System.EventHandler(this.textBox_Enter);
            this.maskedTextBoxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.maskedTextBoxPhone.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(13, 197);
            this.labelBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(51, 20);
            this.labelBranch.TabIndex = 20;
            this.labelBranch.Text = "Branş:";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(126, 195);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(157, 28);
            this.comboBoxBranch.TabIndex = 21;
            // 
            // columnHeaderBranch
            // 
            this.columnHeaderBranch.Text = "Branş";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(685, 588);
            this.Controls.Add(this.groupBoxPersonel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.groupBoxPersonel.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxRegister.ResumeLayout(false);
            this.groupBoxRegister.PerformLayout();
            this.ResumeLayout(false);

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
    }
}