using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    internal class Class1
    {
        public static void swap( int  x, int y)
        {
            int temp = x;
            x = y; ;
            y = temp;
            Console.WriteLine(x +"  "+y);
        }
    }
}
