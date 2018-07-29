using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker
{
    class Program
        /* Your client needs to print receipts when donations are received. Donations are received in ones, fives, tens, twenties,
         * fifties, hundreds, and quarters. Ask the user how many of each denomination are being donated, and print a receipt.
         * Your client wants the following information printed on the receipts:
            Name of Donor
            Address of Donor
            Email of Donor
            Fiscal Year
            Donation Amount */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your name.");
            var nameOfDoner = Console.ReadLine();
            Console.WriteLine("Thank you, " + nameOfDoner);
            Console.WriteLine("Now, " + nameOfDoner + ", what is your address?");
            var addressOfDoner = Console.ReadLine();
            Console.WriteLine(nameOfDoner + ", please enter your current email address.");
            var emailOfDoner = Console.ReadLine();
            Console.WriteLine("Please enter the current date");
            var currentDate = Console.ReadLine();
            Console.WriteLine("Please enter the amount you wish to donate today.");
            var donationAmount = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here's your receipt.");
            Console.WriteLine(nameOfDoner);
            Console.WriteLine(addressOfDoner);
            Console.WriteLine(emailOfDoner);
            Console.WriteLine(currentDate);
            Console.WriteLine(donationAmount);
            Console.WriteLine("Thank you for your donation! Have a nice day!");
            Console.ReadKey();
        }
    }
}
