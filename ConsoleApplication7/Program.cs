using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
   partial class Railway
    {
        public static void Iqra
        {
            string[] Names = new string[4];
            string[] Address = new string[4];
            string[] city = new string[4];
            string[] Passengers = new string[4];
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("Please Enter Your name");
                Names[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Your address");
                Address[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Your City Name");
                city[i] = Console.ReadLine();
                Console.WriteLine("Please Enter total number of passengers");
                Passengers[i] = Console.ReadLine();

            }
        }
   }
    class program
    {
    

        static void Main(string[] args)
        {
           Railway obj= new Railway();
           obj.Iqra();
            Console.ReadLine();
        }
    }
}
