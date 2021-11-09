﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    [Serializable]
    abstract class Person
    {
        public string Name { get; set; }        //Ім'я
        public string Surname { get; set; }     //Прізвище
        protected DateTime birthday;            //Дата народження
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value > DateTime.Now.AddYears(-18))
                    throw new TooYoungException("Покупець занадто молодий", value);
                else if (value < new DateTime(1900, 1, 1))
                    throw new TooOldException("Покупець занадто старий", value);
                else
                  birthday = value;              
            }
        }
        private string sex;
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value == "Чоловік" || value == "Жінка")
                {
                    sex = value;
                }
                else
                    throw new SexException("Невірно заданий гендер", value);
            }
        }        
        

        /*protected Person()
        {
            _Name = "Невизначено";
            _Surname = "Невизначено";
            _Birthday = new DateTime();
            _Sex = "Невизначено";
        }*/
        protected Person(string name, string surname, DateTime Birthday, string sex)
        {
            Name = name;
            Surname = surname;
            this.Birthday = Birthday;
            Sex = sex;
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
