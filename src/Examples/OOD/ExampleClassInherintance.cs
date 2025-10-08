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

        private int _num;
        public virtual int VirtualNumber // is implemented unlike abstract
        // but can be overridden
        {
            get { return _num; }
            set { _num = value; }
        }
    }

    class ExampleSubClass: ExampleSuperClass
    {
        private int _num;
        public override int VirtualNumber 
        {
            get { return _num + 1; }
            set { _num = value; }
        }

        public static void Run()
        {
            Console.WriteLine("============== ExampleSubClass ==============");

            ExampleSubClass A = new ExampleSubClass();
            Console.WriteLine(A.PublicInt);
            A.PublicString = "A";
            Console.WriteLine(A.PublicString);
            Console.WriteLine(A.VirtualNumber);
        }
    }
}
