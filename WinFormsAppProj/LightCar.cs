using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class LightCar : Car
    {
        public string _BodyType { get; set; } //Тип кузова автомобіля
        private int _topSpeed;                //Максимальна швидкість автомобіля
        public int _TopSpeed
        {
            get
            {
                return _topSpeed;
            }
            set
            {
                if (value > 0)
                    _topSpeed = value;
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
            _BodyType = BodyType;
            _TopSpeed = TopSpeed;
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
