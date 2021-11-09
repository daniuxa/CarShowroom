using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class Truck : Car
    {
        private int carryingCapacity;    //Вантажопідйомність
        public int CarryingCapacity
        {
            get
            {
                return carryingCapacity;
            }
            set
            {
                if (value > 0)
                    carryingCapacity = value;
                else
                {
                    throw new CarryingCapException("Вантажопідйомність менша обо дорівнює нулю", value);
                }
            }
        }
        private short amountAxles;       //Кількість осей
        public short AmountAxles
        {
            get
            {
                return amountAxles;
            }
            set
            {
                if (value > 0 && value < 6)
                    amountAxles = value;
                else
                {
                    throw new AxlesException("Невірна кількість осей", value);
                }
            }
        }

        /*public Truck() : base()
        {
            _carryingCapacity = 0;
            _amountAxles = 0;
        }*/
        public Truck(string brand, string model, int ProductionYear, int price, int power, int CarryingCapacity, short AmountAxles) : base(brand, ProductionYear, price, power, model)
        {
            this.CarryingCapacity = CarryingCapacity;
            this.AmountAxles = AmountAxles;
        }
        public Truck(string brand, string model, int ProductionYear) : base(brand, ProductionYear, model)
        {

        }
        /*//Гетер/сетер вантажопідйомності
        public int GetCarryingCapacity()
        {
            return _CarryingCapacity;
        }
        public void SetCarryingCapacity(int CarryingCapacity)
        {
            if (CarryingCapacity > 0)
                _CarryingCapacity = CarryingCapacity;
        }*/
        /*//Гетер/сетер кількості осей
        public short GetAmountAxles()
        {
            return _AmountAxles;
        }
        public void SetAmountAxles(short AmountAxles)
        {
            if (AmountAxles > 0)
                _AmountAxles = AmountAxles;
        }*/
    }
}
