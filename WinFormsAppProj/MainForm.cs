using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormsAppProj
{
    public partial class MainForm : Form
    {
        AutoShowroom autoShowroom = new AutoShowroom();
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientButtn_Click(object sender, EventArgs e)
        {
            ClientForm NewForm = new ClientForm();
            NewForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }        

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            PasswordForm NewForm = new PasswordForm();
            NewForm.ShowDialog();
            //Controls.Clear();
        }

     
        private void CloseButtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        Point LastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        
    }
}
