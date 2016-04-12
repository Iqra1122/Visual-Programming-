using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
   class box
   {
       public double length;
       public double breadth;
       public double height;
       public double volume(double length,double breadth,double height)
       {
           return length * breadth * height;
       }
   }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            box box1 = new box();
            box1.length = 12;
            box1.breadth = 13;
            box1.height = 14;
            Console.WriteLine("Volume of the box is: {0}", box1.volume(box1.length, box1.breadth, box1.height));
            Console.ReadKey();

        }
    }
}
