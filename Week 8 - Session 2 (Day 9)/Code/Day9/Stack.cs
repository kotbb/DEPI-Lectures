using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Stack<T>
    {
        private T[] _items;
        private int _top;
        private int _capacity;

        public Stack(int Capacity = 10)
        {
            _capacity = Capacity;
            _items = new T[_capacity];
            _top = -1;
        }
        public void Push(T value)
        {
            _items[++_top] = value;
            Console.WriteLine($"Pushed {value} to stack");
        }
        public T Pop() 
        {
            Console.WriteLine($"Poped {_items[_top]} from stack");
            return _items[_top--];
        }

        public T Peek()
        {
            return _items[_top];
        }
    }
}
