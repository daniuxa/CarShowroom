using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class Worker : Person
    {
        private int _salary;                    //ЗП
        private int _Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                    _salary = value;
            }
        }
        private string _WorkingPos { get; set; } //Посада

        public Worker() : base()
        {
            _salary = 0;
            _WorkingPos = "Невизначено";
        }
        public Worker(string name, string surname, DateTime Birthday, string sex, int salary, string WorkingPos) : base(name, surname, Birthday, sex)
        {
            if (salary > 0)
                _salary = salary;
            else
                _salary = 0;
            _WorkingPos = WorkingPos;
        }

       /* //Гетер/сетер ЗП
        public int GetSalary()
        {
            return _salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }*/

        /*//Гетер/сетер посади
        public string GetWorkingPos()
        {
            return _WorkingPos;
        }
        public void SetWorkingPos(string WorkingPos)
        {
            _WorkingPos = WorkingPos;
        }*/
    }
}
