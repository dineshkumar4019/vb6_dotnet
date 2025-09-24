using System;
using LegacyService.Services;

namespace LegacyService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LegacyService v1.0 (Framework 3.5)");
            var proc = new Processor(new DataAccess());
            proc.RunBatch("orders.csv");
            Console.WriteLine("Done. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
