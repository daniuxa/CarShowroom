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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        /*private void WorkersButtn_Click(object sender, EventArgs e)
        {
            List<Car> Cars = new List<Car>()
            {
                new LightCar("Toyota", "Corolla", 2018, 14450, new FstType(), "Седан", 180),
                new LightCar("Toyota", "Camry", 2018, 30000, new SecondType(), "Седан", 250),
                new LightCar("Toyota", "RAV 4", 2016, 23000, new SecondType(), "Кросовер", 185),
                new LightCar("Mercedez-Benz", "A-Class", 2009, 6200, new SecondType(), "Хетчбек", 220),
                new LightCar("Mercedez-Benz", "S-Class", 2021, 150000, new SecondType(), "Седан", 250),
                new LightCar("Mercedez-Benz", "G-Class", 2013, 68000, new SecondType(), "Кросовер", 200),
                new LightCar("BMW", "5 Series", 2015, 17000, new SecondType(), "Седан", 220),
                new LightCar("BMW", "1 Series", 2015, 25000, new FstType(), "Хетчбек", 190),
                new LightCar("BMW", "X5", 2002, 8000, new SecondType(), "Кросовер", 180),
                new LightCar("Honda", "CRV", 2008, 11000, new SecondType(), "Кросовер", 200),
                new LightCar("Honda", "Accord", 2013, 12000, new SecondType(), "Седан", 190),
                new LightCar("Honda", "Civic", 2008, 7500, new FstType(), "Хетчбек", 170),
                new LightCar("Volkswagen", "Polo", 2003, 5000, new FstType(), "Хетчбек", 160),
                new LightCar("Volkswagen", "Passat", 2006, 8500, new SecondType(), "Седан", 180),
                new LightCar("Volkswagen", "Touareg", 2009, 17000, new SecondType(), "Кросовер", 200),
                new LightCar("Ford", "Focus", 2017, 9900, new FstType(), "Хетчбек", 160),
                new LightCar("Ford", "Kuga", 2011, 13500, new SecondType(), "Кросовер", 180),
                new LightCar("Ford", "Mondeo", 2008, 6500, new FstType(), "Седан", 180),
                new LightCar("Hyundai", "Sonata", 2017, 18000, new FstType(), "Седан", 190),
                new LightCar("Hyundai", "Solaris", 2011, 6500, new FstType(), "Седан", 170),
                new LightCar("Hyundai", "Santa Fe", 2013, 18000, new SecondType(), "Кросовер", 200),
                new LightCar("Audi", "A3", 2015, 18000, new FstType(), "Седан", 180),
                new LightCar("Audi", "A6", 2005, 8500, new SecondType(), "Седан", 220),
                new LightCar("Audi", "Q5", 2013, 16000, new SecondType(), "Кросовер", 200),
                new LightCar("Skoda", "Octavia", 2009, 8000, new FstType(), "Седан", 180),
                new LightCar("Skoda", "Fabia", 2006, 5000, new SecondType(), "Хетчбек", 160),
                new LightCar("Skoda", "Yeti", 2011, 9000, new FstType(), "Кросовер", 170),
                new LightCar("Nissan", "Almera", 2011, 7000, new FstType(), "Седан", 170),
                new LightCar("Nissan", "Qashqai", 2010, 11500, new SecondType(), "Кросовер", 180),
                new LightCar("Nissan", "Tilda", 2006, 8000, new FstType(), "Хетчбек", 160),
                new Truck("Mercedez-Benz", "Actros", 2015, 50000, new TrdType(), 2000000, 2),
                new Truck("Mercedez-Benz", "Arocs", 2020, 155000, new TrdType(), 2000000, 4),
                new Truck("Mercedez-Benz", "Atego", 2016, 30000, new TrdType(), 2000000, 2),
                new Truck("Volvo", "FH16", 2010, 30000, new TrdType(), 2000000, 2),
                new Truck("Volvo", "FL7", 1994, 10000, new TrdType(), 2000000, 2),
                new Truck("Volvo", "FM", 2008, 21000, new TrdType(), 2000000, 3),
                new Truck("Iveco", "EuroCargo", 2011, 32000, new TrdType(), 2000000, 3),
                new Truck("Iveco", "Stralis", 2008, 10000, new TrdType(), 2000000, 2),
                new Truck("Iveco", "Trakker", 2007, 47000, new TrdType(), 2000000, 4),
                new Truck("MAN", "TGX", 2012, 20000, new TrdType(), 2000000, 2),
                new Truck("MAN", "eTGM", 2015, 50000, new TrdType(), 2000000, 3),
                new Truck("MAN", "TGS", 2012, 50000, new TrdType(), 2000000, 3),
                new Truck("Scania", "P380", 2014, 50000, new TrdType(), 2000000, 3),
                new Truck("Scania", "P280", 2007, 20000, new TrdType(), 2000000, 4),
                new Truck("Scania", "Odin S G410", 2011, 46000, new TrdType(), 2000000, 3)
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Cars);
            }         
        }*/

        private void CarsButtn_Click(object sender, EventArgs e)
        {
            AdminCarListForm form = new AdminCarListForm();
            form.ShowDialog();
        }

        private void CustomersButtn_Click(object sender, EventArgs e)
        {
            ListClientForm form = new ListClientForm();
            form.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
