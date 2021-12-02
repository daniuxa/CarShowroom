using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    [Serializable]
    public abstract class Car : ICar, IComparable<Car>
    {   
        public IEngine Engine { get; set; }
        public string Brand { get; set; }         //Бренд автомобіля
        public string Model { get; set; }         //Модель автомобіля
        protected int productionYear;             //Рік виробництва
        public int ProductionYear
        {
            get
            {
                return productionYear;
            }
            set
            {
                if (value <= DateTime.Now.Year && value > 0)
                    productionYear = value;
                else if (value > DateTime.Now.Year)
                    throw new YearProdException("Рік виробництва задається у майбутньому", value);
                else if (value <= 0)
                    throw new YearProdException("Рік виробництва менший або дорівнює нулю", value);
            }
        }
        protected int price;                           //Ціна автомобіля
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                {
                    throw new PriceException("Ціна дорівнює або менше нуля", value);
                }
            }
        }
        /*protected int power;                           //Потужність автомобіля
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value > 0)
                    power = value;
                else
                {
                    throw new PowerException("Потужність менша або дорівнює нулю", value);
                }
            }
        }*/
        /*protected Car()
        {
            _brand = "Невизначено";
            _model = "Невизначено";
            _productionYear = 0;
            _price = 0;
            _power = 0;
        }*/
        protected Car(string brand, int ProductionYear, int price, /*int power*/IEngine engine, string model)
        {
            this.Brand = brand;
            this.ProductionYear = ProductionYear;
            Price = price;
            Engine = engine;
           // Power = power;
            this.Model = model;
        }
        protected Car(string brand, int ProductionYear, string model)
        {
            this.Brand = brand;
            this.ProductionYear = ProductionYear;
            this.Model = model;
        }

        public int CompareTo(Car other)
        {
            return Price.CompareTo(other.Price);
        }

        /*public int Compare(Car x, Car y)
        {
            if (x.GetType() == y.GetType() && x.Model == y.Model && x.Brand == y.Brand && x.ProductionYear >= y.ProductionYear)
                return 1;
            else if (x.GetType() == y.GetType() && x.Model == y.Model && x.Brand == y.Brand && x.ProductionYear <= y.ProductionYear)
                return -1;
            else
                return 0;
        }*/

        /*//Гетер/сетер бренду
public string GetBrand()
{
   return _brand;
}
public void SetBrand(string brand)
{
   _brand = brand;
}*/
        /*//Гетер/сетер моделі
        public string GetModel()
        {
            return _model;
        }
        public void SetModel(string model)
        {
            _model = model;
        }*/
        /*//Гетер/сетер для дати виробництва
        public DateTime GetProductionYear()
        {
            return _ProductionYear;
        }
        public void SetProductionYear(DateTime ProductionYear)
        {
            DateTime Date = new DateTime(1970, 1, 1);
            if (ProductionYear > Date && ProductionYear < DateTime.Now)
                _ProductionYear = ProductionYear;
        }*/
        /*//Гетер/сетер для ціни
        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int price)
        {
            if (price > 0)
                _price = price;
        }*/
        /*//Гетер/сетер для потужності
        public int GetPower()
        {
            return _power;
        }
        public void SetPower(int power)
        {
            if (power > 0)
                _power = power;
        }*/
    }


}
