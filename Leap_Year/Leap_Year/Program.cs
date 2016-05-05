using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            string a;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Not Leap");
            }
            Console.ReadKey();
        }
    }
}
