namespace StaffInfoForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.tbNRCNo = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.cbCss = new System.Windows.Forms.CheckBox();
            this.cbDotNet = new System.Windows.Forms.CheckBox();
            this.cbJquery = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgv_staff_info = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DotNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information Form";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(208, 51);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(61, 20);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "StaffID";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(208, 81);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(86, 20);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "StaffName";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Location = new System.Drawing.Point(208, 117);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(63, 20);
            this.lblNRCNo.TabIndex = 3;
            this.lblNRCNo.Text = "NRCNo";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(208, 154);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(44, 20);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "DOB";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(208, 202);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(208, 241);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(208, 279);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(208, 328);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(303, 51);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(100, 26);
            this.tbStaffID.TabIndex = 9;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(303, 83);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(100, 26);
            this.tbStaffName.TabIndex = 10;
            // 
            // tbNRCNo
            // 
            this.tbNRCNo.Location = new System.Drawing.Point(303, 115);
            this.tbNRCNo.Name = "tbNRCNo";
            this.tbNRCNo.Size = new System.Drawing.Size(100, 26);
            this.tbNRCNo.TabIndex = 11;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(303, 196);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 26);
            this.tbAge.TabIndex = 13;
            // 
            // cbCity
            // 
            this.cbCity.DisplayMember = "None";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Bagan",
            "Mandalay",
            "Sagaing",
            "Pyin Oo Lwin",
            "Taungyi"});
            this.cbCity.Location = new System.Drawing.Point(303, 233);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 28);
            this.cbCity.TabIndex = 14;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(303, 273);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 26);
            this.tbAddress.TabIndex = 15;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(308, 324);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(461, 324);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Location = new System.Drawing.Point(303, 367);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(78, 24);
            this.cbHtml.TabIndex = 18;
            this.cbHtml.Text = "HTML";
            this.cbHtml.UseVisualStyleBackColor = true;
            // 
            // cbCss
            // 
            this.cbCss.AutoSize = true;
            this.cbCss.Location = new System.Drawing.Point(433, 367);
            this.cbCss.Name = "cbCss";
            this.cbCss.Size = new System.Drawing.Size(68, 24);
            this.cbCss.TabIndex = 19;
            this.cbCss.Text = "CSS";
            this.cbCss.UseVisualStyleBackColor = true;
            // 
            // cbDotNet
            // 
            this.cbDotNet.AutoSize = true;
            this.cbDotNet.Location = new System.Drawing.Point(567, 367);
            this.cbDotNet.Name = "cbDotNet";
            this.cbDotNet.Size = new System.Drawing.Size(86, 24);
            this.cbDotNet.TabIndex = 20;
            this.cbDotNet.Text = "DotNet";
            this.cbDotNet.UseVisualStyleBackColor = true;
            // 
            // cbJquery
            // 
            this.cbJquery.AutoSize = true;
            this.cbJquery.Location = new System.Drawing.Point(703, 367);
            this.cbJquery.Name = "cbJquery";
            this.cbJquery.Size = new System.Drawing.Size(85, 24);
            this.cbJquery.TabIndex = 21;
            this.cbJquery.Text = "JQuery";
            this.cbJquery.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 32);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgv_staff_info
            // 
            this.dgv_staff_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_staff_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.NRCNo,
            this.DOB,
            this.Age,
            this.City,
            this.Address,
            this.Gender,
            this.HTML,
            this.CSS,
            this.DotNet,
            this.JQuery});
            this.dgv_staff_info.Location = new System.Drawing.Point(12, 479);
            this.dgv_staff_info.Name = "dgv_staff_info";
            this.dgv_staff_info.RowHeadersWidth = 62;
            this.dgv_staff_info.RowTemplate.Height = 28;
            this.dgv_staff_info.Size = new System.Drawing.Size(1048, 150);
            this.dgv_staff_info.TabIndex = 25;
            this.dgv_staff_info.Click += new System.EventHandler(this.dgv_staff_info_Click);
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.MinimumWidth = 8;
            this.StaffID.Name = "StaffID";
            // 
            // StaffName
            // 
            this.StaffName.HeaderText = "StaffName";
            this.StaffName.MinimumWidth = 8;
            this.StaffName.Name = "StaffName";
            this.StaffName.Width = 122;
            // 
            // NRCNo
            // 
            this.NRCNo.HeaderText = "NRCNo";
            this.NRCNo.MinimumWidth = 8;
            this.NRCNo.Name = "NRCNo";
            this.NRCNo.Width = 99;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 8;
            this.DOB.Name = "DOB";
            this.DOB.Width = 80;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 74;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.Width = 71;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 104;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.Width = 99;
            // 
            // HTML
            // 
            this.HTML.HeaderText = "HTML";
            this.HTML.MinimumWidth = 8;
            this.HTML.Name = "HTML";
            this.HTML.Width = 88;
            // 
            // CSS
            // 
            this.CSS.HeaderText = "CSS";
            this.CSS.MinimumWidth = 8;
            this.CSS.Name = "CSS";
            this.CSS.Width = 78;
            // 
            // DotNet
            // 
            this.DotNet.HeaderText = "DotNet";
            this.DotNet.MinimumWidth = 8;
            this.DotNet.Name = "DotNet";
            this.DotNet.Width = 96;
            // 
            // JQuery
            // 
            this.JQuery.HeaderText = "JQuery";
            this.JQuery.MinimumWidth = 8;
            this.JQuery.Name = "JQuery";
            this.JQuery.Width = 95;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(303, 154);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dateOfBirth.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 667);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.dgv_staff_info);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbJquery);
            this.Controls.Add(this.cbDotNet);
            this.Controls.Add(this.cbCss);
            this.Controls.Add(this.cbHtml);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbNRCNo);
            this.Controls.Add(this.tbStaffName);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblNRCNo);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.TextBox tbNRCNo;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.CheckBox cbCss;
        private System.Windows.Forms.CheckBox cbDotNet;
        private System.Windows.Forms.CheckBox cbJquery;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgv_staff_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn HTML;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DotNet;
        private System.Windows.Forms.DataGridViewTextBoxColumn JQuery;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

