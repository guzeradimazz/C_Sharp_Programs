using System;

namespace VowelReplace
{
    class Program
    {
        //Given a string consisting of lowercase English letters.
        //Replace all letters after the vowels in it with the following alphabetically (z is replaced by a).
        static string InputString;
        static void Change()
        {
            char[] TempChar = InputString.ToCharArray();
            for (int i = 0; i < TempChar.Length; i++)
            {
                if (TempChar[i] == 'A') TempChar[i] = 'Z';
                else if (TempChar[i] == 'E') TempChar[i] = 'F';
                else if (TempChar[i] == 'I') TempChar[i] = 'J';
                else if (TempChar[i] == 'O') TempChar[i] = 'P';
                else if (TempChar[i] == 'Y') TempChar[i] = 'Z';
                else if (TempChar[i] == 'a') TempChar[i] = 'z';
                else if (TempChar[i] == 'e') TempChar[i] = 'f';
                else if (TempChar[i] == 'i') TempChar[i] = 'j';
                else if (TempChar[i] == 'o') TempChar[i] = 'p';
                else if (TempChar[i] == 'y') TempChar[i] = 'z';
            }
            InputString = String.Empty;
            InputString = new string(TempChar);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string in english");
            InputString = Console.ReadLine();
            Change();
            Console.WriteLine(InputString);
            Console.ReadLine();
        }
    }
}
