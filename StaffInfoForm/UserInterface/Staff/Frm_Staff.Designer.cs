namespace StaffInfoForm
{
    partial class Frm_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_staff_info = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HTML = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CSS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DotNet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.JQuery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbDotNet = new System.Windows.Forms.CheckBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbJquery = new System.Windows.Forms.CheckBox();
            this.cbCss = new System.Windows.Forms.CheckBox();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbNRCNo = new System.Windows.Forms.TextBox();
            this.tbStaffName = new System.Windows.Forms.TextBox();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblNRCNo = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSkill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_info)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_staff_info
            // 
            this.dgv_staff_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgv_staff_info.Location = new System.Drawing.Point(-23, 455);
            this.dgv_staff_info.Name = "dgv_staff_info";
            this.dgv_staff_info.RowHeadersWidth = 62;
            this.dgv_staff_info.RowTemplate.Height = 28;
            this.dgv_staff_info.Size = new System.Drawing.Size(728, 150);
            this.dgv_staff_info.TabIndex = 51;
            this.dgv_staff_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_info_CellClick);
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "StaffID";
            this.StaffID.MinimumWidth = 8;
            this.StaffID.Name = "StaffID";
            this.StaffID.Visible = false;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "StaffName";
            this.StaffName.MinimumWidth = 8;
            this.StaffName.Name = "StaffName";
            // 
            // NRCNo
            // 
            this.NRCNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NRCNo.DataPropertyName = "NRCNo";
            this.NRCNo.HeaderText = "NRCNo";
            this.NRCNo.MinimumWidth = 8;
            this.NRCNo.Name = "NRCNo";
            // 
            // DOB
            // 
            this.DOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DOB.DataPropertyName = "DOB";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.DOB.DefaultCellStyle = dataGridViewCellStyle4;
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 8;
            this.DOB.Name = "DOB";
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            // 
            // HTML
            // 
            this.HTML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HTML.DataPropertyName = "HTML";
            this.HTML.HeaderText = "HTML";
            this.HTML.MinimumWidth = 8;
            this.HTML.Name = "HTML";
            this.HTML.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HTML.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CSS
            // 
            this.CSS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSS.DataPropertyName = "CSS";
            this.CSS.HeaderText = "CSS";
            this.CSS.MinimumWidth = 8;
            this.CSS.Name = "CSS";
            this.CSS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DotNet
            // 
            this.DotNet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DotNet.DataPropertyName = "DotNet";
            this.DotNet.HeaderText = "DotNet";
            this.DotNet.MinimumWidth = 8;
            this.DotNet.Name = "DotNet";
            this.DotNet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DotNet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // JQuery
            // 
            this.JQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JQuery.DataPropertyName = "JQuery";
            this.JQuery.HeaderText = "JQuery";
            this.JQuery.MinimumWidth = 8;
            this.JQuery.Name = "JQuery";
            this.JQuery.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(547, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 40);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(547, 228);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 41);
            this.btnNew.TabIndex = 48;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbDotNet
            // 
            this.cbDotNet.AutoSize = true;
            this.cbDotNet.Location = new System.Drawing.Point(392, 409);
            this.cbDotNet.Name = "cbDotNet";
            this.cbDotNet.Size = new System.Drawing.Size(86, 24);
            this.cbDotNet.TabIndex = 46;
            this.cbDotNet.Text = "DotNet";
            this.cbDotNet.UseVisualStyleBackColor = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(185, 171);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(116, 26);
            this.dateOfBirth.TabIndex = 52;
            // 
            // cbJquery
            // 
            this.cbJquery.AutoSize = true;
            this.cbJquery.Location = new System.Drawing.Point(514, 409);
            this.cbJquery.Name = "cbJquery";
            this.cbJquery.Size = new System.Drawing.Size(85, 24);
            this.cbJquery.TabIndex = 47;
            this.cbJquery.Text = "JQuery";
            this.cbJquery.UseVisualStyleBackColor = true;
            // 
            // cbCss
            // 
            this.cbCss.AutoSize = true;
            this.cbCss.Location = new System.Drawing.Point(295, 409);
            this.cbCss.Name = "cbCss";
            this.cbCss.Size = new System.Drawing.Size(68, 24);
            this.cbCss.TabIndex = 45;
            this.cbCss.Text = "CSS";
            this.cbCss.UseVisualStyleBackColor = true;
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Location = new System.Drawing.Point(180, 409);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(78, 24);
            this.cbHtml.TabIndex = 44;
            this.cbHtml.Text = "HTML";
            this.cbHtml.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(316, 344);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 43;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(180, 348);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 42;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
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
            this.cbCity.Location = new System.Drawing.Point(185, 210);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(293, 28);
            this.cbCity.TabIndex = 40;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(343, 168);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(135, 26);
            this.tbAge.TabIndex = 39;
            // 
            // tbNRCNo
            // 
            this.tbNRCNo.Location = new System.Drawing.Point(185, 126);
            this.tbNRCNo.Name = "tbNRCNo";
            this.tbNRCNo.Size = new System.Drawing.Size(293, 26);
            this.tbNRCNo.TabIndex = 38;
            // 
            // tbStaffName
            // 
            this.tbStaffName.Location = new System.Drawing.Point(185, 88);
            this.tbStaffName.Name = "tbStaffName";
            this.tbStaffName.Size = new System.Drawing.Size(293, 26);
            this.tbStaffName.TabIndex = 37;
            // 
            // tbStaffID
            // 
            this.tbStaffID.Location = new System.Drawing.Point(167, -45);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(100, 26);
            this.tbStaffID.TabIndex = 36;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(79, 348);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 35;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(79, 289);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 34;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(79, 218);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 33;
            this.lblCity.Text = "City";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(299, 171);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 32;
            this.lblAge.Text = "Age";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(79, 171);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(44, 20);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Text = "DOB";
            // 
            // lblNRCNo
            // 
            this.lblNRCNo.AutoSize = true;
            this.lblNRCNo.Location = new System.Drawing.Point(79, 132);
            this.lblNRCNo.Name = "lblNRCNo";
            this.lblNRCNo.Size = new System.Drawing.Size(63, 20);
            this.lblNRCNo.TabIndex = 30;
            this.lblNRCNo.Text = "NRCNo";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(79, 94);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(86, 20);
            this.lblStaffName.TabIndex = 29;
            this.lblStaffName.Text = "StaffName";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(72, -45);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(61, 20);
            this.lblStaffID.TabIndex = 28;
            this.lblStaffID.Text = "StaffID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, -83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Staff Information Form";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(185, 44);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(293, 26);
            this.tbID.TabIndex = 55;
            this.tbID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(79, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 20);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "StaffID";
            this.lblID.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Staff Information Form";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(547, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 42);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(547, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 42);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(185, 264);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(298, 59);
            this.tbAddress.TabIndex = 58;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(83, 412);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(45, 20);
            this.lblSkill.TabIndex = 59;
            this.lblSkill.Text = "Skills";
            // 
            // Frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 772);
            this.Controls.Add(this.lblSkill);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_staff_info);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbDotNet);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.cbJquery);
            this.Controls.Add(this.cbCss);
            this.Controls.Add(this.cbHtml);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
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
            this.Name = "Frm_Staff";
            this.Text = "Frm_Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_staff_info;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox cbDotNet;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.CheckBox cbJquery;
        private System.Windows.Forms.CheckBox cbCss;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbNRCNo;
        private System.Windows.Forms.TextBox tbStaffName;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblNRCNo;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HTML;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CSS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DotNet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JQuery;
    }
}