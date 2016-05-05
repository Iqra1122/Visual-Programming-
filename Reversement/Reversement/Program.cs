using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int reverse = 0;
            int remainder = 0;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            while(number!=0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("reverse is : {0}", reverse);
            Console.ReadKey();
        }
    }
}
