using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class Node<T>
    {
        private T info;
        private Node<T> next;

        public Node(T info)
        {
            this.info = info;
            this.next = null;
        }
        public Node( T info , Node<T> next)
        {
            this.info = info;
            this.next = next;
        }
        public T Info { get => info; set => info = value; }
        public Node<T> Next { get => next; set => next = value; }
       
        public override string ToString()
        {
            string st = this.info+ " --> ";
            Node<T> p = this.next;
            while(p!=null)
            {
                if(p.next == null)
                    st += p.Info + " --> null|";
                else
                    st += p.Info + " --> ";
                p = p.Next;
            }

            return  st ;
        }
    }
}
