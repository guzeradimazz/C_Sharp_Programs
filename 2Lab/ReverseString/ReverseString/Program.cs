using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {   //reverse words position
        static string InputString, JustChangedString;
        static void ReverseFullString()
        {//to char->reverse->massiv
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
                InputString += ' ';
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string that u need to reverse");
            InputString = Console.ReadLine();
            ReverseFullString();
            ReverseEveryLetter();
            Console.WriteLine(InputString);
            Console.ReadLine();
        }
    }
}
