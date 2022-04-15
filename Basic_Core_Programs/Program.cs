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
            Console.WriteLine("\nFlip a Coin ");
            // initiating the varibles 
            int heads = 0;
            int tails = 0;
            int numberOfFlips = 0;
            Console.WriteLine("\n Enter no of times you want to flip a coin");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());
            // call the random method
            Random random = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                double result = random.NextDouble();
                Console.WriteLine($"\n Coin fliped for {i} times ");
                if(result > 0.5)
                {
                    Console.WriteLine("\ncoin flipping result : Heads");
                    heads++;
                
                }
                else
                {
                    Console.WriteLine("\ncoin flipping result : Tails");
                    tails++;
                }
                double headsPercentage =(heads/Convert.ToDouble(numberOfFlips))*100;
                double tailspercentage =(tails /Convert.ToDouble(numberOfFlips))*100;
                Console.WriteLine("\n percentage of heads: " + headsPercentage);
                Console.WriteLine("\n percentage of tails: " + tailspercentage);
                Console.ReadLine();
            }
        }
    }
}
