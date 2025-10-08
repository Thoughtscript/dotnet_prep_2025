namespace ExampleArrays
{
    class ExampleArrays
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("============== ExampleArray ==============");

                string[] ExampleArray = { "d", "c", "a", "b" };
                Array.Sort(ExampleArray);

                for (int i = 0; i < ExampleArray.Length; i++)
                {
                    Console.WriteLine("Array -> " + ExampleArray[i]);
                }

                string[] AnotherExampleArray = { "d", "c", "a", "b" };

                Console.WriteLine(Array.Equals(ExampleArray, AnotherExampleArray));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}