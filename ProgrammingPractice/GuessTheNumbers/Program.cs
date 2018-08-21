using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string playAgain = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Guess The Numbers! Here's how you play: \nPick a range between two numbers, such as 12 and 65. \nThen, you pick six numbers within that range.");
                Console.WriteLine("Your opponent, the computer, will pick six numbers within your range. \nIf you can possibly guess all six of the computer's numbers correctly,\nyou might win $1...maybe...probably not.");
                Console.WriteLine("Anyways, let's get started. \n");

                int firstUserNum;
                int secondUserNum;

                //nag them making sure they give numbers that aren't equal to each other
                do
                {
                    Console.WriteLine("Please enter the first number for the range the computer will select it's numbers from:");
                    firstUserNum = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the second number for the range the computer will select it's numbers from:");
                    secondUserNum = int.Parse(Console.ReadLine());
                    if (secondUserNum <= firstUserNum)
                    {
                        Console.WriteLine("Invalid. Please enter two different numbers.\n");

                    }
                }
                while (secondUserNum <= firstUserNum);

                Console.WriteLine("Thank you.");


                //user array
                int[] luckyGuess = new int[6];

                Console.WriteLine("Now, see if you can guess a number from within your range.");

                for (int i = 0; i < luckyGuess.Length; i++)
                {
                    luckyGuess[i] = int.Parse(Console.ReadLine());
                    if (luckyGuess[i] < firstUserNum || luckyGuess[i] > secondUserNum)
                    {
                        Console.WriteLine("Please enter a valid number. Pick a number between " + firstUserNum + " and " + secondUserNum + ".");
                    }
                    else
                    {
                        Console.WriteLine("Now, guess another!");
                    }
                }

                Console.WriteLine("Thank you!\n");


                //winning numbers array
                int correctGuesses = 0;

                Random random = new Random();
                int[] luckyNum = new int[6];

                for (int i = 0; i < luckyNum.Length; i++)
                {
                    int winningNumber;

                    do
                    {
                        winningNumber = random.Next(secondUserNum) + 1;
                    }
                    while (luckyNum.Contains(winningNumber));

                    luckyNum[i] = winningNumber;
                    
                }


                foreach (int winningNumber in luckyNum)
                {
                    Console.WriteLine("Lucky Number: " + winningNumber);
                }


                //compare the user and computer's arrays
                foreach (int number in luckyGuess)
                {
                    if (luckyNum.Contains(number))
                    {
                        correctGuesses++;
                    }
                }

                Console.WriteLine("You guessed " + correctGuesses + " correctly!");




                int jackpot = 0;
                int prizeMoney;

                if (correctGuesses == 6)
                {
                    Console.WriteLine("WOW! You got them all...you must have cheated! $" + jackpot + " to you!");
                }
                else if (correctGuesses == 0)
                {
                    Console.WriteLine("You lose. No correct guesses, and no prize money for you!");
                }
                else
                {
                    prizeMoney = jackpot / correctGuesses;
                    Console.WriteLine("You have won $" + prizeMoney + "! So congrats! You wasted your time...");
                }


                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToLower();
            }

            while (playAgain == "yes");

            if (playAgain == "no")
            {
                Console.WriteLine("Thanks for trying!");
            }
        }
    }
}