using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProj
{
    class YearProdException : Exception
    {
        public int Value { get; }
        public YearProdException (string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public YearProdException (string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    class PriceException : Exception
    {
        public int Value { get; }
        public PriceException (string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public PriceException (string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    class PowerException : Exception
    {
        public int Value { get; }
        public PowerException (string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public PowerException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    class CarryingCapException : Exception
    {
        public int Value { get; }
        public CarryingCapException(string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public CarryingCapException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    class AxlesException : Exception
    {
        public int Value { get; }
        public AxlesException(string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public AxlesException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    class TopSpeedException : Exception
    {
        public int Value { get; }
        public TopSpeedException(string msg, int value) : base(msg)
        {
            Value = value;
        }
        /*public TopSpeedException(string msg, int value, Exception InnerException) : base(msg, InnerException)
        {
            Value = value;
        }*/
    }
    /*class TooYoungException : Exception
    {
        public int Value { get; }
        public TooYoungException(string msg, int value) : base(msg)
        {
            Value = value;
        }
    }*/
    class TooOldException : Exception
    {
        public DateTime Value { get; }
        public TooOldException(string msg, DateTime value) : base(msg)
        {
            Value = value;
        }
    }
    class SexException : Exception
    {
        public string Value { get; }
        public SexException(string msg, string value) : base(msg)
        {
            Value = value;
        }
    }
    class TooYoungException : Exception
    {
        public DateTime Value { get; set; }
        public TooYoungException(string msg, DateTime value) : base(msg)
        {
            Value = value;
        }
    }
    class VisitDayException : Exception
    {
        public DateTime Value { get; set; }
        public VisitDayException(string msg, DateTime value) : base(msg)
        {
            Value = value;
        }
    }
    class SalaryException : Exception
    {
        public int Value { get; set; }
        public SalaryException(string msg, int value) : base(msg)
        {
            Value = value;
        }
    }
    class WorkingPosException : Exception
    {
        public string Value { get; set; }
        public WorkingPosException(string msg, string value) : base(msg)
        {
            Value = value;
        }
    }
    class PhoneNumberException : Exception
    {
        public string Value { get; set; }
        public PhoneNumberException(string msg, string value) : base(msg)
        {
            Value = value;
        }
    }
}
