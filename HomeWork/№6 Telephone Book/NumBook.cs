using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _6_Telephone_Book
{
    public class NumBook
    {
        private List<string> _numbersInTheBook = new List<string>();

        public void AddNumber()
        {
            string number;
            while (true)
            {
                Console.Clear();
                int intNumber;
                Console.WriteLine("Enter the number to add:");
                number = Console.ReadLine();
                if (int.TryParse(number, out intNumber))
                {
                    Console.WriteLine("Number added.");
                    break;
                }
                else Console.WriteLine("Incorrect number entered.");

                Console.WriteLine("Number added.");
            }
            Console.WriteLine("\r\nEnter the name to add:");
            string name = Console.ReadLine();
            Console.WriteLine("Name added.");
            Console.WriteLine();
            Console.WriteLine("Enter the address to add:");
            string address = Console.ReadLine();
            Console.WriteLine("Address added.");
            _numbersInTheBook.Add(number + " | " + name + " | " + address);
        }

        public void RemoveNumber(string findeItem)
        {
            string result = _numbersInTheBook.Find(item => item.Contains(findeItem));
            Console.WriteLine("Wont you remove this number?:  " + result);
            Console.WriteLine();
            Console.WriteLine("Make your choice:");
            Console.WriteLine("1. - Remove");
            Console.WriteLine("0. - Don't remove");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                _numbersInTheBook.Remove(result);
            }
            else if (choice == "0") 
            {
                Console.WriteLine("The number has not been deleted");
            }
            else Console.WriteLine("Not the right choice. The number has not been deleted");
        }

        public void PrintNumbers()
        {
            Console.WriteLine("List of numbers:");

            foreach (var number in _numbersInTheBook)
            {
                Console.WriteLine(number);
            }
        }

        public int GetTotalNumbers()
        {
            return _numbersInTheBook.Count;
        }

        public void ClearNumbers()
        {
            _numbersInTheBook.Clear();
            Console.WriteLine("The list of numbers is cleared.");
        }

        public void SearchNumber()
        {
            Console.WriteLine("Enter data to search:");
            string findeItem = Console.ReadLine();
            string result = _numbersInTheBook.Find(item => item.Contains(findeItem));
            Console.WriteLine(result);
        }

        public void SortByNumber()
        {
            _numbersInTheBook.Sort();
            Console.WriteLine("The list of numbers is sorted by number.");
            foreach (var number in _numbersInTheBook)
            {
                Console.WriteLine(number);
            }
        }

        public void SortByName()
        {
            _numbersInTheBook.Sort((x, y) =>
            {
                int xIndex = x.IndexOf("|");
                int yIndex = y.IndexOf("|");

                if (xIndex == -1 && yIndex == -1)
                {
                    return x.CompareTo(y);
                }
                else if (xIndex == -1)
                {
                    return -1;
                }
                else if (yIndex == -1)
                {
                    return 1;
                }
                else
                {
                    string xSubstring = x.Substring(xIndex);
                    string ySubstring = y.Substring(yIndex);
                    return xSubstring.CompareTo(ySubstring);
                }
            });
            Console.WriteLine("The list of numbers is sorted by name.");
            foreach (var number in _numbersInTheBook)
            {
                Console.WriteLine(number);
            }
        }
    }

}
