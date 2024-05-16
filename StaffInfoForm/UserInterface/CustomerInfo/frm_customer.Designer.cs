namespace StaffInfoForm.UserInterface.CustomerInfo
{
    partial class frm_customer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusEmail = new System.Windows.Forms.Label();
            this.lblCusCity = new System.Windows.Forms.Label();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.tbCsuID = new System.Windows.Forms.TextBox();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.tbCusEmail = new System.Windows.Forms.TextBox();
            this.tbCusAddress = new System.Windows.Forms.TextBox();
            this.cbCusCity = new System.Windows.Forms.ComboBox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.tbCusPhoneno = new System.Windows.Forms.TextBox();
            this.btnCusSave = new System.Windows.Forms.Button();
            this.btnCusDelete = new System.Windows.Forms.Button();
            this.btnCusNew = new System.Windows.Forms.Button();
            this.btnCusClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitle.Location = new System.Drawing.Point(238, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Detail Form";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(545, 66);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 20);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID";
            this.lblCustomerID.Visible = false;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(88, 67);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(124, 20);
            this.lblCusName.TabIndex = 2;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblCusEmail
            // 
            this.lblCusEmail.AutoSize = true;
            this.lblCusEmail.Location = new System.Drawing.Point(88, 117);
            this.lblCusEmail.Name = "lblCusEmail";
            this.lblCusEmail.Size = new System.Drawing.Size(48, 20);
            this.lblCusEmail.TabIndex = 3;
            this.lblCusEmail.Text = "Email";
            // 
            // lblCusCity
            // 
            this.lblCusCity.AutoSize = true;
            this.lblCusCity.Location = new System.Drawing.Point(88, 226);
            this.lblCusCity.Name = "lblCusCity";
            this.lblCusCity.Size = new System.Drawing.Size(35, 20);
            this.lblCusCity.TabIndex = 5;
            this.lblCusCity.Text = "City";
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Location = new System.Drawing.Point(88, 270);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(68, 20);
            this.lblCusAddress.TabIndex = 6;
            this.lblCusAddress.Text = "Address";
            // 
            // tbCsuID
            // 
            this.tbCsuID.Location = new System.Drawing.Point(669, 60);
            this.tbCsuID.Name = "tbCsuID";
            this.tbCsuID.Size = new System.Drawing.Size(100, 26);
            this.tbCsuID.TabIndex = 10;
            this.tbCsuID.Visible = false;
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(230, 67);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(262, 26);
            this.tbCusName.TabIndex = 11;
            // 
            // tbCusEmail
            // 
            this.tbCusEmail.Location = new System.Drawing.Point(230, 117);
            this.tbCusEmail.Name = "tbCusEmail";
            this.tbCusEmail.Size = new System.Drawing.Size(262, 26);
            this.tbCusEmail.TabIndex = 12;
            // 
            // tbCusAddress
            // 
            this.tbCusAddress.Location = new System.Drawing.Point(230, 267);
            this.tbCusAddress.Multiline = true;
            this.tbCusAddress.Name = "tbCusAddress";
            this.tbCusAddress.Size = new System.Drawing.Size(262, 68);
            this.tbCusAddress.TabIndex = 13;
            // 
            // cbCusCity
            // 
            this.cbCusCity.FormattingEnabled = true;
            this.cbCusCity.Items.AddRange(new object[] {
            "Yangon",
            "Mandalay",
            "Bamaw",
            "Kawlin",
            "Pyin Oo Lwin",
            "Monywa",
            "Sagaing"});
            this.cbCusCity.Location = new System.Drawing.Point(230, 226);
            this.cbCusCity.Name = "cbCusCity";
            this.cbCusCity.Size = new System.Drawing.Size(262, 28);
            this.cbCusCity.TabIndex = 14;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Location = new System.Drawing.Point(88, 174);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(83, 20);
            this.lblCusPhone.TabIndex = 16;
            this.lblCusPhone.Text = "Phnoe No.";
            // 
            // tbCusPhoneno
            // 
            this.tbCusPhoneno.Location = new System.Drawing.Point(230, 171);
            this.tbCusPhoneno.Name = "tbCusPhoneno";
            this.tbCusPhoneno.Size = new System.Drawing.Size(262, 26);
            this.tbCusPhoneno.TabIndex = 17;
            // 
            // btnCusSave
            // 
            this.btnCusSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCusSave.Location = new System.Drawing.Point(549, 108);
            this.btnCusSave.Name = "btnCusSave";
            this.btnCusSave.Size = new System.Drawing.Size(131, 44);
            this.btnCusSave.TabIndex = 18;
            this.btnCusSave.Text = "Save";
            this.btnCusSave.UseVisualStyleBackColor = false;
            this.btnCusSave.Click += new System.EventHandler(this.btnCusSave_Click);
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.BackColor = System.Drawing.Color.Red;
            this.btnCusDelete.Location = new System.Drawing.Point(549, 160);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(129, 48);
            this.btnCusDelete.TabIndex = 19;
            this.btnCusDelete.Text = "Delete";
            this.btnCusDelete.UseVisualStyleBackColor = false;
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // btnCusNew
            // 
            this.btnCusNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCusNew.Location = new System.Drawing.Point(549, 226);
            this.btnCusNew.Name = "btnCusNew";
            this.btnCusNew.Size = new System.Drawing.Size(127, 49);
            this.btnCusNew.TabIndex = 20;
            this.btnCusNew.Text = "New";
            this.btnCusNew.UseVisualStyleBackColor = false;
            // 
            // btnCusClose
            // 
            this.btnCusClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCusClose.Location = new System.Drawing.Point(547, 291);
            this.btnCusClose.Name = "btnCusClose";
            this.btnCusClose.Size = new System.Drawing.Size(129, 44);
            this.btnCusClose.TabIndex = 21;
            this.btnCusClose.Text = "Close";
            this.btnCusClose.UseVisualStyleBackColor = false;
            this.btnCusClose.Click += new System.EventHandler(this.btnCusClose_Click);
            // 
            // frm_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCusClose);
            this.Controls.Add(this.btnCusNew);
            this.Controls.Add(this.btnCusDelete);
            this.Controls.Add(this.btnCusSave);
            this.Controls.Add(this.tbCusPhoneno);
            this.Controls.Add(this.lblCusPhone);
            this.Controls.Add(this.cbCusCity);
            this.Controls.Add(this.tbCusAddress);
            this.Controls.Add(this.tbCusEmail);
            this.Controls.Add(this.tbCusName);
            this.Controls.Add(this.tbCsuID);
            this.Controls.Add(this.lblCusAddress);
            this.Controls.Add(this.lblCusCity);
            this.Controls.Add(this.lblCusEmail);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblTitle);
            this.Name = "frm_customer";
            this.Text = "frm_customer";
            this.Load += new System.EventHandler(this.frm_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusEmail;
        private System.Windows.Forms.Label lblCusCity;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.TextBox tbCsuID;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.TextBox tbCusEmail;
        private System.Windows.Forms.TextBox tbCusAddress;
        private System.Windows.Forms.ComboBox cbCusCity;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.TextBox tbCusPhoneno;
        private System.Windows.Forms.Button btnCusSave;
        private System.Windows.Forms.Button btnCusDelete;
        private System.Windows.Forms.Button btnCusNew;
        private System.Windows.Forms.Button btnCusClose;
    }
}