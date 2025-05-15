using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IMyContacts repository;
        public int contactID = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new MyContacts();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactID == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else 
            {
                this.Text = "ویرایش شخص";
                DataTable dt = repository.SelectRow(contactID);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtAge.Text= dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtMobile.Text = dt.Rows[0][5].ToString();
                btnSubmit.Text = "ویرایش";
            }
        }
        bool ValidateInputs()
        {
            bool isValid = true;

            if (txtName.Text == "") 
            {
                isValid = false;
                MessageBox.Show("لطفاً نام را وارد کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtFamily.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفاً نام خانوادگی را وارد کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAge.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفاً سن را وارد کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEmail.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفاً ایمیل را وارد کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMobile.Text == "")
            {
                isValid = false;
                MessageBox.Show("لطفاً موبایل را وارد کنید.", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               return isValid; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess;
                if (contactID == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamily.Text, (int)txtAge.Value, txtEmail.Text, txtMobile.Text);
                }
                else 
                {
                    isSuccess = repository.Update(contactID,txtName.Text, txtFamily.Text, (int)txtAge.Value, txtEmail.Text, txtMobile.Text);
                }
                    
                {
                    if (isSuccess == true)
                    {
                        MessageBox.Show("عملیات موفقیت آمیز.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("عملیات با شکست مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
