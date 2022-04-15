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
            Console.WriteLine("\nFind The Number is Even or Odd");
            Console.WriteLine("\nEnter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) 
            {
                Console.WriteLine("\nEntered Number is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nEntered Nnumber is Odd Number");
                Console.ReadLine();
            }
           

        }

    }
}
