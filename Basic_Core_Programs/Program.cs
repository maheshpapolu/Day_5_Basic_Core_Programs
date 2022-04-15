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
            Console.WriteLine("\nPower of Two");
                int number;
                int reminder;
                Console.WriteLine("Enter a number to check");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                    Console.WriteLine("It is power of 2.");
                else
                {
                    while(number > 1)
                    {
                        reminder = number % 2;
                        if (reminder != 0)
                            break;
                        number /= 2;
                    }
                    if (number == 1)
                        Console.WriteLine("it is power of 2");
                    else
                        Console.WriteLine("it is not a power of 2");
                    Console.ReadLine();
                }
           
        }
    }
}
