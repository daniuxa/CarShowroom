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
    public partial class ExampleWorkerForm : Form
    {
        Stack<Worker<Car>> Mechanics = new Stack<Worker<Car>>();
        Queue<Worker<Сustomer>> Consultants = new Queue<Worker<Сustomer>>();
        public ExampleWorkerForm()
        {
            InitializeComponent();
        }

        private void ExampleWorkerForm_Load(object sender, EventArgs e)
        {
            /*Mechanics.Push(new Worker<Car>("Арсеній", "Кутина", "Чоловік", 25000, "Механік", new List<Car>() { }));

            Mechanics.Push(new Worker<Car>("Олександр", "Таран", "Чоловік", 23000, "Механік"));
            Mechanics.Push(new Worker<Car>("Андрій", "Бандера", "Чоловік", 25000, "Механік"));
            Consultants.Enqueue(new Worker<Сustomer>("Олексій", "Миколенко", "Чоловік", 25000, "Консультант"));
            Consultants.Enqueue(new Worker<Сustomer>("Валерій", "Супряга", "Чоловік", 25000, "Консультант"));
            Consultants.Enqueue(new Worker<Сustomer>("Данило", "Шабанов", "Чоловік", 25000, "Консультант"));*/

        }
    }
}
