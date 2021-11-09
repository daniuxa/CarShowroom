using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class Сustomer : Person
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
                if (value.Length == 10)
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
                return VisitDate;
            }
            set
            {
                if (value > DateTime.Now)
                    VisitDate = value;
                else if (value.Year > DateTime.Now.Year + 1)
                    throw new VisitDayException("Дата візиту задана в далекому майбутньному", value);
                else
                    throw new VisitDayException("Дата візиту задана в минулому", value);
            }
        }
        public LightCar ViewLightCar { get; set; }
        public Truck ViewTruck { get; set; }
        /*public Сustomer() : base()
        {
            _PhoneNumber = "Невизначено";
            _visitDate = new DateTime();
        }*/
        public Сustomer(string name, string surname, DateTime Birthday, string sex, string PhoneNumber, DateTime VisitDate, LightCar ViewLightCar) : base(name, surname, Birthday, sex)
        {
            this.PhoneNumber = PhoneNumber;
            this.VisitDate = VisitDate;
            this.VisitDate = new DateTime();
            this.ViewLightCar = ViewLightCar;
        }
        public Сustomer(string name, string surname, DateTime Birthday, string sex, string PhoneNumber, DateTime VisitDate, Truck ViewTruck) : base(name, surname, Birthday, sex)
        {
            this.PhoneNumber = PhoneNumber;
            this.VisitDate = VisitDate;
            this.VisitDate = new DateTime();
            this.ViewLightCar = ViewLightCar;
        }

        /*//Гетер/сетер номеру телефона
        public string GetPhoneNumber()
        {
            return _PhoneNumber;
        }
        public void SetPhoneNumber(string PhoneNumber)
        {
            _PhoneNumber = PhoneNumber;
        }*/

        /*//Гетер/сетер дати візиту
        public DateTime GetVisitDate()
        {
            return _VisitDate;
        }
        public void SetVisitDate(DateTime VisitDate)
        {
            if (VisitDate > DateTime.Now)
                _VisitDate = VisitDate;
        }*/
    }
}
