using System;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            bool repeat = true;

            Console.Write("Welcome! What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine();

            while (repeat == true)
            {
                Console.Write("Enter a number between 1 and 100: ");
                int userNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (userNumber <= 0)
                {
                    Console.WriteLine("Please select a number between 1 and 100!");
                    Console.WriteLine();
                }
                else if (userNumber >= 100)
                {
                    Console.WriteLine("Please select a number between 1 and 100!");
                    Console.WriteLine();
                }
                else if (userNumber % 2 != 0 && userNumber <= 60)
                {
                    Console.WriteLine($"{name}, your number {userNumber}, is odd!");
                    Console.WriteLine();
                }
                else if (userNumber % 2 == 0 && userNumber <= 25)
                {
                    Console.WriteLine($"{name}, your number {userNumber}, is even and less than 25!");
                    Console.WriteLine();
                }
                else if (userNumber % 2 == 0 && userNumber <= 60)
                {
                    Console.WriteLine($"{userNumber}, Even!");
                    Console.WriteLine();
                }
                else if (userNumber % 2 == 0 && userNumber <= 100)
                {
                    Console.WriteLine($"{name}, your number {userNumber}, is even!");
                    Console.WriteLine();
                }
                else if (userNumber % 2 != 0 && userNumber <= 100)
                {
                    Console.WriteLine($"{userNumber}, Odd!");
                    Console.WriteLine();
                }
                else
                {

                }

                Console.Write("Continue? (y/n) ");
                again = Console.ReadLine();
                Console.WriteLine();

                if(again.Equals("y") || again.Equals("Y"))
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                    Console.WriteLine($"Bye {name}!");
                }
            }

        }
    }
}
