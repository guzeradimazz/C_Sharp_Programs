using System;
using System.Diagnostics;
using System.Text;

namespace ProcessInfo.ProcessInfo
{
    public class Info
    {
        public ProcessWrapper[] Processes { get; }

        private Info(ProcessWrapper[] processes)
        {
            Processes = processes;
        }

        public static Info Get()
        {
            ProcessWrapper[] wrappers = ProcessWrapper.GetAll();
            Array.Sort(wrappers, (firstWrapper, secondWrapper) => 
                secondWrapper.MemoryUsageInMB.CompareTo(firstWrapper.MemoryUsageInMB));
            
            return new Info(wrappers);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Working processes:\n");
            
            foreach (ProcessWrapper process in Processes)
            {
                builder.Append(process).Append('\n');
            }

            return builder.ToString();
        }
    }
}