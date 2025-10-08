using System.Runtime.CompilerServices;

namespace ExampleAbstractions
{
    interface ExampleAbstraction
    {

        public void ExampleAbstractMethod();
    }

    abstract class ExampleAbstractClass
    {
        private string _StringField = "I'm a string!";
        public string StringField => _StringField;

        // Must be implemented - not initialized here
        public abstract int PublicNumber { get; set; }

        public void ExampleConcreteMethod()
        {
            Console.WriteLine("I'm a concrete method!");
        }
    }

    // No Multiple Inheritance using Classes alone
    // Implementation and Subclassing of an Abstract Class

    class ExampleImplementation : ExampleAbstractClass, ExampleAbstraction
    {
        public int _ConcreteBackingNumber = 100;

        // Uses override keyword here
        public override int PublicNumber { 
            get => _ConcreteBackingNumber; 
            set => _ConcreteBackingNumber = value; 
        }

        public void ExampleAbstractMethod()
        {
            Console.WriteLine("I'm an implemented concrete method!");
        }

        public static void Run()
        {
            Console.WriteLine("============== ExampleAbstraction ==============");

            ExampleImplementation A = new ExampleImplementation();
            Console.WriteLine(A.StringField);
            A.ExampleConcreteMethod();
            Console.WriteLine(A.PublicNumber);
        }
    }
}