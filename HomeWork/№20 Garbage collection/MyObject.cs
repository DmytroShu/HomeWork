namespace _20_Garbage_collection
{
    class MyObject
    {
        public static void Run(string[] dataArray = null)
        {
            if (dataArray == null)
            {
                dataArray = new string[] { "One", "Two", "Three" };

                using MyOtherObject otherObj = new(dataArray);
            }
            else
            {
                using MyOtherObject otherObj = new(dataArray);
            }
            
        }
    }

}