namespace ExampleComparisons
{
    class ExampleComparisons
    {
        public static void Run()
        {
            Console.WriteLine("============== ExampleComparisons ==============");

            string? ExampleNullString = null;
            bool NullCheck = ExampleNullString is null;
            Console.WriteLine(NullCheck);

            string EmptyString = string.Empty;
            bool EmptyCheck = EmptyString.Length == 0;
            Console.WriteLine("Printing empty string " + EmptyString);

            bool TypeCheck = ExampleNullString is string;
            Console.WriteLine(TypeCheck);

            Console.WriteLine(String.Equals(ExampleNullString, null));
            Console.WriteLine(ExampleNullString == null);

            bool ReferentialCheck = Object.ReferenceEquals(ExampleNullString, ExampleNullString);
            Console.WriteLine(ReferentialCheck);
        }
    }
}
