using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Collatz sequence: ");

            string UserInput = Console.ReadLine();

            int Number = int.Parse(UserInput);

            while (Number != 1 && Number > 0)
            {
                if (Number % 2 == 0)
                {
                    Number /= 2;
                }
                else
                {
                    Number = Number * 3 + 1;
                }
                Console.WriteLine(Number);
            }
        }
    }
}
