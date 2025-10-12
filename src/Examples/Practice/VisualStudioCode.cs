namespace ExampleFun
{
    class SuperFun
    {
        private string _backingString = "";

        public virtual string Message
        {
            get => _backingString;
            set => _backingString = value;
        }
    }
    
    class Fun : SuperFun
    {
        private string _backingString = "";

        public override string Message
        {
            get => _backingString + "!";
            set => _backingString = value;
        }


        public static void Run()
        {
            Console.WriteLine("============== Visual Studio Code ==============");

            Fun B = new Fun();
            B.Message = "Added";
            Console.WriteLine(B.Message);

            List<string> A = new List<string>();
            A.Add("Hello!");
            A.Add("Goodbye!");

            foreach (string item in A)
            {
                Console.WriteLine(item);
            }

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1); // Visual Studio Code has great code completion/API Method lookups for C#!!
            // Visual Studio's gotten much better too and I prefer it's functionality overall.
        }
    }
}