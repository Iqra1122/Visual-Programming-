using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siblings
{
    class Program
    {
        static void Main(string[] args)
        {
            
                ArrayList A = new ArrayList();
                int totalNoOfSiblings;
                Console.WriteLine("Please enter no of siblings:");
                totalNoOfSiblings = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < totalNoOfSiblings; i++)
                {
                    Console.WriteLine("Please enter DOB (mm-dd-yyyy) of siblings no {0}:", i + 1);
                    A.Add(Console.ReadLine());
                }
                for (int i = 0; i < A.Count; i++)
                {
                    int years = 0;
                    int months = 0;
                    int days = 0;
                    int rest = 0;
                    DateTime dob = Convert.ToDateTime(A[i]);
                    TimeSpan diff = DateTime.Now.Subtract(dob);
                    Console.WriteLine("days:{0}",diff.Days);

                    years = diff.Days / 365;
                    rest = diff.Days - (years * 365);
                    months = rest / 30;
                    rest = rest - (months * 30);
                    days = rest;
                    Console.WriteLine("Age of sibling {0} is: {1} years {2} months {3} days. ", i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));

                    if (i > 0)
                    {
                        DateTime pdob = Convert.ToDateTime(A[i - 1]);
                        diff = pdob.Subtract(dob);
                        years = diff.Days / 365;
                        rest = diff.Days - (years * 365);
                        months = rest / 30;
                        rest = rest - (months * 30);
                        days = rest;
                        Console.WriteLine("Difference between sibling {0} and {1} is {2} years {3} months {4} days. ", i, i + 1, Math.Abs(years), Math.Abs(months), Math.Abs(days));
                    }
                }
               

                Console.ReadKey();
  
        }
    }

}