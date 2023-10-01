using System.Diagnostics;

namespace _18_Parallel_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxRage = 1000000000;
            int threadCount = args.Length > 0 ? int.Parse(args[0]) : ReadThreadCountFromConsole();

            int[] numbers = Enumerable.Range(1, maxRage).ToArray();
            Console.WriteLine("Processing using PLINQ...");
            Stopwatch sw1 = Stopwatch.StartNew();
            var result = numbers.AsParallel()
                .WithDegreeOfParallelism(threadCount)
                .Where(x => x % 2 == 0)
                .Select(x => x * x)
                .ToList();
            sw1.Stop();

            Console.WriteLine("Processing without PLINQ...");
            Stopwatch sw2 = Stopwatch.StartNew();
            var resultWithoutPLINQ = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * x)
                .ToList();
            sw2.Stop();

            Console.WriteLine("Result: " + result.Count);
            Console.WriteLine("Elapsed time using PLINQ: " + sw1.Elapsed.TotalMilliseconds);

            Console.WriteLine("Result without PLINQ: " + resultWithoutPLINQ.Count);
            Console.WriteLine("Elapsed time without PLINQ: " + sw2.Elapsed.TotalMilliseconds);
        }
        static int ReadThreadCountFromConsole()
        {
            Console.Write("Enter the number of threads to run in parallel: ");
            int threadCount;
            while (!int.TryParse(Console.ReadLine(), out threadCount) || threadCount <= 0)
            {
                Console.Write("Enter the correct number of threads: ");
            }
            return threadCount;
        }
    }
}