using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProj
{
    public class AutoShowroom
    {
        public List<Car> CarsInShowroom { get; set; }
        public AutoShowroom()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\saliv\\source\\repos\\WinFormsAppProj\\WinFormsAppProj\\Files\\Cars.bin", FileMode.OpenOrCreate))
            {
                CarsInShowroom = (List<Car>)formatter.Deserialize(fs);
            }
        }
    }
}
