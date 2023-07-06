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
            //Console.WriteLine(masage.PrintNumber());
           
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
                Console.WriteLine();
                Console.WriteLine("0 - Exit");

                string chooice = Console.ReadLine();
                switch (chooice)
                {
                    case "1":
                        PrintConsole printConsole = new PrintConsole();
                        printConsole.Print();
                        break;
                    case "2":
                        PrintToFile printToFile = new PrintToFile();
                        break;
                    case "0":
                        return;
                    default: Console.WriteLine("Selection error, please try again");
                        break;

                }
            }
        }
    }
    public class PrinteMasage
    {
        //public string PrintNumber()
        //{   
        //    string j;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        j = i.ToString();
        //        return j;
        //    }
            
        //}
    }
}