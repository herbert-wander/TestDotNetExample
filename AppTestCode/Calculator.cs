using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestCode
{
    public class Calculator
    {
        public double Sum(double numberA, double numberB)
        {
            return numberA + numberB;
        }
        public double Subtract(double numberA, double numberB)
        {
            return numberA - numberB;
        }
        public double Divide(double numberA, double numberB)
        {
            return numberA / numberB;
        }
        public double Multiply(double numberA, double numberB)
        {
            return numberA * numberB;
        }
    }
}
