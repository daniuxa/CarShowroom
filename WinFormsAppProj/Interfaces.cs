using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WinFormsAppProj
{
    public interface IEngine
    {
        string Type { get; set; }
        int Power { get; set; }
        double Volume { get; set; }
        void PlaySound();
    }

    interface ICar
    {
        IEngine Engine { get; set; }
        string Brand { get; set; }         
        string Model { get; set; }
        int ProductionYear { get; set; }
        int Price { get; set; }
    }
    interface IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        DateTime Birthday { get; set; }
        string Sex { get; set; }
    }
}
