namespace _6_Telephone_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumBook numBook = new NumBook();

            while (true)
            {
                Console.WriteLine(". . . . Menu . . . .");
                Console.WriteLine();
                Console.WriteLine("Make your choice:");
                Console.WriteLine("1. - Add new number");
                Console.WriteLine("2. - Show all numbers");
                Console.WriteLine("3. - Sort by number");
                Console.WriteLine("4. - Sort by name");
                Console.WriteLine("5. - Search Number");
                Console.WriteLine("6. - Delete number");
                Console.WriteLine("7. - Clear Numbers");
                Console.WriteLine();
                Console.WriteLine("0. - Exit");

                string reader = Console.ReadLine();
                switch (reader)
                {
                    case "1":
                        Console.Clear();
                        numBook.AddNumber();
                        break;
                    case "2":
                        Console.Clear();
                        numBook.PrintNumbers();
                        break;
                    case "3":
                        Console.Clear();
                        numBook.SortByNumber();
                        break;
                    case "4":
                        Console.Clear();
                        numBook.SortByName();
                        break;
                    case "5":
                        Console.Clear();
                        numBook.SearchNumber();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Enter the number to delete:");
                        string numberToDelete = Console.ReadLine();
                        numBook.RemoveNumber(numberToDelete);
                        break;
                    case "7":
                        Console.Clear();
                        numBook.ClearNumbers();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}