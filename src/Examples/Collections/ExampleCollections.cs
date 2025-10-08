using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCollections
{
    class ExampleCollections
    {
        public static void Run()
        {
            Console.WriteLine("============== ExampleCollections ==============");

            List<string> ExampleList = new List<string>();
            ExampleList.Add("List -> A");
            ExampleList.Add("List -> B");
            ExampleList.ForEach(a => Console.WriteLine(a)); // lambda
            ExampleList.RemoveAt(0);

            // foreach equivalent
            foreach(string ExampleString in ExampleList)
            {
                Console.WriteLine(ExampleString);
            }

            // Unordered deduplicating
            HashSet<string> ExampleSet = new HashSet<string> { "Set -> A", "Set -> B", "A" };
            ExampleSet.Add("Set -> A");
            ExampleSet.Add("Set -> B");
            ExampleSet.RemoveWhere(a => String.Equals(a, "A"));
            Console.WriteLine(ExampleSet.ToString()); // Doesn't print members

            foreach (string ExampleString in ExampleSet)
            {
                Console.WriteLine(ExampleString);
            }

            Stack<string> ExampleStack = new Stack<string>();
            ExampleStack.Push("Stack -> C");
            ExampleStack.Push("Stack -> A");
            ExampleStack.Push("Stack -> B");
            ExampleStack.Pop();
            Console.WriteLine(ExampleStack.First());
            Console.WriteLine(ExampleStack.ToString()); // Doesn't print members
            foreach (string ExampleString in ExampleStack)
            {
                Console.WriteLine(ExampleString);
            }

            string[] ExampleArray = ExampleStack.ToArray();
            Console.WriteLine(ExampleArray.ToString()); // Doesn't print members

            for (int i = 0; i < ExampleArray.Length; i++)
            {
                Console.WriteLine("Array -> " + ExampleArray[i]);
            }
        }
    }
}
