using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nWelcome to our Totally Accurate Fortune Teller. \nPlease enter your first name.");
            var userFirstName = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter your last name.");
            var userLastName = Console.ReadLine().ToUpper();

            Console.WriteLine("How old are you?");
            int years = int.Parse(Console.ReadLine());
            int retirement;

            if (years <= 29)
            {
                Console.WriteLine("So, you come here often?");
            }
            else if (years >= 30)
            {
                Console.WriteLine("FUCK, you're old!");
            }

            if ((years % 2) == 0)
            {
                retirement = 25;
            }
            else
            {
                retirement = 33;
            }

            Console.WriteLine("So, what month were you born in? Use numbers 1-12.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("I always hated that time of year.");
            string money;

            if (month >= 1 && month <= 4)
            {
                month = 100;
                money = "100 quintillion dollars";
            }
            else if (month >= 5 && month <= 8)
            {
                month = 69;
                money = "sixty-nine thousand dollars";
            }
            else if (month >= 9 && month <= 12)
            {
                month = 1;
                money = "one hundred thousand dollars";
            }
            else
            {
                money = "nothing, cause fuck you,";
            }

            Console.WriteLine("Whaat's your favorite color? Type \"help\" to list your options.");
            string color = Console.ReadLine().ToLower();

            if (color == "help")
            {
                Console.WriteLine("You can choose either red, orange, yellow, green, blue, indigo, or violet.");
                color = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Black is best.");
            }


            if (color == "red")
            {
                color = "a red Ferrari 488 GTB";
            }
            else if (color == "orange")
            {
                color = "an orange Ford GT";
            }
            else if (color == "yellow")
            {
                color = "a yellow McLaren 720S";
            }
            else if (color == "green")
            {
                color = "a green Lamborghini Huracán";
            }
            else if (color == "blue")
            {
                color = "a blue Noble M600";
            }
            else if (color == "indigo")
            {
                color = "an indigo Tushek Renovatio T500";
            }
            else if (color == "violet")
            {
                color = "a violet Tesla Model S";
            }
            else
                color = "a piece o' shit mini-van";
            
            Console.WriteLine("And finally, how many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string city;

            if (siblings == 0)
            {
                city = "Los Angeles";
            }
            else if (siblings == 1)
            {
                city = "New York";
            }
            else if (siblings == 2)
            {
                city = "London";
            }
            else if (siblings == 3)
            {
                city = "Dublin";
            }
            else if (siblings > 3)
            {
                city = "Paris";
            }
            else
            {
                city = "just kidding, you don't";
            }

            Console.WriteLine("Here is your fortune:");
            Console.WriteLine(userFirstName + " " + userLastName + " will retire in " + retirement + " years with "
                + money + " in the bank, a \nvacation home in " + city + ", and " + color + ".");
            Console.ReadKey();



        }
    }
}