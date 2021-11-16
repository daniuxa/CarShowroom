using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WinFormsAppProj
{
    
    interface IEngine
    {
        string Type { get; set; }
        int Power { get; set; }
        double Volume { get; set; }
        void PlaySound();
    }
}
