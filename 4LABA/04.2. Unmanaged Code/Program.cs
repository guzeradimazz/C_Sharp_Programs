using System;
using System.Runtime.InteropServices;

namespace Unmanaged_Code
{
    class Program
    {
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Sum(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Subtract(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Multiply(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Divide(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Mod(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Gcd(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Min(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Max(int a, int b);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int Abs(int a);
        
        [DllImport("math.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Pow(int a, int power);
        
        static void Main(string[] args)
        {
            Console.WriteLine("3 + 5 = " + Sum(3, 5));
            Console.WriteLine("10 - 7 = " + Subtract(10, 7));
            Console.WriteLine("4 * 6 = " + Multiply(4, 6));
            Console.WriteLine("10 / 2 = " + Divide(10, 2));
            Console.WriteLine("9 % 5 = " + Mod(9, 5));
            Console.WriteLine("gcd(24, 42) = " + Gcd(24, 42));
            Console.WriteLine("min(9, 7) = " + Min(9, 7));
            Console.WriteLine("max(9, 7) = " + Max(9, 7));
            Console.WriteLine("abs(-11) = " + Abs(-11));
            Console.WriteLine("2 ^ 3 = " + Pow(2, 3));

            Console.ReadKey();
        }
    }
}