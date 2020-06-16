using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a size for the staircase: ");

            string UserInput = Console.ReadLine();

            int StaircaseSize = int.Parse(UserInput);

            for (int i = 1; i <= StaircaseSize; i++)
            {
                string Padding = new string (' ', StaircaseSize-i);
                string PoundSign = new string ('#', i);
                Console.WriteLine(Padding + PoundSign);
            }
        }
    }
}
