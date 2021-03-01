using System;

namespace SuffleString
{
    class Program
    {
        //effective method how to shuffle string
        static string InputString;
        static Random RandFunc = new Random();
        static void Shuffle()
        {
            char[] InputChar = InputString.ToCharArray();
            for (int i = InputString.Length - 1; i >= 1; i--)
            {
                int index = RandFunc.Next(i+1);
                char Temp = InputChar[index];
                InputChar[index] = InputChar[i];
                InputChar[i] = Temp;
            }
            for (int i = 0; i < InputChar.Length; i++)
            {
                Console.Write(InputChar[i]);
            }
        }
        static void Main(string[] args)
        {
            InputString = Console.ReadLine();
            Shuffle();
            Console.ReadLine();
        }
    }
}
