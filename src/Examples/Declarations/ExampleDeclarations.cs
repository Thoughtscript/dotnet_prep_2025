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
            var ExampleVar = "I'm an implicitly typed local variable";
            Console.WriteLine(ExampleVar);

            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
            const string ExampleConst = "I'm a constant variable";
            Console.WriteLine(ExampleConst);

            const string ExampleString = "I'm a string";
            // The interpolated string must also be a const!
            const string ExampleStringInterpolation = $"{ExampleString} has been interpolated";
            Console.WriteLine(ExampleStringInterpolation);

            string AnotherExampleString = "I'm another string";
            ref string StringReferenceExample = ref AnotherExampleString;

        }
    }
}