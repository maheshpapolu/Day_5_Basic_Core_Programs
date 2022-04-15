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
            Console.WriteLine("\nHarmonic_Number");
                int i,n;
                double s =0.0;
            Console.WriteLine("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s+=1/(float)i;
            }
            Console.WriteLine("\n Sum of Series upto {0} terms : {1} \n" ,n,s);
            Console.ReadLine();
      
        }
    }
}
