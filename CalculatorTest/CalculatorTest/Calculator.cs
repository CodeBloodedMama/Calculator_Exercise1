﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace CalculatorApp
{
    public class Calculator
    {
        private double accumulator;
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double added)
        {
            accumulator=accumulator+added;
            return accumulator;
        }

        public double Substract(double a, double b)
        {

            return a - b;
        }
        public double Substract(double substractor)
        {
            accumulator = accumulator - substractor;
            return accumulator;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Multiply(double multiplier)
        {
            return multiplier * accumulator;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        public double Power(double exponent)
        {
            return Math.Pow(accumulator, exponent);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                // throw exception
                throw new DivideByZeroException("Can't divide by 0");
            }
            else
            {
                return dividend / divisor;
            }
        }
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                // throw exception
                throw new DivideByZeroException("Can't divide by 0");
            }
            else
            {
                return accumulator / divisor;
            }
        }

        public double Accumulator
        {
            get { return accumulator; }
            set { accumulator += value; }

        }
        public void Clear()
        { accumulator = 0; }


    }
}