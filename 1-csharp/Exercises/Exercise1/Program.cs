using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int StaircaseSize = 8;

            for (int i = 1; i <= StaircaseSize; i++)
            {
                string Padding = new string (' ', StaircaseSize-i);
                string PoundSign = new string ('#', i);
                Console.WriteLine(Padding + PoundSign);
            }
        }
    }
}
