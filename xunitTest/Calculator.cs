using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicProg;

namespace xunitCalculartor
{
    public static class Calculator
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divide by Zero Error!");
            return a / b;
        }

    }
}
