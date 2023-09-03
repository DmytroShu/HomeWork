using _12_LargeNumber;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Info:");
        Console.WriteLine("- This calculator works with large numbers.");
        Console.WriteLine("- Numbers and action (\"+\" or \"-\") must be written in one tape, example: 111+111");
        Console.WriteLine("- All other symbol are rewritten to \"0\"");
        string str;
        while (true)
        {
            Console.WriteLine();
            str = Console.ReadLine();
            if (str == "exit" || str == "EXIT" || str == "Exit")
            {
                return;
            }
            else
            {
                Console.WriteLine(LargeNumber.Reed(str));
            }

        }
    }
}