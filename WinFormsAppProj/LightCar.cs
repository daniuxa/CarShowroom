using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class LightCar : Car
    {
        public string BodyType { get; set; } //Тип кузова автомобіля
        private int topSpeed;                //Максимальна швидкість автомобіля
        public int TopSpeed
        {
            get
            {
                return topSpeed;
            }
            set
            {
                if (value > 0)
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
        public LightCar(string brand, string model, int ProductionYear, int price, int power, string BodyType, int TopSpeed) : base(brand, ProductionYear, price, power, model)
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
