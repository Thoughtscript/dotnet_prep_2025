using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleReferences
{
    class ExampleReferences
    {
        public static void Run()
        {
            Console.WriteLine("============== ExampleReferences ==============");

            string ExampleA = "I'm a string";
            string ExampleB = "I'm another string";

            Console.WriteLine(ExampleA.GetHashCode());
            Console.WriteLine(ExampleB.GetHashCode());
            ref string ExampleRefString = ref ExampleA;
            Console.WriteLine(ExampleRefString);

            ExampleRefString = ExampleB;

            // Note that the ref address itself isn't printed (but the value)
            // This prints the actual object hash
            Console.WriteLine(ExampleRefString.GetHashCode());
            Console.WriteLine(ExampleRefString);

            Console.WriteLine(ExampleA); // This will now be the same as B
            Console.WriteLine(String.Equals(ExampleA, ExampleB));
            Console.WriteLine(String.Equals(ExampleRefString, ExampleA));
            Console.WriteLine(ExampleA.GetHashCode() == ExampleB.GetHashCode());
        }
    }
}
