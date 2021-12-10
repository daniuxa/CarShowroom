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
    public partial class ListClientForm : Form
    {
        public ListClientForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DetailAuto_Click(object sender, EventArgs e)
        {

        }

        private void ListClientForm_Load(object sender, EventArgs e)
        {
            AddClientToList(ReadingFromFileCustomers);
        }
        private void AddClientToList(EntryList<Сustomer> readingListCustomer)
        {
            List<Сustomer> сustomers = readingListCustomer();
            ListViewItem item = null;
            foreach (var customer in сustomers)
            {
                item = new ListViewItem(new string[] { customer.Name, customer.Surname, customer.Sex, customer.PhoneNumber, customer.VisitDate.ToString("d"), customer.ViewCar.Brand + " " + customer.ViewCar.Model + " " + customer.ViewCar.ProductionYear.ToString()});
                ClientListView.Items.Add(item);
            }
        }
        private List<Сustomer> ReadingFromFileCustomers()
        {
            List<Сustomer> сustomers = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.OpenOrCreate))
            {
                
                сustomers = (List<Сustomer>)formatter.Deserialize(fs);
            }
            return сustomers;
        }
    }
}
