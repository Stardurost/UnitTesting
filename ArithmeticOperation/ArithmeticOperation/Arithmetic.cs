using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperation
{
    public class Arithmetic
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double Sqr(double x, double y)
        {
            return Math.Pow(x, 1/y);
        }
        public double Div(int x, int y)
        {
            return x / y;
        }
        public double Mod(int x, int y)
        {
            int res = x / y;
            double doublex, doubley;
            doublex = Convert.ToDouble(x);
            doubley = Convert.ToDouble(y);

            double result = doublex / doubley;
            result -= res;
            result = result * 100;
            return result;
        }
    }
}
