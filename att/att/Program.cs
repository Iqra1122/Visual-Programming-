using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s.vp.lab4
{
    partial class Group
    {
        public void viewAttendens()
        {
            Console.WriteLine("\t attendens is : 100%");
        }
        public void Results()
        {
            Console.WriteLine("\t result is satisfactory");
        }
    }
    partial class Group
    {
        public void Courses()
        {
            Console.WriteLine("courses are following\n1.SDA\n2.FMSE\n3.VP\n4.SAMD\n5.SQE");
        }
        public void info()
        {
            Console.WriteLine("\t Iam in BSE 6A");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Group obj = new Group();
            obj.Courses();
            obj.info();
            obj.Results();
            obj.viewAttendens();
            Console.ReadLine();
        }
    }
}


