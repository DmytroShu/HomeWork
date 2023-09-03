namespace D_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "1":
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.ReadLine();
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);

                }
                
            }
        }
    }
}