using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void ArithmaticOperators(string[] args)
        {
            var A = 10;
            var B = 20;

            Console.WriteLine("A" + "B");
            Console.ReadLine();

            int addition = A + B;
            int subtraction = A - B;
            int multplication = A * B;
            int division = B / A;
            int remainder = B % A;
            int addOne = A++;
            int subtractOne = A--;
        }

        static void RelationalOperators(string[] args)
        {

        }
    }
}
