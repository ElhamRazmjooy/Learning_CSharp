
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
       Contact_DBEntities db = new Contact_DBEntities();
        public int contactID = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
           
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
                MyContact contact = db.MyContacts.Find(contactID);
                txtName.Text = contact.Name;
                txtFamily.Text = contact.Family;
                txtAge.Text= contact.Age.ToString();
                txtEmail.Text = contact.Email;
                txtMobile.Text = contact.Mobile;
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
                
                if (contactID == 0)
                {
                    MyContact contact = new MyContact();
                    contact.Name = txtName.Text;
                    contact.Family = txtFamily.Text;
                    contact.Age = (int)txtAge.Value;
                    contact.Email = txtEmail.Text;
                    contact.Mobile = txtMobile.Text;
                    db.MyContacts.Add(contact);
                }
                else 
                {
                    var contact = db.MyContacts.Find(contactID);
                    contact.Name = txtName.Text;
                    contact.Family = txtFamily.Text;
                    contact.Age = (int)txtAge.Value;
                    contact.Email = txtEmail.Text;
                    contact.Mobile = txtMobile.Text;
                }
                db.SaveChanges();  
                MessageBox.Show("عملیات موفقیت آمیز.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                   
                
            }
        }
    }
}
