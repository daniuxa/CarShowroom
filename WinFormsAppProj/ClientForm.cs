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
    delegate void ErrorMsg();

    public partial class ClientForm : Form
    {
        private Dictionary<string, List<string>> brands;
        private LightCar SearchLightCarFrom = null;
        private LightCar SearchLightCarTo = null;
        private Truck SearchTruckFrom = null;
        private Truck SearchTruckTo = null;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TypeAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeAuto.SelectedItem.ToString() == "Легковий автомобіль")
            {

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsLightCar.bin", FileMode.OpenOrCreate))
                {
                    brands = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                }
                BrandAuto.Items.Clear();
                ModelAuto.Items.Clear();
                BrandAuto.Text = "";
                ModelAuto.Text = "";
                foreach (var brand in brands)
                {
                    BrandAuto.Items.Add(brand.Key);
                }

            }
            else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsTruck.bin", FileMode.OpenOrCreate))
                {
                    brands = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                }
                BrandAuto.Items.Clear();
                ModelAuto.Items.Clear();
                BrandAuto.Text = "";
                ModelAuto.Text = "";
                foreach (var brand in brands)
                {
                    BrandAuto.Items.Add(brand.Key);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void BrandAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelAuto.Items.Clear();
            ModelAuto.Text = "";
            foreach (var brand in brands)
            {
                if (brand.Key == BrandAuto.Text)
                {
                    for (int i = 0; i < brand.Value.Count; i++)
                    {
                        ModelAuto.Items.Add(brand.Value[i]);
                    }
                    break;
                }
            }
        }

        private void ModelAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearError()
        {
            MessageBox.Show("Неправильно введено рік", "Помилка вводу року", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InputError()
        {
            MessageBox.Show("Перевірте введені вами значення", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DistantPastYearError()
        {
            MessageBox.Show("Рік виробництва не може бути меншим ніж 1900 рік", "Помилка вводу року", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private ErrorMsg CheckError()
        {
            ErrorMsg Msg = null;
            int YearFrom = 1;
            int YearTo = 1;
            if (FromYear.Text == "" && ToYear.Text == "")
            {

            }
            else if (FromYear.Text != "" && ToYear.Text == "")
            {
                try
                {
                    YearFrom = Int32.Parse(FromYear.Text);
                    //YearTo = Int32.Parse(ToYear.Text);
                }
                catch (FormatException)
                {
                    Msg += YearError;
                    //return Msg;
                }
            }
            else if (FromYear.Text == "" && ToYear.Text != "")
            {
                try
                {
                    YearTo = Int32.Parse(ToYear.Text);
                }
                catch (FormatException)
                {
                    Msg += YearError;
                    //return Msg;
                }
            }
            else if (FromYear.Text != "" && ToYear.Text != "")
            {
                try
                {
                    YearFrom = Int32.Parse(FromYear.Text);
                    YearTo = Int32.Parse(ToYear.Text);
                }
                catch (FormatException)
                {
                    Msg += YearError;
                    //return Msg;
                }
            }
            if (FromYear.Text != "" && ToYear.Text != "")
            {
                if (YearFrom < 1900 || YearTo < 1900)
                {
                    Msg += DistantPastYearError;
                    //return Msg;
                }
            }
            else if (FromYear.Text == "" && ToYear.Text != "")
            {
                if (YearTo < 1900)
                {
                    Msg += DistantPastYearError;
                    //return Msg;
                }
            }
            else if (FromYear.Text != "" && ToYear.Text == "")
            {
                if (YearFrom < 1900)
                {
                    Msg += DistantPastYearError;
                    //return Msg;
                }
            }


            if (TypeAuto.Text == "")
            {
                Msg += InputError;
                return Msg;
            }
            else if (YearFrom > YearTo && FromYear.Text != "" && ToYear.Text != "")
            {
                Msg += YearError;
                return Msg;
            }
            else
            {
                if (TypeAuto.Text == "Легковий автомобіль")
                {

                    try
                    {
                        SearchLightCarFrom = new LightCar(BrandAuto.Text, ModelAuto.Text, YearFrom);
                    }
                    catch (YearProdException ex)
                    {
                        //MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        Msg += delegate ()
                        {
                            MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        };
                        //return Msg;
                    }

                    try
                    {
                        SearchLightCarTo = new LightCar(BrandAuto.Text, ModelAuto.Text, YearTo);
                    }
                    catch (YearProdException ex)
                    {
                        Msg += delegate ()
                        {
                            MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        };
                        //return Msg;
                    }
                }
                else
                {
                    try
                    {
                        SearchTruckFrom = new Truck(BrandAuto.Text, ModelAuto.Text, YearFrom);
                    }
                    catch (YearProdException ex)
                    {
                        Msg += () =>
                        {
                            MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        };
                        //return Msg;
                    }
                    try
                    {
                        SearchTruckTo = new Truck(BrandAuto.Text, ModelAuto.Text, YearTo);
                    }
                    catch (YearProdException ex)
                    {
                        Msg += () => MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}"); 



                        //return Msg;
                    }
                }
                return Msg;
            }
        }

        private void SearcButtn_Click(object sender, EventArgs e)
        {
            ErrorMsg msg;
            msg = CheckError();
            if (msg != null) //msg?.Invoke();
            {
                msg();
            }
            else
            {
                if (TypeAuto.Text == "Легковий автомобіль")
                {
                    CarList Form = new CarList();
                    Form.carFrom = SearchLightCarFrom;
                    Form.carTo = SearchLightCarTo;
                    this.Visible = false;
                    Form.ShowDialog();
                }
                else
                {
                    CarList Form = new CarList();
                    Form.carFrom = SearchTruckFrom;
                    Form.carTo = SearchTruckTo;
                    this.Visible = false;
                    Form.ShowDialog();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FromYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToYear_TextChanged(object sender, EventArgs e)
        {

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

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}