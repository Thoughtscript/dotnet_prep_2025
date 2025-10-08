namespace ExampleDeclarations
{
    class ExampleDeclarations
    {
        // Not the same as a const
        // Must be a Field or in Constructor
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
        public readonly string ExampleReadOnlyString = "I'm not the same as a const";

        public static void Run()
        {
            Console.WriteLine("============== ExampleDeclarations ==============");

            var ExampleVar = "I'm an implicitly typed local variable";
            Console.WriteLine(ExampleVar);
            // Cannot assign null through var only through explicitly typed ? nullables.
            // Or non-value types.

            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
            const string ExampleConst = "I'm a constant variable";
            Console.WriteLine(ExampleConst);

            const string ExampleString = "I'm a string";
            // The interpolated string must also be a const!
            const string ExampleStringInterpolation = $"{ExampleString} has been interpolated";
            Console.WriteLine(ExampleStringInterpolation);

            string AnotherExampleString = "I'm another string";
            ref string StringReferenceExample = ref AnotherExampleString;
            Console.WriteLine(StringReferenceExample);

            object ExampleObject = "I'm a string object"; // alias for System.Object Class
            Console.WriteLine(ExampleObject);

            // CS8600 - Converting null literal or possible null value to non-nullable type
            String ALastExampleString = null; // This will compile and will boxed to string? apparently
            Console.WriteLine(ALastExampleString);

            //System.Int32 ExampleInteger = null; // Difference between Java and C#, this isn't a Wrapper/Reference Type that can be nullable.
            // int and System.Int32 are aliases

            System.Int32? ExampleInteger = null; // Set nullable here
            Console.WriteLine(ExampleInteger);
        }
    }
}