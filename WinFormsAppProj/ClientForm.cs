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
    public partial class ClientForm : Form
    {

        public ClientForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TypeAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeAuto.SelectedIndex == 0)
            {
                BrandAuto.Items.Clear();
                ModelAuto.Items.Clear();
                BrandAuto.Text = "";
                ModelAuto.Text = "";
                BrandAuto.Items.Add("Toyota");
                BrandAuto.Items.Add("Mercedez-Benz");
                BrandAuto.Items.Add("BMW");
                BrandAuto.Items.Add("Honda");
                BrandAuto.Items.Add("Volkswagen");
                BrandAuto.Items.Add("Ford");
                BrandAuto.Items.Add("Hyundai");
                BrandAuto.Items.Add("Audi");
                BrandAuto.Items.Add("Skoda");
                BrandAuto.Items.Add("Nissan");
            }
            else if (TypeAuto.SelectedIndex == 1)
            {
                BrandAuto.Items.Clear();
                ModelAuto.Items.Clear();
                BrandAuto.Text = "";
                ModelAuto.Text = "";
                BrandAuto.Items.Add("Mercedez-Benz");
                BrandAuto.Items.Add("Volvo");
                BrandAuto.Items.Add("Iveco");
                BrandAuto.Items.Add("MAN");
                BrandAuto.Items.Add("Scania");
            }
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void BrandAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 0)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Corolla");
                ModelAuto.Items.Add("Camry");
                ModelAuto.Items.Add("RAV 4");               
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 1)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("A-Class");
                ModelAuto.Items.Add("S-Class");
                ModelAuto.Items.Add("G-Class");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 2)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("5 Series");
                ModelAuto.Items.Add("1 Series");
                ModelAuto.Items.Add("X5");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 3)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("CRV");
                ModelAuto.Items.Add("Accord");
                ModelAuto.Items.Add("Civic");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 4)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Polo");
                ModelAuto.Items.Add("Passat");
                ModelAuto.Items.Add("Touareg");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 5)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Focus");
                ModelAuto.Items.Add("Kuga");
                ModelAuto.Items.Add("Mondeo");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 6)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Sonata");
                ModelAuto.Items.Add("Solaris");
                ModelAuto.Items.Add("Santa Fe");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 7)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("A3");
                ModelAuto.Items.Add("A6");
                ModelAuto.Items.Add("Q5");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 8)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Octavia");
                ModelAuto.Items.Add("Fabia");
                ModelAuto.Items.Add("Yeti");
            }
            else if (TypeAuto.SelectedIndex == 0 && BrandAuto.SelectedIndex == 9)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Almera");
                ModelAuto.Items.Add("Qashqai");
                ModelAuto.Items.Add("Tilda");
            }
            else if (TypeAuto.SelectedIndex == 1 && BrandAuto.SelectedIndex == 0)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("Actros");
                ModelAuto.Items.Add("Arocs");
                ModelAuto.Items.Add("Atego");
            }
            else if (TypeAuto.SelectedIndex == 1 && BrandAuto.SelectedIndex == 1)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("FH16");
                ModelAuto.Items.Add("FL7");
                ModelAuto.Items.Add("FM");
            }
            else if (TypeAuto.SelectedIndex == 1 && BrandAuto.SelectedIndex == 2)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("EuroCargo");
                ModelAuto.Items.Add("Stralis");
                ModelAuto.Items.Add("Trakker");
            }
            else if (TypeAuto.SelectedIndex == 1 && BrandAuto.SelectedIndex == 3)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("TGX");
                ModelAuto.Items.Add("eTGM");
                ModelAuto.Items.Add("TGS");
            }
            else if (TypeAuto.SelectedIndex == 1 && BrandAuto.SelectedIndex == 4)
            {
                ModelAuto.Items.Clear();
                ModelAuto.Text = "";
                ModelAuto.Items.Add("P380");
                ModelAuto.Items.Add("P280");
                ModelAuto.Items.Add("Odin S G410");
            }
        }

        private void ModelAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearcButtn_Click(object sender, EventArgs e)
        {
            /*Controls.Clear();*/
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
                    MessageBox.Show("Неправильно введено рік");
                    return;
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
                    MessageBox.Show("Неправильно введено рік");
                    return;
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
                    MessageBox.Show("Неправильно введено рік");
                    return;
                }
            }
            if (FromYear.Text != "" && ToYear.Text != "")
            {
                if (YearFrom < 1900 || YearTo < 1900)
                {
                    MessageBox.Show("Рік виробництва не може бути меншим ніж 1900 рік");
                    return;
                }
            }
            else if (FromYear.Text == "" && ToYear.Text != "")
            {
                if (YearTo < 1900)
                {
                    MessageBox.Show("Рік виробництва не може бути меншим ніж 1900 рік");
                    return;
                }
            }
            else if (FromYear.Text != "" && ToYear.Text == "")
            {
                if (YearFrom < 1900)
                {
                    MessageBox.Show("Рік виробництва не може бути меншим ніж 1900 рік");
                    return;
                }
            }
        

            if (/*BrandAuto.Text == ""*/ /*|| ModelAuto.Text == ""*/ /*||*/ TypeAuto.Text == "") 
            {
                MessageBox.Show("Перевірте введені вами значення");
            }
            else if (YearFrom > YearTo && FromYear.Text != "" && ToYear.Text != "")
            {
                MessageBox.Show("Перевірте введений вами рік");
            }
            else
            {
                if (TypeAuto.Text == "Легковий автомобіль")
                {
                    try
                    {
                        LightCar SearchCarFrom = new LightCar(BrandAuto.Text, ModelAuto.Text, YearFrom);
                    }
                    catch(YearProdException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }

                    try
                    {
                        LightCar SearchCarTo = new LightCar(BrandAuto.Text, ModelAuto.Text, YearTo);
                    }
                    catch (YearProdException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                   
                }
                else
                {
                    try
                    {
                        Truck SearchCarFrom = new Truck(BrandAuto.Text, ModelAuto.Text, YearFrom);
                    }
                    catch(YearProdException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    try
                    {
                        Truck SearchCarTo = new Truck(BrandAuto.Text, ModelAuto.Text, YearTo);
                    }
                    catch(YearProdException ex)
                    {
                        MessageBox.Show($"{ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                }
                MessageBox.Show($"Введені вами значення:\n{TypeAuto.Text}\n{BrandAuto.Text}\n{ModelAuto.Text}\nРік\tВід:{YearFrom} До:{YearTo}");
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
    }
}
