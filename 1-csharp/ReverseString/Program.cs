using System;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            Console.Write("Give me a string to reverse: ");
            string userInput = Console.ReadLine();

            char[] chars = userInput.ToCharArray();

            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                char tmp = chars[left];
                chars[left++] = chars[right];
                chars[right--] = tmp;
            }

            string reversedString = new string(chars);

            Console.Write("\"" + userInput + "\" reversed is \"" + reversedString + "\"");
        }
    }
}