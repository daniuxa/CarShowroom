using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProj
{
    public partial class SuccessfulOrder : Form
    {
        public Person person { get; set; }
        Сustomer сustomer;
        public SuccessfulOrder()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point LastPoint;

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void SuccessfulOrder_Load(object sender, EventArgs e)
        {
            сustomer = person as Сustomer;
            CustomerName.Text += сustomer.Name;
            Surname.Text += сustomer.Surname;
            Sex.Text += сustomer.Sex;
            Phone.Text += сustomer.PhoneNumber;
            VisitDate.Text += сustomer.VisitDate.ToString("d");
        }

        private void OKButtn_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, сustomer);
            }
            Application.Exit();
        }
    }
}
