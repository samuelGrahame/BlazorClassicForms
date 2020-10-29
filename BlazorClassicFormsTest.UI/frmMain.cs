using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlazorClassicFormsTest.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter in a username!");
                txtUsername.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter in a password!");
                txtPassword.Focus();
                return;
            }

            MessageBox.Show("No Server Access!");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPassword.Element.setAttribute("placeholder", "password");
            txtUsername.Element.setAttribute("placeholder", "username");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var x = new frmDockingTest();
            x.Show();
        }
    }
}
