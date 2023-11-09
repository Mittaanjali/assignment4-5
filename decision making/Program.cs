using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision_making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your exam score as a percentage: ");
            double examScore = double.Parse(Console.ReadLine());

            if (examScore >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (examScore >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (examScore >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (examScore >= 60)
            {
                Console.WriteLine("Your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }

            Console.ReadLine(); 
        }
    }
}
    

