using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphimism
{
    public class drawing
    {
        public virtual void Draw()
        {
            Console.WriteLine("this is just a generic drawing"); ;
        }

    }
    public class line : drawing
    {
        public override void Draw()
        {
            Console.WriteLine("this is a line");
        }
    }
    public class Circle : drawing
    {
        public override void Draw()
        {
            Console.WriteLine("this is a circle");
        }
    }
    public class Square : drawing
    {
        public override void Draw()
        {
            Console.WriteLine("this is a Sqaure");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            drawing[] dobj = new drawing[4];
            dobj[0] = new line();
            dobj[1] = new Circle();
            dobj[2] = new Square();
            dobj[3] = new drawing();

            foreach (drawing draw in dobj )
            {
                draw.Draw();


            }
            Console.ReadKey();

           
        }
    }
}
