using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_arguments
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int num1;
                int num2;
                int choice;
                Console.WriteLine("Enter first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 1 for Addition");
                Console.WriteLine("Enter 2 for Subtraction");
                Console.WriteLine("Enter 3 for Multiplication");
                Console.WriteLine("Enter 4 for Division");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Addition is : {0}", Program.sum(num1, num2));
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Subtraction is :{0}", Program.subt(num1, num2));
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Multiplication is :{0}", Program.Mult(num1, num2));
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Division is : {0}", Program.div(num1, num2));
                }
                else
                {
                    Console.WriteLine("Please enter valid choice");
                }
                Console.ReadKey();
            }
        }
        public static int sum(int a,int b)
        {
            return a + b;
        }
        public static int subt(int a,int b)
        {
            return a - b;
        }
        public static int Mult(int a,int b)
        {
            return a * b;
        }
        public static int div(int a,int b)
        {
            return a / b;
        }
    }
}
