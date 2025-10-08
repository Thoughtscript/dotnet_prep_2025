using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOOD
{
    class ExampleGenerics
    {
        private class BinaryTree<T>
        {
            private T? _value;
            public T? Value {
                get => _value;
                set => _value = value;
             }

            private BinaryTree<T?>? _left;
            public BinaryTree<T?>? Left
            {
                get => _left;
                set => _left = value;
            }

            private BinaryTree<T?>? _right;
            public BinaryTree<T?>? Right
            {
                get => _right;
                set => _right = value;
            }

            public override string ToString()
            {
                return $"[V:{this._value} L:{(this._left is null ? "null" : this._left?.ToString())} R:{(this._right is null ? "null" : this._rightc?.ToString())}]";
            }
        }

        public static void Run()
        {
            Console.WriteLine("============== ExampleGenerics ==============");

            BinaryTree<string?> bts = new BinaryTree<string?>();
            bts.Value = "1";

            bts.Left = new BinaryTree<string?>();
            bts.Left.Value = "0";

            bts.Right = new BinaryTree<string?>();
            bts.Right.Value = "2";

            Console.WriteLine(bts.ToString());

            BinaryTree<int?> bti = new BinaryTree<int?>();
            bti.Value = 1;

            bti.Left = new BinaryTree<int?>();
            bti.Left.Value = 0;

            bti.Right = new BinaryTree<int?>();
            bti.Right.Value = 3;
            bti.Right.Left = new BinaryTree<int?>();
            bti.Right.Left.Value = 2;
            bti.Right.Right = new BinaryTree<int?>();
            bti.Right.Right.Value = 4;

            Console.WriteLine(bti.ToString());

        }
    }
}
