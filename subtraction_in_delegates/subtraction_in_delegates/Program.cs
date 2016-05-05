using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtraction_in_delegates
{
    delegate int cal(int x,int y);

    class Subtraction
    {
        public int subt(int a ,int b)
        {
            Console.WriteLine("Subtraction of two numbers");
            return a - b;
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Subtraction obj = new Subtraction();
            cal delegateObject = obj.subt;
            Console.WriteLine(delegateObject(3, 5));
            Console.ReadKey();
        }
    }
}
