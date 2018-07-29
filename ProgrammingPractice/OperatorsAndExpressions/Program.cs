using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmatic Operators
            var A = 10;
            var B = 20;

            Console.WriteLine(A + B);//add
            Console.WriteLine(A - B);//subtract
            Console.WriteLine(A * B);//MultiplySS
            Console.WriteLine(B / A);//Divide
            Console.WriteLine(B % A);//Remainder
            // ++ adds 1 and -- subtracts 1

            Console.WriteLine();
            Console.WriteLine();

            //Relational Operators
            Console.WriteLine(A == B);//Checks to see if the two values are TRUE
            Console.WriteLine(A !=B );//Checks to see if the two values are NOT TRUE
            Console.WriteLine();
            Console.WriteLine(A > B);//Checks if the value of left operand is GREATER THAN the right operand, if yes then the condition becomes TRUE
            Console.WriteLine(A < B);//Checks if the value of left operand is LESS THAN the right operand, if yes then the condition becomes TRUE
            Console.WriteLine(A >= B);//Greater than OR equal to
            Console.WriteLine(A <= B);//Less than OR equal to

            Console.WriteLine();
            Console.WriteLine();

            //Logical Operators
            // && AND Operaror
            // || OR Operator
            // ! NOT Operator

            //Translating Word Problems into C#

            //At a restaurant, Mike and his three friends decided to divide the bill evenly.
            //If each person paid $13 then what was the total bill?
            var people = 4;
            var pricePerPerson = 13;

            Console.WriteLine(people * pricePerPerson);

            //Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups.
            //How many more cups does she need to put in?
            var amountRecipeCallsFor = 7;
            var amountLisaPutIn = 2;

            Console.WriteLine(amountRecipeCallsFor - amountLisaPutIn);

            //How many packages of diapers can you buy with $40 if one package costs $8?
            var onePackOfDiapers = 8;
            var amountToSpend = 40;

            Console.WriteLine(amountToSpend / onePackOfDiapers);

            //Console.ReadLine() is a method that allows for input from the user.
            //Console.ReadLine() will always  take in the user input as a string. So, other data types, such as numbers must be converted.
            //For example, age is a number (int), but Console.ReadLine() by default will make it a string.
            //So, we use int.Parse() method to convert age to a number(int) data type.
            //int.Parse() is a method, so just like Console.ReadLine() and Console.WriteLine() it ends with a set of parentheses.

            //Example
            //Console.WriteLine("How old are you?");
            //string name = Console.ReadLine();
            //Console.WriteLine(name ", that's a nice name.");
            Console.ReadKey();
        }
    }
}
