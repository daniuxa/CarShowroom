using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    [Serializable]
    class Worker : Person, IComparable<Worker>
    {
        private int salary;                    //ЗП
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    throw new SalaryException("Неправильно введена заробітня платня", value);
            }
        }
        private string workingPos;//Посада
        public string WorkingPos
        {
            get
            {
                return workingPos;
            }
            set
            {
                if (value == "Менеджер" || value == "Консультант" || value == "PR-менеджер" || value == "Менеджер" || value == "Механік")
                {
                     workingPos = value;
                }
                else
                {
                    throw new WorkingPosException("Неправильно введена посада", value);
                }
            }
        }

        /*public Worker() : base()
        {
            _salary = 0;
            _WorkingPos = "Невизначено";
        }*/
        public Worker(string name, string surname, DateTime Birthday, string sex, int salary, string WorkingPos) : base(name, surname, Birthday, sex)
        {
            Salary = salary;
            this.WorkingPos = WorkingPos;
        }

        public int CompareTo(Worker other)
        {
            return this.Salary.CompareTo(other.Salary);
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
