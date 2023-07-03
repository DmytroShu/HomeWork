namespace Test_Work
{
    interface IPrint
    {
        void Print();
    }

    public class PrintConsole : IPrint
    {
        public void Print()
        {
            PrinteMasage masage = new PrinteMasage();
            masage.PrintNumber();
        }
    }
    public class PrintToFile : IPrint
    {
        public void Print()
        {
            PrinteMasage masage = new PrinteMasage();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Console print");
                Console.WriteLine("2 - Print to file");

                string chooice = Console.ReadLine();
                switch (chooice)
                {
                    case "1":
                        PrintConsole printConsole = new PrintConsole();
                        break;
                    case "2":
                        PrintToFile printToFile = new PrintToFile();
                        break;
                    default: Console.WriteLine("Selection error, please try again");
                        break;

                }
            }
        }
    }
    public class PrinteMasage
    {
        public void PrintNumber()
        {   int j = 0;
            for (int i = 0; i < 10; i++)
            {
                return j;
            }
        }
    }
}