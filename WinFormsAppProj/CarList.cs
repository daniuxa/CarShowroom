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
    delegate bool Compare();
    public partial class CarList : Form
    {
        public AutoShowroom autoShowroom { get; set; }
        private List<Car> autoShowroomFiltred;
        public Car carFrom { get; set; }
        public Car carTo { get; set; }
        /*public CarList(Car carFrom, Car carTo)
        {
            this.carFrom = carFrom;
            this.carTo = carTo;
            autoShowroomFiltred = new List<Car>();
        }*/
        public CarList()
        {
            InitializeComponent();
            autoShowroomFiltred = new List<Car>();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        

        
        private void AddCarsToList(List<Car> Cars)
        {
            if (Cars == null)
            {
                throw new NullReferenceException("Список пустий");
            }
            ListViewItem item = null;
            foreach (var Car in Cars)
            {
                item = new ListViewItem(new string[] { Car.Brand, Car.Model, Convert.ToString(Car.ProductionYear), Convert.ToString(Car.Price), Car.Engine.Type, Convert.ToString(Car.Engine.Power), Convert.ToString(Car.Engine.Volume) });
                CarListView.Items.Add(item);
            }
        }
        private void CarList_Load(object sender, EventArgs e)
        {
            autoShowroom = new AutoShowroom();
            if (carTo.Brand != "" && carTo.Model != "")
            {
                foreach (var car in autoShowroom.CarsInShowroom)
                {
                    if (car.GetType() == carTo.GetType() && carTo.Brand == car.Brand && carTo.Model == car.Model)
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            autoShowroomFiltred.Add(car);
                        }
                    }
                }
            }
            else if (carTo.Brand != "" && carTo.Model == "")
            {
                foreach (var car in autoShowroom.CarsInShowroom)
                {
                    if (car.GetType() == carTo.GetType() && carTo.Brand == car.Brand)
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            autoShowroomFiltred.Add(car);
                        }
                    }
                }
            }
            else if (carTo.Brand == "" && carTo.Model == "")
            {
                foreach (var car in autoShowroom.CarsInShowroom)
                {
                    if (car.GetType() == carTo.GetType())
                    {
                        if (carTo.ProductionYear != 1 && carFrom.ProductionYear != 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear && carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear != 1)
                        {
                            if (carFrom.ProductionYear <= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear != 1 && carFrom.ProductionYear == 1)
                        {
                            if (carTo.ProductionYear >= car.ProductionYear)
                            {
                                autoShowroomFiltred.Add(car);
                            }
                        }
                        else if (carTo.ProductionYear == 1 && carFrom.ProductionYear == 1)
                        {
                            autoShowroomFiltred.Add(car);
                        }
                    }
                }
            }
            try
            {
                AddCarsToList(autoShowroomFiltred);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            autoShowroomFiltred.Sort();
            CarListView.Items.Clear();
            AddCarsToList(autoShowroomFiltred);
        }

        private void CarListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Adfewfs");
        }

        private void TopBorder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectButtn_Click(object sender, EventArgs e)
        {
            Car car;
            if (CarListView.SelectedItems.Count == 1)
            {
                ConfirmationForm Form = new ConfirmationForm();
                car = autoShowroomFiltred[CarListView.SelectedItems[0].Index];
                Form.SearchCar = car;
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте ввід даних");
            }
        }
    }
}
