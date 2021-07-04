using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class Stack<T>
    {
        private Node<T> first;

        public Stack()
        {
            this.first = null;
        }
        public bool IsEmpty { get => this.first == null; }
        public void Push(T x)
        {
            this.first  = new Node<T>(x,this.first);
        }
        public T Pop
        {
            get
            {
                 T x =this.first.Info;
                 this.first = this.first.Next;
                 return x;
            }
        }
        public T Top {  get=> this.first.Info; }
        public override string ToString()
        {
            return "Stack: " + this.first.ToString();
        }
    }
}
