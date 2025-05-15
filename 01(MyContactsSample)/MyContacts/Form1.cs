using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyContacts
{
    public partial class Form1 : Form
    {
        IMyContacts repository;
        public Form1()
        {
            InitializeComponent();
            repository = new MyContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) 
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Name = dgContacts.CurrentRow.Cells[1].Value.ToString();
            string Family =dgContacts.CurrentRow.Cells [2].Value.ToString();
            string Fullname = Name + " " + Family;
            if (dgContacts.CurrentRow != null)
            {
                if (MessageBox.Show($"{Fullname} حذف شود؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    int ContactID = int.Parse(dgContacts.CurrentRow.Cells [0].Value.ToString());   
                    repository.delete(ContactID);
                    BindGrid();
                }
            }
            else 
            {
                MessageBox.Show("لطفاً یک شخص را انتخاب کنید","اخطار",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null) 
            {
                int contactID = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.contactID = contactID;
                if (frm.ShowDialog() == DialogResult.OK)
                { 
                    BindGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
         dgContacts.DataSource =repository.Search(txtSearch.Text);
        }
    }
}
