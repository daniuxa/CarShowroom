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
        private List<Сustomer> сustomers;
        private ReadingLists<Сustomer> readingLists;
        public ListClientForm()
        {
            InitializeComponent();
            readingLists = new ReadingLists<Сustomer>();
            readingLists.ChangeFilePath("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin");
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
            AddClientToList(readingLists.FromFile);
        }
        private void AddClientToList(EntryList<Сustomer> readingListCustomer)
        {
            SortedList<string, Сustomer> SortedCustomers = new SortedList<string, Сustomer>();
            сustomers = readingListCustomer();
            for (int i = 0; i < сustomers.Count; i++)
            {
                SortedCustomers.Add(сustomers[i].Name + " " + сustomers[i].Surname, сustomers[i]);
            }
            ListViewItem item = null;
            foreach (var customer in SortedCustomers)
            {
                item = new ListViewItem(new string[] { customer.Value.Name, customer.Value.Surname, customer.Value.Sex, customer.Value.PhoneNumber, customer.Value.VisitDate.ToString("d"), customer.Value.ViewCar.Brand + " " + customer.Value.ViewCar.Model + " " + customer.Value.ViewCar.ProductionYear.ToString()});
                ClientListView.Items.Add(item);
            }
        }
        /*private List<Сustomer> ReadingFromFileCustomers()
        {
            List<Сustomer> сustomers = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.OpenOrCreate))
            {
                
                сustomers = (List<Сustomer>)formatter.Deserialize(fs);
            }
            return сustomers;
        }*/

        private void ClientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientListView.SelectedItems.Count == 1)
            {
                ConfirmationForm Form = new ConfirmationForm();
                Car car;
                car = сustomers[ClientListView.SelectedItems[0].Index].ViewCar;
                Form.SearchCar = car;
                Form.label1.Visible = false;
                Form.YesButtn.Visible = false;
                Form.NoButtn.Visible = false;
                Form.ShowDialog();
            }
        }
    }
}
