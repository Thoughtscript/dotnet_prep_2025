namespace ExampleStructs
{
    class ExampleStructs
    {
        private struct ExampleStruct
        {
            public ExampleStruct(string message)
            {
                X = message;
            }

            // get is standard to define here
            // init allows a field to be initialized differently through a with keyword
            public string X { get; init; }
        }

        // Note that 'ref struct': https://medium.com/@dmitrystadub/c-13-ref-struct-features-overview-e4b91a50afef works bit differently than say 'ref int'
        // Doesn't give the "address" but allocates onto the Stack not Heap - do this when superfast low overhead is needed!

        public static void Run()
        {

            var StructExampleA = new ExampleStruct("I'm a struct");
            Console.WriteLine(StructExampleA);
   
            Console.WriteLine(StructExampleA);
            // Pass by Value copy of StructExampleA
            var StructExampleB = StructExampleA;
            Console.WriteLine(StructExampleB);

            // Pass by Value copy of StructExampleA but with X "overridden"
            var StructExampleC = StructExampleA with { X = "I'm a modified message" };
            Console.WriteLine(StructExampleC);
        }
    }
}