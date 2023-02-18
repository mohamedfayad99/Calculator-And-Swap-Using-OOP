using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    static class Calculator
    {

        #region MyFunction
        public static void Sum(Double x, Double y)
        {
            Console.WriteLine("the result is " + (x + y));
        }
        public static void Sub(Double x, Double y)
        {
            if (x > y) { Console.WriteLine("the result is " + (x - y)); }
            else { Console.WriteLine("the result is " + (y - x)); }
        }
        public static void Mull(Double x, Double y)
        {
            Console.WriteLine("the result is " + (x * y));

        }
        public static void Div(Double x, Double y)
        {
            if (y == 0)
            {
                Console.WriteLine("you can not divesion");
            }
            else
                Console.WriteLine("the result is " + (x / y));
        }
        #endregion

    }
}
