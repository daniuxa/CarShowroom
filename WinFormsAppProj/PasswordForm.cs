using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProj
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void OkButtn_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "1111")
            {
                this.Close();
                MessageBox.Show("Admin Form");             
            }
            else
            {
                MessageBox.Show("Неправильний пароль");
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            //this.PasswordBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyUp);
        }
        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            /*if (e.KeyValue == 13)
            {
                OkButtn_Click(sender, e);
            } */
            if (e.KeyCode == Keys.Enter)
            {
                OkButtn_Click(sender, e);
            }
        }
    }
}
