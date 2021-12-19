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
        private InAndOutputLists<Car> inAndOutputLists;
        public Car car { get; set; }
        public List<Car> cars { get; set; }
        private Dictionary<string, List<string>> brands;
        public AddCarToList()
        {
            InitializeComponent();
            inAndOutputLists = new InAndOutputLists<Car>();
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
            /*Dictionary<string, List<string>> brands = new Dictionary<string, List<string>>();
            brands.Add("Mercedez-Benz", new List<string>() { "Actros", "Arocs", "Atego" });
            brands.Add("Volvo", new List<string>() { "FH16", "FL7", "FM" });
            brands.Add("Iveco", new List<string>() { "EuroCargo", "Stralis", "Trakker" });
            brands.Add("MAN", new List<string>() { "TGX", "eTGM", "TGS" });
            brands.Add("Scania", new List<string>() { "P380", "P280", "Odin S G410" });

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsTruck.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, brands);
            }*/
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
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsLightCar.bin", FileMode.OpenOrCreate))
                {
                    brands = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                }
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                foreach (var brand in brands)
                {
                    BrandComboBox.Items.Add(brand.Key);
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
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\BrandsTruck.bin", FileMode.OpenOrCreate))
                {
                    brands = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
                }
                BrandComboBox.Items.Clear();
                ModelComboBox.Items.Clear();
                BrandComboBox.Text = "";
                ModelComboBox.Text = "";
                foreach (var brand in brands)
                {
                    BrandComboBox.Items.Add(brand.Key);
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
            ModelComboBox.Items.Clear();
            ModelComboBox.Text = "";

            foreach (var brand in brands)
            {
                if (brand.Key == BrandComboBox.Text)
                {
                    for (int i = 0; i < brand.Value.Count; i++)
                    {
                        ModelComboBox.Items.Add(brand.Value[i]);
                    }
                    break;
                }
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
            inAndOutputLists.ChangeFilePath(@"C:\Users\saliv\source\repos\WinFormsAppProj\WinFormsAppProj\Files\Cars.bin");
            try
            {
                inAndOutputLists.WritingToFile(cars);
            }
            catch (FileException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}\tШлях до файлу: {ex.FilePath}");
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
