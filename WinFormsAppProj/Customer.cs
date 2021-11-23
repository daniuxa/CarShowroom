using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class Сustomer : Person, IComparable
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.Length == 10 && Int32.TryParse(value, out int result) == true)
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new PhoneNumberException("Неправильний формат номера телефона",value);
                }
            }
        }
        private DateTime visitDate;             //Дата візиту автосалону
        public DateTime VisitDate
        {
            get
            {
                return visitDate;
            }
            set
            {
                if (value >= DateTime.Now && value.Year <= DateTime.Now.Year + 1)
                    visitDate = value;
                else if (value.Year > DateTime.Now.Year + 1)
                    throw new VisitDayException("Дата візиту задана в далекому майбутньному", value);
                else
                    throw new VisitDayException("Дата візиту задана в минулому", value);
            }
        }

        public Car ViewCar { get; set; }

        public Сustomer(string name, string surname, DateTime Birthday, string sex, string PhoneNumber, DateTime VisitDate, Car ViewCar) : base(name, surname, Birthday, sex)
        {
            this.PhoneNumber = PhoneNumber;
            this.VisitDate = VisitDate;
            this.VisitDate = VisitDate;
            this.ViewCar = ViewCar;
        }

        public int CompareTo(object obj)
        {
            Сustomer p = obj as Сustomer;
            if (p != null)
                return this.VisitDate.CompareTo(p.VisitDate);
            else
                throw new Exception("Неможливо порівняти два об'єкта");
        }
    }
}
