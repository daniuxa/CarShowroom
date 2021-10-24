using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class Сustomer : Person
    {
        public string _PhoneNumber { get; set; } //Номер телефона покупця
        private DateTime _visitDate;             //Дата візиту автосалону
        public DateTime _VisitDate
        {
            get
            {
                return _VisitDate;
            }
            set
            {
                if (value > DateTime.Now)
                    _VisitDate = value;
            }
        }
        public Сustomer() : base()
        {
            _PhoneNumber = "Невизначено";
            _visitDate = new DateTime();
        }
        public Сustomer(string name, string surname, DateTime Birthday, string sex, string PhoneNumber, DateTime VisitDate) : base(name, surname, Birthday, sex)
        {
            _PhoneNumber = PhoneNumber;
            if (VisitDate > DateTime.Now)
                _visitDate = VisitDate;
            else
                _visitDate = new DateTime();
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
