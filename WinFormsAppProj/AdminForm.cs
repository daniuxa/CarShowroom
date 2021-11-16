using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProj
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CloseButtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point LastPoint;
        private void TopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void TopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void WorkersButtn_Click(object sender, EventArgs e)
        {
            Worker A = new Worker("Oleg", "Shevxhenko", new DateTime(1980, 7, 12), "Man", 2000, "Manager");
            Worker B = new Worker("Taras", "Bondarenko", new DateTime(1980, 7, 12), "Man", 3000, "Manager");
            Worker C = new Worker("Alexandr", "Gopak", new DateTime(1980, 7, 12), "Man", 1000, "Manager");
            List<Worker> Arr = new List<Worker>() { A, B, C };
            string dir = @"D:\CarShowroom";
            string serializationFile = Path.Combine(dir, "Workers.bin");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\Workers.bin", FileMode.Create))
            {
                formatter.Serialize(fs, Arr);
            }
        }

        private void CarsButtn_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"WinFormsAppProj.Sounds.2.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceStream);
            player.Load();
            player.Play();
        }
    }
}
