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
    public partial class ConfirmationForm : Form
    {
        public Car SearchCar { get; set; }
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void TypeAuto_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            if (SearchCar.GetType().Name == "LightCar")
            {
                LightCar lightCar = SearchCar as LightCar;
                if (lightCar != null)
                {
                    TypeAuto.Text += "Легковий автомобіль";
                    FstField.Text = "Тип кузова: " + lightCar.BodyType.ToString();
                    ScdField.Text = "Максимальна швидкість: " + lightCar.TopSpeed.ToString();
                }
            }
            else
            {
                Truck truck = SearchCar as Truck;
                if (truck != null)
                {
                    TypeAuto.Text += "Вантажівка";
                    FstField.Text = "Вантажопідйомність: " + truck.CarryingCapacity.ToString();
                    ScdField.Text = "Кількість осей: " + truck.AmountAxles.ToString();
                }
            }
            Brand.Text += SearchCar.Brand;
            Model.Text += SearchCar.Model;
            ProdYear.Text += SearchCar.ProductionYear.ToString();
            Price.Text += SearchCar.Price.ToString();
            TypeEngine.Text += SearchCar.Engine.Type;
            Power.Text += SearchCar.Engine.Power;
            Volume.Text += SearchCar.Engine.Volume;
        }

        private void SoundButtn_Click(object sender, EventArgs e)
        {
            SearchCar.Engine.PlaySound();
        }

        private void YesButtn_Click(object sender, EventArgs e)
        {
            ClientDataEntry Form = new ClientDataEntry();
            Form.car = SearchCar;
            this.Visible = false;
            Form.ShowDialog();
        }

        private void NoButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
