using System.Linq.Expressions;
using System.Xml.Serialization;

namespace _7_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

                switch ( _choice )
                {
                    case "1":
                        Mercedes _mercedes = new Mercedes();
                        _mercedes.driving();
                        break;
                    case "2":
                        BMW _bmw = new BMW();
                        _bmw.driving();
                        break;

                    case "3":
                        Volkswagen _volkswagen = new Volkswagen();
                        _volkswagen.driving();
                        break;
                    case "0":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}