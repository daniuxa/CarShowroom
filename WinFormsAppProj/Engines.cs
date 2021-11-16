using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class FstType : IEngine
    {
        private string type;
        public string Type 
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "Бензиновий" || value == "Дизельний")
                    type = Type;
                else
                    throw new TypeException("Неправильно задан тип двигуна", value);
            }
        }
        private int power;
        public int Power 
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    power = value;
                }
                else
                {
                    throw new PowerException("Неправильно задана потужність двигуна", value);
                }
            }
        }

        private double volume;
        public double Volume 
        { 
            get
            {
                return volume;
            }
            set
            {
                if (volume > 0 && volume < 100)
                    volume = value;
                else
                    throw new VolumeException("Неправильно задан об'єм двигуна", value);
            }
        }

        public void PlaySound()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"WinFormsAppProj.Sounds.1.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceStream);
            player.Load();
            player.Play();
        }
        public FstType()
        {
            Type = "Бензиновий";
            Power = 150;
            Volume = 1.8;
        }
    }
    class SecondType : IEngine
    {
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "Бензиновий" || value == "Дизельний")
                    type = Type;
                else
                    throw new TypeException("Неправильно задан тип двигуна", value);
            }
        }
        private int power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    power = value;
                }
                else
                {
                    throw new PowerException("Неправильно задана потужність двигуна", value);
                }
            }
        }

        private double volume;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (volume > 0 && volume < 100)
                    volume = value;
                else
                    throw new VolumeException("Неправильно задан об'єм двигуна", value);
            }
        }

        public void PlaySound()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"WinFormsAppProj.Sounds.2.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceStream);
            player.Load();
            player.Play();
        }
        public SecondType()
        {
            Type = "Бензиновий";
            Power = 250;
            Volume = 2.5;
        }
    }
    class TrdType : IEngine
    {
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "Бензиновий" || value == "Дизельний")
                    type = Type;
                else
                    throw new TypeException("Неправильно задан тип двигуна", value);
            }
        }
        private int power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    power = value;
                }
                else
                {
                    throw new PowerException("Неправильно задана потужність двигуна", value);
                }
            }
        }

        private double volume;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (volume > 0 && volume < 100)
                    volume = value;
                else
                    throw new VolumeException("Неправильно задан об'єм двигуна", value);
            }
        }

        public void PlaySound()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"WinFormsAppProj.Sounds.3.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(resourceStream);
            player.Load();
            player.Play();
        }
        public TrdType()
        {
            Type = "Дизельний";
            Power = 400;
            Volume = 5;
        }
    }
}
