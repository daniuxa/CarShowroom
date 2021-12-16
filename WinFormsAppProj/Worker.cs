using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    [Serializable]
    class Worker<T> : Person
    {
        private int salary;                    
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
        private string workingPos;
        public string WorkingPos
        {
            get
            {
                return workingPos;
            }
            set
            {
                if (value == "Консультант" || value == "Механік")
                {
                     workingPos = value;
                }
                else
                {
                    throw new WorkingPosException("Неправильно введена посада", value);
                }
            }
        }

        public List<T> TaskList { get; set; }

        public Worker(string name, string surname, string sex, int salary, string WorkingPos, List<T> TaskList) : base(name, surname, sex)
        {
            Salary = salary;
            this.WorkingPos = WorkingPos;
            this.TaskList = TaskList;
        }
    }
}
