﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "JafarYaghoubi".ToLower();
            string password = "1340";

            string UserName = txtusername.Text;
            string Password = txtpassword.Text;
            if (UserName == username && Password == password)
            {
                MessageBox.Show("WELCOME");
            }
            else 
            {
                MessageBox.Show("YOU ARE NOT LOGGED IN.");
            }
        }


    }
}
