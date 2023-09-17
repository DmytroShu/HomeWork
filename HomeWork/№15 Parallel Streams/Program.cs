namespace _15_Parallel_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - display numbers from 1 to 10");
                Console.WriteLine("2 - display the letters A, B, C,");
                Console.WriteLine("0 - Exit");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.Clear();
                        PrintNumbers();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        PrintLetters();
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Error - Try again");
                        break;
                }
            }



        }
        static void PrintNumbers()
        {
            Thread thread1 = new(() =>
            {
                int a = -1;
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1);
                    Console.Write(a += 2);
                    Console.Write(" ");
                    Thread.Sleep(99);
                }
            });

            Thread thread2 = new(() =>
            {
                int b = 0;
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(b += 2);
                    Console.Write(" ");
                }
            });
            thread1.Start();
            thread2.Start();
        }
        static void PrintLetters()
        {
            Thread thread1 = new(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1);
                    Console.Write("A ");
                    Thread.Sleep(199);
                }
            });

            Thread thread2 = new(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write("B ");
                    Thread.Sleep(100);
                }
            });
            Thread thread3 = new(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("C");

                }
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}