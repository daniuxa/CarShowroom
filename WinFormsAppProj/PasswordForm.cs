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
           /* if (e.KeyValue == 13)
            {
                OkButtn_Click(sender, e);
            }*/
            if (e.KeyCode == Keys.Enter)
            {
                OkButtn_Click(sender, e);
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            //OkButtn_Click(sender, e);
          
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

   

        Point LastPoint;
        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
