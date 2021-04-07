using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProcessInfo.ProcessInfo
{
    public class ProcessWrapper
    {
        public int Id { get; }
        public string Name { get; }
        public double MemoryUsageInMB { get; } 
        public int Priority { get; }

        private ProcessWrapper(int id, string name, double memoryUsage, int priority)
        {
            Id = id;
            Name = name;
            MemoryUsageInMB = memoryUsage;
            Priority = priority;
        }
        
        public static ProcessWrapper[] GetAll()
        {
            Process[] processes = Process.GetProcesses();
            List<ProcessWrapper> wrappers = new List<ProcessWrapper>();

            foreach (Process process in processes)
            {
                ProcessWrapper wrapper = new ProcessWrapper(
                    process.Id,
                    process.ProcessName,
                    process.WorkingSet64 / (1024 * 1024),
                    process.BasePriority
                );   
                
                wrappers.Add(wrapper);
            }

            return wrappers.ToArray();
        }

        public override string ToString()
        {
            return String.Format("Process: id - {0}, name - {1}, memory usage - {2} MB, priority - {3}",
                Id, Name, MemoryUsageInMB, Priority);
        }
    }
}