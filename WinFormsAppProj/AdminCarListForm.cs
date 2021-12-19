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
    public partial class AdminCarListForm : Form
    {
        List<Car> cars;
        private InAndOutputLists<Car> inAndOutputLists;
        public AdminCarListForm()
        {
            InitializeComponent();
            inAndOutputLists = new InAndOutputLists<Car>();
            inAndOutputLists.ChangeFilePath("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin");
        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point LastPoint;
        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TopBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void AdminCarListForm_Load(object sender, EventArgs e)
        {
            AddCarToList(inAndOutputLists.ReadingFromFile);
        }
        private void AddCarToList(EntryList<Car> readingListCar)
        {
            try
            {
                cars = readingListCar();
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");
                throw;
            }
  
            ListViewItem item = null;
            foreach (var Car in cars)
            {
                item = new ListViewItem(new string[] { Car.GetType().Name == "LightCar" ? "Легковий автомобіль" : "Вантажівка", Car.Brand, Car.Model, Convert.ToString(Car.ProductionYear), Convert.ToString(Car.Price), Car.Engine.Type, Convert.ToString(Car.Engine.Power), Convert.ToString(Car.Engine.Volume) });
                CarListView.Items.Add(item);
            }
        }
        /*private List<Car> ReadingFromFileCars()
        {
            List<Car> cars = null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin", FileMode.OpenOrCreate))
            {
                cars = (List<Car>)formatter.Deserialize(fs);
            }
            return cars;
        }*/

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AddCarToList form = new AddCarToList();
            form.cars = cars;
            this.Visible = false;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<Car> carsSorted;
            carsSorted = cars;
            cars.Sort();
            CarListView.Items.Clear();
            ListViewItem item = null;
            foreach (var Car in cars)
            {
                item = new ListViewItem(new string[] { Car.GetType().Name == "LightCar" ? "Легковий автомобіль" : "Вантажівка", Car.Brand, Car.Model, Convert.ToString(Car.ProductionYear), Convert.ToString(Car.Price), Car.Engine.Type, Convert.ToString(Car.Engine.Power), Convert.ToString(Car.Engine.Volume) });
                CarListView.Items.Add(item);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Car carToDel;
            if (CarListView.SelectedItems.Count == 1)
            {
                carToDel = cars[CarListView.SelectedItems[0].Index];
                cars.Remove(carToDel);
                CarListView.Items.Clear();
                ListViewItem item = null;
                foreach (var Car in cars)
                {
                    item = new ListViewItem(new string[] { Car.GetType().Name == "LightCar" ? "Легковий автомобіль" : "Вантажівка", Car.Brand, Car.Model, Convert.ToString(Car.ProductionYear), Convert.ToString(Car.Price), Car.Engine.Type, Convert.ToString(Car.Engine.Power), Convert.ToString(Car.Engine.Volume) });
                    CarListView.Items.Add(item);
                }
                try
                {
                    inAndOutputLists.WritingToFile(cars);
                }
                catch (FileException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");
                }
            }
        }

        private void ExtraInfoButton_Click(object sender, EventArgs e)
        {
            if (CarListView.SelectedItems.Count == 1)
            {
                Car car;
                car = cars[CarListView.SelectedItems[0].Index];
                ConfirmationForm Form = new ConfirmationForm();
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
    }
}
