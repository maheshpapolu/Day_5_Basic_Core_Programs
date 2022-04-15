using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Basic Core Programs");
            Console.WriteLine("\nFind Leap Year ");
            Console.WriteLine("Input an Year : ");
            int CheckYear;
            CheckYear = Convert.ToInt32(Console.ReadLine());
            // checking conditions for leap year
            if ((CheckYear % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", CheckYear);
            else if ((CheckYear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", CheckYear);
            else
                Console.WriteLine("{0} is not a leap year.\n", CheckYear);
        }
    }
}
