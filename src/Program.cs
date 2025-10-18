/*
 * using Directives come first
 * Only valid place for top-level statements is here
 * https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
 * Should not be used with Main
 */

//var topLevelExample = new { message = "example" };
//Console.WriteLine(topLevelExample);

using ExampleVisibility;

namespace Main
{
    class ApplicationMain
    {
        static void Main(string[] args)
        {
            ExampleArrays.ExampleArrays.Run();
            ExampleCollections.ExampleCollections.Run();
            ExampleCollections.ExampleStacksAndQueues.RunNextHighest();
            ExampleCollections.ExampleStacksAndQueues.RunNextLowest();

            ExampleReferences.ExampleReferences.Run();
            ExampleDeclarations.ExampleDeclarations.Run();
            ExampleComparisons.ExampleComparisons.Run();
            
            ExampleAbstractions.ExampleImplementation.Run();
            ExampleOOD.ExampleSubClass.Run();
            ExampleOOD.ExampleGenerics.Run();
            Visibilities exampleVisibility = new Visibilities();
            exampleVisibility.Run();

            ExampleQueries.ExampleLINQQueries.Run();

            ExampleAsync.ExampleTasks.Run();

            CustomEvents.EventExample.Run();

            ExampleFun.Fun.Run();
        }
    }
}