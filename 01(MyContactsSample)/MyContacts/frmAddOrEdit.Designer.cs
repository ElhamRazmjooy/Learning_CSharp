namespace MyContacts
{
    partial class frmAddOrEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Family = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.Mobile);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.Family);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(448, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات فردی:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(349, 68);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(52, 23);
            this.txtAge.TabIndex = 9;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(15, 15);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(148, 23);
            this.txtFamily.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(247, 110);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(143, 23);
            this.txtMobile.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(251, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 5;
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(396, 113);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(46, 16);
            this.Mobile.TabIndex = 4;
            this.Mobile.Text = "موبایل:\r\n";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(255, 66);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "ایمیل:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(407, 70);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(35, 16);
            this.Age.TabIndex = 2;
            this.Age.Text = "سن:";
            // 
            // Family
            // 
            this.Family.AutoSize = true;
            this.Family.Location = new System.Drawing.Point(162, 19);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(83, 16);
            this.Family.TabIndex = 1;
            this.Family.Text = "نام خانوادگی:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(414, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(376, 186);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(70, 50);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 248);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddOrEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Family;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.Button btnSubmit;
    }
}