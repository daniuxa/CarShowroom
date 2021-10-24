using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    abstract class Person
    {
        public string _Name { get; set; }        //Ім'я
        public string _Surname { get; set; }     //Прізвище
        protected DateTime _birthday;            //Дата народження
        public DateTime _Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value < DateTime.Now.AddYears(-18))
                    _birthday = value;
            }
        }
        public string _Sex { get; set; }        //Стать

        protected Person()
        {
            _Name = "Невизначено";
            _Surname = "Невизначено";
            _Birthday = new DateTime();
            _Sex = "Невизначено";
        }
        protected Person(string name, string surname, DateTime Birthday, string sex)
        {
            _Name = name;
            _Surname = surname;
            if (Birthday < DateTime.Now.AddYears(-18))
                _birthday = Birthday;
            else
                _birthday = new DateTime();
            _Sex = sex;
        }

        /*//Гетер/сетер для имени
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }*/

        /*//Гетер/сетер для прізвища
        public string GetSurname()
        {
            return _name;
        }
        public void SetSurname(string surname)
        {
            _surname = surname;
        }*/

        /*//Гетер/сетер для дати народження
        public DateTime GetBirthday()
        {
            return _birthday;
        }
        public void SetProductionYear(DateTime Birthday)
        {
            if (Birthday < DateTime.Now.AddYears(-18))
                _birthday = Birthday;
        }*/

        /*//Гетер/сетер для статі людини
        public string GetSex()
        {
            return _sex;
        }
        public void SetSex(string sex)
        {
            _sex = sex;
        }*/
    }
}
