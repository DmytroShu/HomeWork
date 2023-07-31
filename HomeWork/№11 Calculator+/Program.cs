
using _11_Calculator_;
using System.Text.RegularExpressions;

namespace Calculator_
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string expression = Console.ReadLine();
                    Console.WriteLine(Test(expression));
                }
                catch (Exception ex)
                    {
                    Console.WriteLine("Incorrect expression, please try again");
                    }
            }

        }
        static string Test (string expression)
        {
            string[] substrings = Regex.Split(expression, @"([+\-*/()])");
            if (substrings.Length <= 2) 
            {
                return expression;
            }
            else
            {
                string forTest = Reed(expression);
                return Test (forTest);
            }
        }
        static string Reed(string str)
        {
            int index1 = str.IndexOf('(');
            int index2 = str.IndexOf(')');

            if (index1 == -1 && index2 == -1)
            {
                string[] substrings = Regex.Split(str, @"([+\-*/()])");
                return Calculate.FindAction(substrings);
            }
            else
            {
                if (index1 != -1)
                {
                    
                    string part1 = str.Substring(0, index1);
                    string part2 = str.Substring(index1 + 1);
                    if (part1 == "")
                    {
                        return Reed(part2);
                    }
                    else
                    {
                        string lastChar = part1.Substring(part1.Length - 1);
                        if (!double.TryParse(lastChar, out double sub))
                        {
                            part1 = part1 + Reed(part2);
                            return Reed(part1);
                        }
                        else
                        {
                            part1 = part1 + "*" + Reed(part2);
                            return Reed(part1);
                        }
                    }
                }
                else
                {
                    string part1 = str.Substring(0, index2);
                    string part2 = str.Substring(index2 + 1);
                    if (part2 == "")
                    {
                        return Reed(part1);
                    }
                    else
                    {
                        string firstChar = part2.Substring(0,1);
                        if (!double.TryParse(firstChar, out double sub))
                        {
                            part2 = Reed(part1) + part2;
                            return part2;
                        }
                        else
                        {
                            part2 = Reed(part1) + "*" + part2;
                            return part2;
                        }
                    }
                }
            }      
        }
    }
}