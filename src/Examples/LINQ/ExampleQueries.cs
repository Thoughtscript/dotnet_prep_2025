using System.Collections.Generic;

namespace ExampleQueries
{
    public readonly struct ExampleReadOnlyStruct
    {
        public ExampleReadOnlyStruct(string message)
        {
            X = message;
        }

        public string X { get; }

    }

    class ExampleLINQQueries
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/write-linq-queries
        public static void Run()
        {
            Console.WriteLine("============== ExampleLINQQueries ==============");

            List<ExampleReadOnlyStruct> list = new List<ExampleReadOnlyStruct>();
            list.Add(new ExampleReadOnlyStruct("A"));
            list.Add(new ExampleReadOnlyStruct("B"));
            list.Add(new ExampleReadOnlyStruct("C"));
            list.Add(new ExampleReadOnlyStruct("D"));

            // LINQ queries are System.Collections.Generic.IEnumerable
            IEnumerable<ExampleReadOnlyStruct> firstQuery =
                from s in list
                where String.Equals(s.X, "B")
                select s;

            foreach (ExampleReadOnlyStruct s in firstQuery)
            {
                Console.WriteLine(s.X);
            }
            
            // With implicit type
            var secondQuery =
                from s in list
                where String.Equals(s.X, "C") || String.Equals(s.X, "A")
                orderby s.X
                select s;

            foreach (ExampleReadOnlyStruct s in secondQuery)
            {
                Console.WriteLine(s.X);
            }

            IEnumerable<ExampleReadOnlyStruct> thirdQuery = list
                .Where(s => String.Equals(s.X, "D"))
                .OrderBy(s => s);

            foreach (ExampleReadOnlyStruct s in thirdQuery)
            {
                Console.WriteLine(s.X);
            }
        }
    }
}