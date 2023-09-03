using _10_Cars_fix;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose your car:");
            Console.WriteLine();
            Console.WriteLine("1. - Mercedes");
            Console.WriteLine("2. - BMW");
            Console.WriteLine("3. - Volkswagen");
            Console.WriteLine();
            Console.WriteLine("0. - Exit");
            string _choice = Console.ReadLine();
            try
            {
                
                switch (_choice)
                {
                    case "1":
                        car = new Mercedes();
                        car.Driving();
                        break;
                    case "2":
                        car = new Bmw();
                        car.Driving();
                        break;

                    case "3":
                        car = new Volkswagen();
                        car.Driving();
                        break;
                    case "0":
                        return;

                }
                
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(value: $"ERROR: ({ex}) You can try agene");
                Console.ReadLine();
            }
        }
    }
}