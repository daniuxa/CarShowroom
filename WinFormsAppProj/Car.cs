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

        protected Car(string brand, int ProductionYear, int price, /*int power*/IEngine engine, string model)
        {
            this.Brand = brand;
            this.ProductionYear = ProductionYear;
            Price = price;
            Engine = engine;
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
    }
}



/*namespace ConsoleLection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "Processor i3",
                Price = 2500.0
            };

            product.PriceChanged += HandlerSample;

            product.Price = 2250.0;
        }

        static void HandlerSample(object sender, PriceChangedEventArg PriceChangedEvent)
        {
            Product product = sender as Product;
            Console.WriteLine($"На товар {product.Name} змінено ціну з {PriceChangedEvent.OldPrice} на {PriceChangedEvent.NewPrice}");
        }
    }

    // delegate void PriceChanged(object sender, PriceChangedEventArg PriceChangedEvent);

    class Product
    {
        double _price;

        public event EventHandler<PriceChangedEventArg> PriceChanged;

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                double oldPrice = _price;
                _price = value;
                PriceChanged?.Invoke(this, new PriceChangedEventArg() { OldPrice = oldPrice, NewPrice = _price });
            }
        }
    }

    class PriceChangedEventArg : EventArgs
    {
        public double OldPrice { get; set; }
        public double NewPrice { get; set; }
    }
}*/



