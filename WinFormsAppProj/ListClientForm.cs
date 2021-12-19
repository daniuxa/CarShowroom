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
        private InAndOutputLists<Сustomer> readingLists;
        public ListClientForm()
        {
            InitializeComponent();
            readingLists = new InAndOutputLists<Сustomer>();
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
            AddClientToList(readingLists.ReadingFromFile);
        }
        private void AddClientToList(EntryList<Сustomer> readingListCustomer)
        {
            SortedList<string, Сustomer> SortedCustomers = new SortedList<string, Сustomer>();
            try
            {
                сustomers = readingListCustomer();
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");             
            }
            /*for (int i = 0; i < сustomers.Count; i++)
            {
                SortedCustomers.Add(сustomers[i].Name + " " + сustomers[i].Surname, сustomers[i]);
            }*/
            ListViewItem item = null;
            foreach (var customer in сustomers)
            {
                item = new ListViewItem(new string[] { customer.Name, customer.Surname, customer.Sex, customer.PhoneNumber, customer.VisitDate.ToString("d"), customer.ViewCar.Brand + " " + customer.ViewCar.Model + " " + customer.ViewCar.ProductionYear.ToString()});
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
            
        }

        private void DetailInfoButton_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Виберіть хоча б один автомобіль");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Сustomer сustomerToDel;
            if (ClientListView.SelectedItems.Count == 1)
            {
                сustomerToDel = сustomers[ClientListView.SelectedItems[0].Index];
                сustomers.Remove(сustomerToDel);

                ClientListView.Items.Clear();
                ListViewItem item = null;
                foreach (var customer in сustomers)
                {
                    item = new ListViewItem(new string[] { customer.Name, customer.Surname, customer.Sex, customer.PhoneNumber, customer.VisitDate.ToString("d"), customer.ViewCar.Brand + " " + customer.ViewCar.Model + " " + customer.ViewCar.ProductionYear.ToString() });
                    ClientListView.Items.Add(item);
                }
                try
                {
                    readingLists.WritingToFile(сustomers);
                }
                catch (FileException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");
                    throw;
                }
            }
        }
    }
}
