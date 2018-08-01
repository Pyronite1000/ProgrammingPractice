using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculator");
            Console.WriteLine("Enter the number you wish to calculate the factorial");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1; //decimal is largest type that can hold an integer
            while (true)
            {
                if (n <= 1)
                {
                    break;
                    //break is like cutting the wire on our hard-wired electrical device. 
                    //It stops the loop from iterating, and breaks out of it.
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("Your answer is " +factorial);
            Console.ReadKey();

        }
    }
}
