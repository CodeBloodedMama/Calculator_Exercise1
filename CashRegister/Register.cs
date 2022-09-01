using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace CashRegister
{
    public class Register
    {
        public int NoOfItems { get; set; }
        private double _total;
        public Register()
        {
            _total = 0.0;
            NoOfItems = 0;
        }

        public double Divide(double dividend, double divisor)
        {
             double sum;

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot be divied by zero!");

            }
            else

                   sum = dividend / divisor;
            return sum;

        }

        public void AddItem(double itemPrice)
        {
            if (
                itemPrice < 0
                ||
                itemPrice > 10000
                )
                throw new ArgumentOutOfRangeException("Prisen er ukorrekt");

            _total += itemPrice;
            NoOfItems++;
        }

        public double GetTotal()
        {
            return _total;
        }

        public int GetNoOfItems()
        {
            return NoOfItems;
        }

        public void SubtractItem(double itemPrice)
        {
            if (itemPrice < 0)
                itemPrice = -itemPrice;

            if (NoOfItems > 0)
            {
                NoOfItems--;
                _total -= itemPrice;
            }

            return;
        }


    }
}
