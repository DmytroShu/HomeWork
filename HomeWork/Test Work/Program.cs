class Program
{
    static async Task Main(string[] args)
    {
        int number = 10;

        int threadCount = args.Length > 0 ? int.Parse(args[0]) : ReadThreadCountFromConsole();

        Console.WriteLine("Starting asynchronous calculation...");
        Task<int> task = CalculateAsync(number);

        Console.WriteLine("Task started");
        int result = await task;

        Console.WriteLine("Result: " + result);
    }

    static async Task<int> CalculateAsync(int number)
    {
        // We use Task.Delay to simulate asynchrony
        //await Task.Delay(1000);

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
