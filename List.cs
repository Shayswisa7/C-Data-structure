using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class List<T>
    {
        private Node<T> first;

        public List()
        {
            this.first = null;
        }
        public bool IsEmpty{ get => this.first == null; }
        public Node<T> First { get => this.first; }
        public Node<T> Insert( Node<T> pos, T x )
        {
            Node<T> temp = new Node<T>(x);
            if(pos == null)
            {
                temp.Next=this.first;
                this.first = temp;
            }
            else
            {
                temp.Next=pos.Next;
                pos.Next=temp;
            }
            return temp;
        }
        public Node<T> Remove(Node<T> pos)
        {
            if(this.first == pos)
                this.first = pos.Next;// or null
            else
            {
                Node<T> prevPos = this.first.Next;
                while(prevPos.Next != pos)
                    prevPos = prevPos.Next;
                prevPos.Next=pos.Next;
            }

            Node<T> nextpos = pos.Next;
            pos.Next=null;
            return nextpos; 
        }
        public override string ToString()
        {
            return "List: " + this.first.ToString();
        }
    }
}
