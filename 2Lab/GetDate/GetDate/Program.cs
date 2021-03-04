using System;

namespace LR2Task1
{
    class Program
    {
        static void Numbers(string STR, char letter)
        {
            int NumberInNUM = 0;
            for (int i = 0; i < STR.Length; i++)
            {
                if (STR[i] == letter) NumberInNUM++;
            }
            Console.WriteLine("In string finded " + letter + ": " + NumberInNUM);
        }

        static void Date(string str)
        {
            for (char i = '0'; i < '9'; i++)
            {
                Numbers(str, i);
            }
        }

        static void Main(string[] args)
        {
            string FirstString = DateTime.Now.ToString("F");
            string SecondString = DateTime.Now.ToString("g");
            Console.WriteLine("First String: " + FirstString);
            Date(FirstString);
            Console.WriteLine("\nSecond String: " + SecondString);
            Date(SecondString);
        }
    }
}