using MemoryUsageApplication.Application;
using System.Diagnostics;

namespace MemoryUsageApplication
{
    public class Runner
    {
        MemoryMeasurement memory;

        void Main(string[] args)
        {
            memory = new MemoryMeasurement(0);
            memory.MemoryUsageInThread();
        }

    }
}