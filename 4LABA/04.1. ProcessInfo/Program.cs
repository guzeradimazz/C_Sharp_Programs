using System;
using System.Threading;
using ProcessInfo.ProcessInfo;

namespace ProcessInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = Info.Get();
            
            Console.WriteLine(info);
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}