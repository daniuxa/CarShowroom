using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class YearProdException : Exception
    {
        public int Year { get; }
        public YearProdException (string msg, int value) : base(msg)
        {
            Year = value;
        }
        public YearProdException (string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Year = value;
        }
    }
    class PriceException : Exception
    {
        public int Price { get; }
        public PriceException (string msg, int value) : base(msg)
        {
            Price = value;
        }
        public PriceException (string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Price = value;
        }
    }
    class PowerException : Exception
    {
        public int Power { get; }
        public PowerException (string msg, int value) : base(msg)
        {
            Power = value;
        }
        public PowerException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Power = value;
        }
    }
    class CarryingCapException : Exception
    {
        public int CarryingCap { get; }
        public CarryingCapException(string msg, int value) : base(msg)
        {
            CarryingCap = value;
        }
        public CarryingCapException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            CarryingCap = value;
        }
    }
    class AxlesException : Exception
    {
        public int Axles { get; }
        public AxlesException(string msg, int value) : base(msg)
        {
            Axles = value;
        }
        public AxlesException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Axles = value;
        }
    }
    class TopSpeedException : Exception
    {
        public int TopSpeed { get; }
        public TopSpeedException(string msg, int value) : base(msg)
        {
            TopSpeed = value;
        }
        public TopSpeedException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            TopSpeed = value;
        }
    }
}
