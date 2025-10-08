using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOD
{
    class ExampleSuperClass
    {
        private int _BackingInt = 0;
        public int PublicInt { get { return _BackingInt; } }

        private string? _BackingString = "";
        public string? PublicString {
            get { return _BackingString; }
            set => _BackingString = value; 
        }
    }

    class ExampleSubClass: ExampleSuperClass
    {
        public static void Run()
        {

            ExampleSubClass A = new ExampleSubClass();
            Console.WriteLine(A.PublicInt);
            A.PublicString = "A";
            Console.WriteLine(A.PublicString);
        }
    }
}
