using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static string InputString, JustChangedString;

        static void ReverseFullString()
        {
            JustChangedString = new string(InputString.ToCharArray().Reverse().ToArray());
        }
        static void ReverseEveryLetter()
        {
            InputString = String.Empty;
            string[] StringWords = JustChangedString.Split(' ');
            for (int i = 0; i < StringWords.Length; i++)
            {
                char[] TempString = StringWords[i].ToCharArray();
                Array.Reverse(TempString);
                InputString += new string(TempString);
                if (i < StringWords.Length - 1)
                {
                    InputString += ' ';
                }
            }
        }
        static void Main(string[] args)
        {
            InputString = Console.ReadLine();
            ReverseFullString();
            ReverseEveryLetter();
            Console.WriteLine(InputString);
            Console.ReadLine();
        }
    }
}
