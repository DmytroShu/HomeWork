using System.Diagnostics;

namespace _17_Task_based_Asynchronous_Pattern
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw1 = new();
            Stopwatch sw2 = new();

            int number = 10;

            int threadCount = args.Length > 0 ? int.Parse(args[0]) : ReadThreadCountFromConsole();

            
            Console.WriteLine("Starting asynchronous calculation...");
            sw1.Start();
            Task<int> task = CalculateAsync(number);
            sw1.Stop();
            Console.WriteLine("Task started");
            int result1 = await task;
            
            Console.WriteLine("Result: " + result1);
            Console.WriteLine("Time Async: " + sw1.Elapsed.TotalMilliseconds);
            
            sw2.Start();
            int result2 = CalculateOne(number);
            sw2.Stop();
            Console.WriteLine("Result: " + result2);
            Console.WriteLine("Time: " + sw2.Elapsed.TotalMilliseconds);
        }
        static async Task<int> CalculateAsync(int number)
        {
            // We use Task.Delay to simulate asynchrony
            //await Task.Delay(1000);

            int square = number * number;

            return square;
        }
        static int CalculateOne(int number)
        {
            int square = number * number;

            return square;
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