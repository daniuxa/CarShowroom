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
    public partial class AddCarToList : Form
    {
        public Car car { get; set; }
        public List<Car> cars { get; set; }
        public AddCarToList()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EngineListView.Visible == false)
            {
                EngineListView.Visible = true;
            }
            else
            {
                EngineListView.Visible = false;
            }
        }

        private void AddCarToList_Load(object sender, EventArgs e)
        {
            ListViewItem item = null;
            /*List<IEngine> engines = new List<IEngine>() 
            {
                new FstType(),
                new SecondType(),
                new TrdType()
            };*/


            Dictionary<string, IEngine> engines = new Dictionary<string, IEngine>();
            engines.Add("Перший тип", new FstType());
            engines.Add("Другий тип", new SecondType());
            engines.Add("Третій тип", new TrdType());


            ExtraField1.Visible = false;
            ExtraField2.Visible = false;
            ExtraTextBox2.Visible = false;
            CarryingCapacityBox.Visible = false;
            TypeBodyComboBox.Visible = false;

            for (int i = DateTime.Now.Year; i > 1900; i--)
            {
                YearProdComboBox.Items.Add(i);
            }
            EngineListView.Visible = false;
            foreach (var engine in engines)
            {
                EngineComboBox.Items.Add(engine.Key);
            }
            /*EngineComboBox.Items.Add("Перший тип");
            EngineComboBox.Items.Add("Другий тип");
            EngineComboBox.Items.Add("Третій тип");*/
            foreach (var engine in engines)
            {
                item = new ListViewItem(new string[] { engine.Key, engine.Value.Type, Convert.ToString(engine.Value.Power), Convert.ToString(engine.Value.Volume) });
                EngineListView.Items.Add(item);
            }
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (TypeComboBox.SelectedItem.ToString() == "Легковий автомобіль")
            {
                *//*List<string> brands;
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\LightCarBrand.bin", FileMode.OpenOrCreate))
                {

                    brands = (List<string>)formatter.Deserialize(fs);
                }*//*

            }*/
            
            if (TypeComboBox.SelectedItem.ToString() == "Легковий автомобіль")
            {
                Queue<string> brands = new Queue<string>();
                /* brands.Enqueue("Toyota");
                 brands.Enqueue("Mercedez-Benz");
                 brands.Enqueue("BMW");
                 brands.Enqueue("Honda");
                 brands.Enqueue("Volkswagen");
                 brands.Enqueue("Ford");
                 brands.Enqueue("Hyundai");
                 brands.Enqueue("Ford");
                 brands.Enqueue("Audi");
                 brands.Enqueue("Skoda");
                 brands.Enqueue("Nissan");
                 BinaryFormatter formatter = new BinaryFormatter();
                 using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Brands.bin", FileMode.OpenOrCreate))
                 {
                     formatter.Serialize(fs, brands);
                 }*/
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsLightCar.bin", FileMode.OpenOrCreate))
                {
                    brands = (Queue<string>)formatter.Deserialize(fs);
                }
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                while(brands.Count != 0)
                {
                    BrandComboBox.Items.Add(brands.Dequeue());
                }
                /*BrandComboBox.Items.Add("Toyota");
                BrandComboBox.Items.Add("Mercedez-Benz");
                BrandComboBox.Items.Add("BMW");
                BrandComboBox.Items.Add("Honda");
                BrandComboBox.Items.Add("Volkswagen");
                BrandComboBox.Items.Add("Ford");
                BrandComboBox.Items.Add("Hyundai");
                BrandComboBox.Items.Add("Audi");
                BrandComboBox.Items.Add("Skoda");
                BrandComboBox.Items.Add("Nissan");*/
                ExtraField1.Text = "Тип кузова: ";
                ExtraField2.Text = "Макс. швидкість: ";
                ExtraField1.Visible = true;
                ExtraField2.Visible = true;
                TypeBodyComboBox.Visible = true;
                ExtraTextBox2.Visible = true;
                CarryingCapacityBox.Visible = false;
            }
            else
            {
                Stack<string> brands = new Stack<string>();
                /*brands.Push("Scania");
                brands.Push("MAN");
                brands.Push("Iveco");
                brands.Push("Volvo");
                brands.Push("Mercedez-Benz");
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsTruck.bin", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, brands);
                }*/
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsTruck.bin", FileMode.OpenOrCreate))
                {
                    brands = (Stack<string>)formatter.Deserialize(fs);
                }
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                while(brands.Count != 0)
                {
                    BrandComboBox.Items.Add(brands.Pop());
                }
                /*BrandComboBox.Items.Add("Mercedez-Benz");
                BrandComboBox.Items.Add("Volvo");
                BrandComboBox.Items.Add("Iveco");
                BrandComboBox.Items.Add("MAN");
                BrandComboBox.Items.Add("Scania");*/
                ExtraField1.Text = "Вантажопідйомність: ";
                ExtraField2.Text = "Кількість осей: ";
                ExtraField1.Visible = true;
                ExtraField2.Visible = true;
                ExtraTextBox2.Visible = true;
                CarryingCapacityBox.Visible = true;
                TypeBodyComboBox.Visible = false;
            }
            
            
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 0)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Corolla");
                ModelComboBox.Items.Add("Camry");
                ModelComboBox.Items.Add("RAV 4");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 1)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("A-Class");
                ModelComboBox.Items.Add("S-Class");
                ModelComboBox.Items.Add("G-Class");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 2)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("5 Series");
                ModelComboBox.Items.Add("1 Series");
                ModelComboBox.Items.Add("X5");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 3)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("CRV");
                ModelComboBox.Items.Add("Accord");
                ModelComboBox.Items.Add("Civic");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 4)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Polo");
                ModelComboBox.Items.Add("Passat");
                ModelComboBox.Items.Add("Touareg");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 5)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Focus");
                ModelComboBox.Items.Add("Kuga");
                ModelComboBox.Items.Add("Mondeo");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 6)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Sonata");
                ModelComboBox.Items.Add("Solaris");
                ModelComboBox.Items.Add("Santa Fe");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 7)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("A3");
                ModelComboBox.Items.Add("A6");
                ModelComboBox.Items.Add("Q5");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 8)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Octavia");
                ModelComboBox.Items.Add("Fabia");
                ModelComboBox.Items.Add("Yeti");
            }
            else if (TypeComboBox.SelectedIndex == 0 && BrandComboBox.SelectedIndex == 9)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Almera");
                ModelComboBox.Items.Add("Qashqai");
                ModelComboBox.Items.Add("Tilda");
            }
            else if (TypeComboBox.SelectedIndex == 1 && BrandComboBox.SelectedIndex == 0)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("Actros");
                ModelComboBox.Items.Add("Arocs");
                ModelComboBox.Items.Add("Atego");
            }
            else if (TypeComboBox.SelectedIndex == 1 && BrandComboBox.SelectedIndex == 1)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("FH16");
                ModelComboBox.Items.Add("FL7");
                ModelComboBox.Items.Add("FM");
            }
            else if (TypeComboBox.SelectedIndex == 1 && BrandComboBox.SelectedIndex == 2)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("EuroCargo");
                ModelComboBox.Items.Add("Stralis");
                ModelComboBox.Items.Add("Trakker");
            }
            else if (TypeComboBox.SelectedIndex == 1 && BrandComboBox.SelectedIndex == 3)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("TGX");
                ModelComboBox.Items.Add("eTGM");
                ModelComboBox.Items.Add("TGS");
            }
            else if (TypeComboBox.SelectedIndex == 1 && BrandComboBox.SelectedIndex == 4)
            {
                ModelComboBox.Items.Clear();
                ModelComboBox.Text = "";
                ModelComboBox.Items.Add("P380");
                ModelComboBox.Items.Add("P280");
                ModelComboBox.Items.Add("Odin S G410");
            }
        }

        private void EngineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EngineListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        Point LastPoint;

        private void AddCarToList_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

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

        private void AddCar_Click(object sender, EventArgs e)
        {
            if (TypeComboBox.Text != "" && BrandComboBox.Text != "" && ModelComboBox.Text != "" && YearProdComboBox.Text != "" && EngineComboBox.Text != "" && PriceTextBox.Text != "")
            {
                if (Int32.TryParse(PriceTextBox.Text, out int Price) == false)
                {
                    MessageBox.Show("Неправильний формат введення ціни");
                    return;
                }
                if (TypeComboBox.SelectedItem.ToString() == "Легковий автомобіль")
                {
                    if (Int32.TryParse(ExtraTextBox2.Text, out int MaxSpeed) == false)
                    {
                        
                        MessageBox.Show("Неправильний формат введення максимальнох швидкості");
                        return;
                    }
                    try
                    {
                        car = new LightCar(BrandComboBox.Text, ModelComboBox.Text, Int32.Parse(YearProdComboBox.Text), Price, (EngineComboBox.Text == "Перший тип" ? new FstType() : EngineComboBox.Text == "Другий тип" ? new SecondType() : new TrdType()), TypeBodyComboBox.Text, MaxSpeed);
                    }
                    catch (TypeBodyException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch(TopSpeedException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (YearProdException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (PriceException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (TypeException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch(PowerException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (VolumeException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                }
                else
                {
                    if (Int32.TryParse(CarryingCapacityBox.Text, out int CarryingCapacity) == false)
                    {
                        MessageBox.Show("Неправильний формат введення вантажопідйомності");
                        return;
                    }
                    if (Int16.TryParse(ExtraTextBox2.Text, out short AmountAxles) == false)
                    {
                        MessageBox.Show("Неправильний формат введення кількості осей");
                        return;
                    }
                    try
                    {
                        car = new Truck(BrandComboBox.Text, ModelComboBox.Text, Int32.Parse(YearProdComboBox.Text), Price, (EngineComboBox.Text == "Перший тип" ? new FstType() : EngineComboBox.Text == "Другий тип" ? new SecondType() : new TrdType()), CarryingCapacity, AmountAxles);
                    }
                    catch (TypeBodyException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (TopSpeedException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (YearProdException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (PriceException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (TypeException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (PowerException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                    catch (VolumeException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Перевірте заповненість всіх полів");
                return;
            }
            cars.Add(car);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, cars);
            }
            MessageBox.Show("Успішно додано");
            this.Close();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }
    }
}
