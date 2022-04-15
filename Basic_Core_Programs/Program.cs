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
            Console.WriteLine("\nSwap Two Numbers");
            int number1, number2, temp;
            Console.WriteLine("\n Enter first number ; ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\n After Swaping : ");
            Console.WriteLine("\nFirst Number: ");
            Console.WriteLine("\nSecond Number: ");
            Console.ReadLine();

        }

    }
}
