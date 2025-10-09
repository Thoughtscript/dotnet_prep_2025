namespace ExampleCollections
{
    class ExampleStacksAndQueues
    {
        private static string Print(List<int> input)
        {
            string result = "";
            for (int i = 0; input.Count > i; i++)
            {
                result += input[i].ToString();
            }

            return result;
        }

        // https://www.geeksforgeeks.org/dsa/next-greater-element/ - Medium - 20 Minutes Amazon, have solved before in Java.
        // Good excercise for greater C# Stack familiarity
        private static bool NextHighest(List<int> input, List<int> expected)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            // Think this has to be prepopulated for this algo set up
            for (int i = 0; i < input.Count; i++)
            {
                result.Add(-1);
            }

            // Must go from R to L for Linear Time
            for (int i = input.Count - 1; i >= 0; i--)
            {
                int N = input[i];
                // Remember to bifurcate or split the conditions - identify the base cases

                // Pop all below any j > i that's lte than input[j] wouldn't be the next greatest
                while(stack.Count > 0 &&  stack.Peek() <= N) // Use Peek with Guard - easier than TryPeek()
                                                             // Must be >= for all base cases
                {
                    stack.Pop();
                }

                // Determine if top of stack is greater
                if (stack.Count > 0 && stack.Peek() > N) // This can be simplified but is correct
                {
                    result[i] = stack.Peek();
                }
      
                // Always add
                stack.Push(N);
            }

            Console.WriteLine($"{Print(result)}");
            bool pass = Enumerable.SequenceEqual(result, expected);
            Console.WriteLine($"Test case {(Print(input))}: {(pass ? "PASSED" : "FAILED")}");
            return pass;
        }

        // https://www.geeksforgeeks.org/problems/immediate-smaller-element1142/1 - Medium - 20 Minutes Amazon, solved in 3 Minutes I think first time maybe not.
        private static bool NextLowest(List<int> input, List<int> expected)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Count; i++)
            {
                result.Add(-1);
            }

            // Going from R to L - probably easiest way to do these - remember!!
            for (int i = input.Count - 1; i >= 0; i--)
            {
                int N = input[i];

                while (stack.Count > 0 && stack.Peek() >= N)
                {
                    stack.Pop();
                    // Our unshift() going from L to R
                }

                if (stack.Count > 0)
                {
                    result[i] = stack.Peek();
                }

                stack.Push(N);
            }

            Console.WriteLine($"{Print(result)}");
            bool pass = Enumerable.SequenceEqual(result, expected);
            Console.WriteLine($"Test case {(Print(input))}: {(pass ? "PASSED" : "FAILED")}");
            return pass;
        }

        public static void RunNextHighest()
        {
            Console.WriteLine("============== BasicAlgos > NextHighest ==============");

            List<int> testA = new List<int>();
            testA.Add(5);
            testA.Add(6);
            testA.Add(1);
            testA.Add(2);
            testA.Add(7);
            List<int> expectedA = new List<int>();
            expectedA.Add(6);
            expectedA.Add(7);
            expectedA.Add(2);
            expectedA.Add(7);
            expectedA.Add(-1);
            NextHighest(testA, expectedA);

            List<int> testB = new List<int>();
            testB.Add(5);
            testB.Add(4);
            testB.Add(3);
            testB.Add(2);
            testB.Add(1);
            List<int> expectedB = new List<int>();
            expectedB.Add(-1);
            expectedB.Add(-1);
            expectedB.Add(-1);
            expectedB.Add(-1);
            expectedB.Add(-1);
            NextHighest(testB, expectedB);

            List<int> testC = new List<int>();
            testC.Add(1);
            testC.Add(2);
            testC.Add(3);
            testC.Add(4);
            testC.Add(5);
            List<int> expectedC = new List<int>();
            expectedC.Add(2);
            expectedC.Add(3);
            expectedC.Add(4);
            expectedC.Add(5);
            expectedC.Add(-1);
            NextHighest(testC, expectedC);

            List<int> testD = new List<int>();
            testD.Add(1);
            testD.Add(2);
            testD.Add(2);
            testD.Add(3);
            testD.Add(4);
            List<int> expectedD = new List<int>();
            expectedD.Add(2);
            expectedD.Add(3);
            expectedD.Add(3);
            expectedD.Add(4);
            expectedD.Add(-1);
            NextHighest(testD, expectedD);
        }

        public static void RunNextLowest()
        {
            Console.WriteLine("============== BasicAlgos > NextLowest ==============");

            List<int> testA = new List<int>();
            testA.Add(5);
            testA.Add(6);
            testA.Add(1);
            testA.Add(2);
            testA.Add(7);
            List<int> expectedA = new List<int>();
            expectedA.Add(1);
            expectedA.Add(1);
            expectedA.Add(-1);
            expectedA.Add(-1);
            expectedA.Add(-1);
            NextLowest(testA, expectedA);

            List<int> testB = new List<int>();
            testB.Add(5);
            testB.Add(4);
            testB.Add(3);
            testB.Add(2);
            testB.Add(1);
            List<int> expectedB = new List<int>();
            expectedB.Add(4);
            expectedB.Add(3);
            expectedB.Add(2);
            expectedB.Add(1);
            expectedB.Add(-1);
            NextLowest(testB, expectedB);

            List<int> testC = new List<int>();
            testC.Add(1);
            testC.Add(2);
            testC.Add(3);
            testC.Add(4);
            testC.Add(5);
            List<int> expectedC = new List<int>();
            expectedC.Add(-1);
            expectedC.Add(-1);
            expectedC.Add(-1);
            expectedC.Add(-1);
            expectedC.Add(-1);
            NextLowest(testC, expectedC);

            List<int> testD = new List<int>();
            testD.Add(1);
            testD.Add(2);
            testD.Add(2);
            testD.Add(3);
            testD.Add(4);
            List<int> expectedD = new List<int>();
            expectedD.Add(-1);
            expectedD.Add(-1);
            expectedD.Add(-1);
            expectedD.Add(-1);
            expectedD.Add(-1);
            NextLowest(testD, expectedD);

            List<int> testE = new List<int>();
            testE.Add(1);
            testE.Add(2);
            testE.Add(3);
            testE.Add(3);
            testE.Add(1);
            List<int> expectedE = new List<int>();
            expectedE.Add(-1);
            expectedE.Add(1);
            expectedE.Add(1);
            expectedE.Add(1);
            expectedE.Add(-1);
            NextLowest(testE, expectedE);
        }
    }
}