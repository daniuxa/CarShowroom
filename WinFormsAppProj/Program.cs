using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProj
{
    /*static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }*/
    /*
    Клас автомобіль:
     нащадки - типи автомобілів(легковий автомобіль, вантажівка)
    Клас працівник автосалону (персона):
     нащадки - типи працівників (директор, менеджер, ...)
     */
    /*
     * Окошко администратор(добавить автомобиль и вернуться в главное меню) и покупателя
     Открывается окошко (посмотреть автомобили), выбираем тип машинки, выбираем бренд машинки, вылазят данные о машине, 
    выбирает цвет машины, оформить визит(вводим данные), последнее окно вывод всех данных выбраных и типа ему кто то позвонит
     */
    /*abstract class Car
    {
        protected string _brand { get; set; }
        // private string model { get; set; }
        protected int _ProductionYear { get; set; }
        protected uint _price { get; set; }
        protected uint _power { get; set; }
        protected Car (string brand, int ProductionYear, uint price, uint power)
        {
            _brand = brand;
            _ProductionYear = ProductionYear;
            _price = price;
            _power = power;
        }

    }*/
    /*class LightCar : Car
    {
        private string _BodyType;
        private uint _TopSpeed;

        public LightCar (string brand, int ProductionYear, uint price, uint power, string BodyType, uint TopSpeed) : base(brand, ProductionYear, price, power)
        {
            _BodyType = BodyType;
            _TopSpeed = TopSpeed;
        }
    }*/

    /*    class Truck : Car
        {
            private uint _CarryingCapacity;
            private ushort _AmountAxles;    
            public Truck (string brand, int ProductionYear, uint price, uint power, uint CarryingCapacity, ushort AmountAxles) : base(brand, ProductionYear, price, power)
            {
                _CarryingCapacity = CarryingCapacity;
                _AmountAxles = AmountAxles;
            }
        }*/

    /*abstract class Person
    {
        protected string _name { get; set; }
        protected string _surname { get; set; }
        protected DateTime _Birthday { get; set; }
        protected string _sex { get; set; }
        protected Person (string name, string surname, DateTime Birthday, string sex)
        {
            _name = name;
            _surname = surname;
            _Birthday = Birthday;
            _sex = sex;
        }

    }*/

    /*class Сustomer : Person
    {
        private string _PhoneNumber;
        private DateTime _VisitDate;
        public Сustomer (string name, string surname, DateTime Birthday, string sex, string PhoneNumber, DateTime VisitDate) : base(name, surname, Birthday, sex)
        {
            _PhoneNumber = PhoneNumber;
            _VisitDate = VisitDate;
        }
    }*/

    /* class Worker : Person
     {
         private uint _salary;
         private string _WorkingPos;
         public Worker(string name, string surname, DateTime Birthday, string sex, uint salary, string WorkingPos) : base(name, surname, Birthday, sex)
         {
             _salary = salary;
             _WorkingPos = WorkingPos;
         }
     }*/
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
        }
    }
}