using System.Collections.Concurrent;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        private static readonly object syncObject = new();
        static void Main(string[] args)
        {
            Stopwatch sw1 = new();
            Stopwatch sw2 = new();
            int[] numbers = Enumerable.Range(1, 1000000).ToArray();

            int threadCount = args.Length > 0 ? int.Parse(args[0]) : ReadThreadCountConsole();

            sw1.Start();
            long sum = Calculate(numbers, threadCount);
            sw1.Stop();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Time: " + sw1.Elapsed.TotalMilliseconds);

            sw2.Start();
            long sum2 = CalculateOne(numbers);
            sw2.Stop();
            Console.WriteLine("Sum: " + sum2);
            Console.WriteLine("Time: " + sw2.Elapsed.TotalMilliseconds);
        }

        static long Calculate(int[] numbers, int threadCount)
        {
            long sum = 0;

            // We divide the array of numbers into parts for processing in different streams
            var partitions = Partitioner.Create(0, numbers.Length, numbers.Length / threadCount);

            Parallel.ForEach(partitions, range =>
            {
                long localSum = 0;

                for (int i = range.Item1; i < range.Item2; i++)
                {
                    localSum += CalculateSum(numbers[i]);
                }

                lock (syncObject)
                {
                    sum += localSum;
                }
            });

            return sum;
        }
        static long CalculateOne(int[] numbers)
        {
            long sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += CalculateSum(numbers[i]);
                }
            return sum;
        }
        static long CalculateSum(int number)
        {
            return (long)number * number;
        }

        static int ReadThreadCountConsole()
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