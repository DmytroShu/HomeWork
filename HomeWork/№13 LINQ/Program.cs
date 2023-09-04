using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8 };
        while (true)
        {
            UI();
            string reader = Console.ReadLine();
            switch (reader)
            {
                case "1":
                    Console.Clear();
                    _ = int.TryParse(Console.ReadLine(), out int result);
                    list.Add(result);
                    break;
                case "2":
                    Console.Clear();
                    Show(list);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Show(list.OrderBy(x => x).ToList());
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Show(list.OrderByDescending(x => x).ToList());
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    _ = int.TryParse(Console.ReadLine(), out int num);
                    Show(list.Where(x => x == num).ToList());
                    Console.ReadLine();
                    break;
                case "6":
                    Console.Clear();
                    _ = int.TryParse(Console.ReadLine(), out int numberToRemove);
                    list.Remove(numberToRemove);
                    Console.ReadLine();
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("Exit");
                    Console.ReadLine();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadLine();
                    break;
            }
        }
        
    }
    static void UI()

    {
        Console.Clear();
        Console.WriteLine(". . . . Menu . . . .");
        Console.WriteLine();
        Console.WriteLine("Make your choice:");
        Console.WriteLine("1. - Add new items");
        Console.WriteLine("2. - Show all items");
        Console.WriteLine("3. - Sort by height");
        Console.WriteLine("4. - Sort to lowest value");
        Console.WriteLine("5. - Search items");
        Console.WriteLine("6. - Delete items");
        Console.WriteLine();
        Console.WriteLine("0. - Exit");
        Console.WriteLine();
    }
    static void Show( List<int> list )
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
}