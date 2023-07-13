using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Test_Work
{
    internal class Program
    {
        static readonly int _literation = 1000000;


        static void Main(string[] args)
        {
            List<int> val = new List<int>();
            Random random = new Random();
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            for (int i = 0; i < _literation; i++)
            {

                val.Add(random.Next());
            }

            sw1.Start();
            Value(val);
            sw1.Stop();

            sw2.Start();
            ToString(val);
            sw2.Stop();

            Console.WriteLine("int by int:    " + sw1.Elapsed.TotalMilliseconds);
            Console.WriteLine("int by string: " + sw2.Elapsed.TotalMilliseconds);

        }
        static void Value(List<int> lst)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < _literation; i++)
            {

                list.Add(lst[i]);
            }


        }
        static void ToString(List<int> lst)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < _literation; i++)
            {

                list.Add(Convert.ToString(lst[i]));
            }
        }
        
    }

}