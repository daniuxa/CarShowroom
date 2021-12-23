using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    [Serializable]
    class LightCar : Car
    {
        private string bodyType;
        public string BodyType
        {
            get
            {
                return bodyType;
            }
            set
            {
                InAndOutputLists<List<string>> inAndOutputLists = new InAndOutputLists<List<string>>(@"C:\Users\saliv\source\repos\WinFormsAppProj\WinFormsAppProj\Files\BodyType.bin");
                List<string> BodyTypeList = inAndOutputLists.ReadingFromFile();
                if (BodyTypeList.Contains(value) == true)
                {
                    bodyType = value;
                }
                else
                {
                    throw new TypeBodyException("Неправильно задан тип кузова", value);
                }
            }
        } 
        private int topSpeed;                //Максимальна швидкість автомобіля
        public int TopSpeed
        {
            get
            {
                return topSpeed;
            }
            set
            {
                if (value > 0 && value < 700)
                    topSpeed = value;
                else
                {
                    throw new TopSpeedException("Максимальна швидкість менша або дорівнює нулю", value);
                }
            }
        }

        /*public LightCar() : base()
        {
            _BodyType = "Невизначено";
            _topSpeed = 0;
        }*/
        public LightCar(string brand, string model, int ProductionYear, int price, IEngine engine, string BodyType, int TopSpeed) : base(brand, ProductionYear, price, engine, model)
        {
            this.BodyType = BodyType;
            this.TopSpeed = TopSpeed;
        }
        public LightCar(string brand, string model, int ProductionYear) : base(brand, ProductionYear, model)
        {

        }

        /*//Гетер/сетер швидкості максимальної
        public int GetTopSpeed()
        {
            return _TopSpeed;
        }
        public void SetTopSpeed(int TopSpeed)
        {
            if (TopSpeed > 0)
                _TopSpeed = TopSpeed;
        }*/

       /* //Гетер/сетер типу кузова
        public string GetBodyType()
        {
            return _BodyType;
        }
        public void SetBodyType(string BodyType)
        {
            _BodyType = BodyType;
        }*/
    }
}
