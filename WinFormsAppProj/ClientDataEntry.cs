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
    public partial class ClientDataEntry : Form
    {
        public event EventHandler<BoughtCarEventArg> BoughtCar;
        public Car car { get; set; }
        public ClientDataEntry()
        {
            InitializeComponent();
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

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Сustomer сustomer;
            if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && SexBox.Text != "" && PhoneTextBox.Text != "")
            {
                try
                {
                    сustomer = new Сustomer(NameTextBox.Text, SurnameTextBox.Text, SexBox.Text, PhoneTextBox.Text, VisitDayTimePicker.Value, car);
                }
                catch (SexException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (PhoneNumberException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value}");
                    return;
                }
                catch (VisitDayException ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}\tЗначення: {ex.Value.ToString("d")}");
                    return;
                }
                SuccessfulOrder Form = new SuccessfulOrder();
                Form.person = сustomer;
                BoughtCar += SendMessage;
                BoughtCar?.Invoke(сustomer, new BoughtCarEventArg(сustomer.ViewCar));
                this.Close();
                Form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Перевірте правильність заповнення полей");
            }
        }
        static void SendMessage(object sender, BoughtCarEventArg BoughtCarEventArg)
        {
            Сustomer customer = sender as Сustomer;
            MessageBox.Show($"На сайті замовлен автомобіль: {BoughtCarEventArg.car.Brand} {BoughtCarEventArg.car.Model} {BoughtCarEventArg.car.ProductionYear} року\n\nПокупець: {customer.Name} {customer.Surname} \n\nМобільний телефон: {customer.PhoneNumber}\n\n Дата візиту: {customer.VisitDate.ToString("d")}", "Повідомлення адміністратору", MessageBoxButtons.OK);
        }
    }
}
