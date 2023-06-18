namespace _5
{
    internal class Program
    {
        private static int valu;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter you number");
            int val = int.Parse (Console.ReadLine());
            if (val > 2)
            {
                Console.WriteLine(FindPrimeNumber(val));  //Search initialization
            }
            else if (val == 2)
            {
                Console.WriteLine("3");
            }
            else if (val == 1)
            {
                Console.WriteLine("2");
            }
            else Console.WriteLine("Error");

        }
        static int FindPrimeNumber(int value)   //Search by order
        {
            int num = 4;
            for (int i = 3; i <= value; i++)
            {
                num = PrimeNumber(num);
            }
            return num;
        }
        static int PrimeNumber(int number)      //The process of finding a prime number
        {
            int divider = 3;
            int math;
            number = number + 1;
            while (true)
            {
                if (number % 2 == 0)
                {
                    number++;
                }
                else if (number > divider)
                {
                    math = number % divider;
                    if (math != 0)
                    {
                        divider++;
                    }
                    else number++;
                }
                else
                {
                    return number;
                }
            }
        }
    }
}