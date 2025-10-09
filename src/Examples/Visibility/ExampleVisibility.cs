using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleVisibility
{
    file class ExampleFileClass
    {
        // Set on Class or Type at the top level
        // Only accessible within the same File
    }


    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    public class Visibilities
    {

        public string _PublicString = "I'm accessible anywhere: any Assembly, any Class";
        protected string _ProtectedString = "I'm accessible within the same Class and its Subclasses";
        private string _PrivateString = "I'm accessible within the same Class";

        internal string _InternalString = "I'm accessbile within the same Assembly";
        protected internal string _ProtectedInternalString = "I'm accessible within the same Class or its derived Classes OR within the same Assembly.";
        private protected string _PrivateProtectedString = "I'm accessible within the same Assembly AND  within the same Class or its derived Classes";

        public void Run()
        {
            Console.WriteLine("============== ExampleVisibility ==============");

            Console.WriteLine(_PublicString);
            Console.WriteLine(_ProtectedString);
            Console.WriteLine(_PrivateString);
            Console.WriteLine(_InternalString);
            Console.WriteLine(_ProtectedInternalString);
            Console.WriteLine(_PrivateProtectedString);
        }
    }
}
