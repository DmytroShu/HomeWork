namespace _20_Garbage_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dataArray = new string[] { "O", "T", "Th" };
            MyObject.Run(dataArray);

            Console.WriteLine("Press any key to complete...");
            Console.ReadKey();
        }
    }
}