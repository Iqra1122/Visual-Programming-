//calculator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program.calculator();
            Console.ReadKey();
        }

        public static void calculator()
        {
            int number1;
            int number2;
            int add;
            int mult;
            int subt;
            int div;
            Console.WriteLine("Enter First Number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            add = number1 + number2;
            mult = number1 * number2;
            subt = number1 - number2;
            div = number1 / number2;

            Console.WriteLine("Addition is :{0}", add);
            Console.WriteLine("Multiplication is :{0}", mult);
            Console.WriteLine("Subtraction is :{0}", subt);
            Console.WriteLine("Division is :{0}", div);
            Console.ReadKey();
        }
    }

}
// method overloading
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomeWork
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Addition is : {0}", sum(40, 30));
//            Console.ReadKey();

//        }
//        public static int  sum(int x,int y)
//        {
//            int add = x + y;
//            return x + y;
//        }
//    }
//}

