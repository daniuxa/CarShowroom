using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    public class BoughtCarEventArg : EventArgs
    {
        public Car car { get; }
        public DateTime BoughtCarTime { get; }
        public BoughtCarEventArg(Car car, DateTime BoughtCarTime)
        {
            this.car = car;
            this.BoughtCarTime = BoughtCarTime;
        }
    }
}
