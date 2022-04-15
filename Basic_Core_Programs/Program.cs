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
            Console.WriteLine("\nPrime_Factors");
            int a, b;
            Console.WriteLine("Please enter your number: ");
            a = Convert.ToInt32(Console.ReadLine());
            for ( b = 2; a > 1 ; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while(a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is a prime factor {x} times ");
                    Console.ReadLine();
                }
               
           
      
        }
    }
}
