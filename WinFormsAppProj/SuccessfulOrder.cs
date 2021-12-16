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
            List<Сustomer> сustomers;
/*            ReadingLists<Сustomer> readingLists = new ReadingLists<Сustomer>();*/
            
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.OpenOrCreate))
            {
                сustomers = (List<Сustomer>)formatter.Deserialize(fs);
            }
            сustomers.Add(сustomer);
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, сustomers);
            }
            /*try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Customers.bin", FileMode.Append)))
                {
                    writer.Write(сustomer.Name);
                    writer.Write(сustomer.Surname);
                    writer.Write(сustomer.Sex);
                    writer.Write(сustomer.PhoneNumber);
                    writer.Write(сustomer.VisitDate.ToString("d"));
                    writer.Write(сustomer.ViewCar.);
                    writer.Write(сustomer.Name);
                    writer.Write(сustomer.Name);
                    writer.Write(сustomer.Name);
                }
            }
            catch (Exception e)
            {

            }*/
            Application.Exit();
        }
    }
}
