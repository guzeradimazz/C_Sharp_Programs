using System;

namespace _7Lab
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Standart operations:");
            var DecimalOne = new Fraction(1, 2);
            var DecimalSecond = new Fraction(2, 3);
            var DecimalSum = DecimalOne + DecimalSecond;
            Console.WriteLine(DecimalSum);
            var DecimalThird = new Fraction(4, 5);
            var DecimalForth = new Fraction(6, 7);
            var DecimalMultiple = DecimalThird * DecimalForth;
            Console.WriteLine(DecimalMultiple);
            var DecimalClonned = DecimalOne.Clone();
            Console.WriteLine(DecimalClonned);
            
            Console.WriteLine("Decimal in different formats:");
            Fraction DecimalConvartion = new Fraction(8, 9);
            Console.WriteLine("{0:S}", DecimalConvartion);
            Console.WriteLine("{0:M}", DecimalConvartion);
            Console.WriteLine("{0:D}", DecimalConvartion);
            Console.WriteLine("{0:I}", DecimalConvartion);

            Console.WriteLine("Coversion:");
            Console.WriteLine((short)DecimalConvartion);
            Console.WriteLine((int)DecimalConvartion);
            Console.WriteLine((long)DecimalConvartion);
            Console.WriteLine((float)DecimalConvartion);
            Console.WriteLine((double)DecimalConvartion);
            Console.WriteLine(Convert.ToBoolean(DecimalConvartion));
            Console.WriteLine(Convert.ToString(DecimalConvartion));

            Console.WriteLine("Comparing:");
            var DecimalFifth = new Fraction(10, 11);
            var DecimalSix = new Fraction(12, 13);
            Console.WriteLine(DecimalFifth > DecimalSix);
            Console.WriteLine(DecimalFifth != DecimalSix);

            Console.ReadKey();
        }
    }
}