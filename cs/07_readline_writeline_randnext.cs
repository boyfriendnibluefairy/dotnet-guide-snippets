using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInput = "";
            int iInput = 0;
            int answer = 0;
            int guessCounter = 0;

            // Generate Randon integer between 0 and 20
            Random rand = new Random();
            answer = rand.Next(0, 100);
            
            Console.WriteLine("\n=================================");
            Console.WriteLine("Time to play 'GUESS THE NUMBER'!");
            Console.WriteLine("I'm thinking of number between 0 and 100");
            Console.WriteLine("Type your guess, or -1 to give up");
            Console.WriteLine("What's your guess?");
            Console.WriteLine("=================================\n");

            do
            {
                Console.WriteLine(" ");
                Console.Write("---------> ");
                sInput = Console.ReadLine();
                guessCounter++;
                if(int.TryParse(sInput, out iInput))
                {
                    if(iInput == answer)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"You got it in {guessCounter} guess(es)!!!");
                    }
                    else if (iInput < answer)
                    {
                        Console.WriteLine("Nope, higher than that.");
                        Console.WriteLine("What's your guess?");
                    }
                    else
                    {
                        Console.WriteLine("Nope, lower than that.");
                        Console.WriteLine("What's your guess?");

                    }
                }
                else
                {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                    Console.WriteLine("What's your guess?");
                }

            } while (iInput != (-1));

        }
    }
}
