using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_in_delegates
{
    delegate int cal(int x,int y);

    class calculator
    {
        public int sum(int a,int b)
        {
            Console.WriteLine("Addition of two numbers is ");
            return a + b;
        }
        public int subt(int a,int b)
        {
            Console.WriteLine("Subtraction of two numbers is");
            return a - b;
        }
        public int mult(int a,int b)
        {
            Console.WriteLine("Multiplication of two numbers is");
            return a * b;
        }
        public int div(int a,int b)
        {
            Console.WriteLine("Division of two numbers is");
            return a / b;
        }
        public int modulus(int a ,int b)
        {
            Console.WriteLine("Modulies of two numbers is");
            return a % b;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            calculator obj = new calculator();
            cal delegateObject = obj.sum;
            Console.WriteLine(delegateObject(10, 30));

            delegateObject = obj.subt;
            Console.WriteLine(delegateObject(50, 20));

            delegateObject = obj.mult;
            Console.WriteLine(delegateObject(50, 20));

            delegateObject = obj.div;
            Console.WriteLine(delegateObject(50, 20));

            delegateObject = obj.modulus;
            Console.WriteLine(delegateObject(50, 20));

            Console.ReadKey();

        }
    }
}
