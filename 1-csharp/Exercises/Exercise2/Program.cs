using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size for the staircase: ");

            string userInput = Console.ReadLine();

            int staircaseSize = int.Parse(userInput);

            for (int i = 1; i <= staircaseSize; i++)
            {
                string padding = new string(' ', staircaseSize-i);
                string poundSign = new string('#', i);
                Console.WriteLine(padding + poundSign);
            }
        }
    }
}
