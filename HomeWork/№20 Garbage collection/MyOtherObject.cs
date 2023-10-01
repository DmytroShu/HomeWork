namespace _20_Garbage_collection
{
    class MyOtherObject : IDisposable
    {
        private readonly string[] data;

        public MyOtherObject(string[] input)
        {
            data = input;
        }

        public void Dispose()
        {
            Console.WriteLine($"The number of elements in the array: {data.Length}");
            foreach (string item in data)
            {
                Console.WriteLine(item);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("The object MyOtherObject has been deleted.");
        }
    }

}