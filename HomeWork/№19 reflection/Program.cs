using System.Reflection;

namespace _19_reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new();

            string methodName;

            if (args.Length > 0)
            {
                methodName = args[0];
            }
            else
            {
                Console.Write("Enter the name of the method to call: ");
                methodName = Console.ReadLine();
            }

            try
            {
                MethodInfo methodInfo = typeof(MyClass).GetMethod(methodName);

                if (methodInfo.Name == "Print")
                {
                    methodInfo.Invoke(obj, new object[] { "Hello World" });
                }
                else
                {
                    Console.WriteLine("Method not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    class MyClass
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}