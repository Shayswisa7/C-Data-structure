using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class Queue<T>
     {
         private Node<T> first;
         private Node<T> last;

         public Queue()
         {
             this.first = this.last = null;
         }
         public bool IsEmpty { get => this.first == null; }
         public void Insert( T x )
         {
             Node<T> temp = new Node<T>(x);
             if(first == null)
                 first = temp;
             else 
                 last.Next=temp;
             last = temp;
         }
         public T Remove
         {
             get
             {
                 T x = this.first.Info;
                 this.first = this.first.Next;
                 return x;
             }
         }
         public T Head{get => this.first.Info;}
         public override string ToString()
         {
             return "" + this.first.ToString();
         }

    }
}
