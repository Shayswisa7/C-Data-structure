using System;

namespace Works
{
    class Program
    {
        static void Main( string [] args )
        {
            Rupin.Second_Main();
        }
        //                'שאלה 6 מתכונת ב
        //________________________________________
        public static int Distance(List<int> list)
        {
            /*
            Node<int> a = new Node<int>(1, new Node<int>(3, new Node<int>(1, new Node<int>(4, new Node<int>(2,new Node<int>(6))))));
            Stack<int> a1 = new Stack<int>();
            Queue<int> que = new Queue<int>();
            Console.WriteLine(a);
            while(a!=null)
            {
                que.Insert(a.Info);
                a1.Push(a.Info);
                a = a.Next;
            }
            List<int> list = new List<int>();
            Node<int> pos = null;
            while(!a1.IsEmpty)
            {
                pos = list.Insert(pos, a1.Pop);
            }
            Console.WriteLine(Distance(list));
            */
            int len = 0;
            Node<int> x = list.First;
            while(x != null)
            {
                len++;
                x = x.Next;
            }
            x = list.First;
            int [] arr = new int [len];
            int j = 0;
            while(x!=null)
            {
                arr [j++] = x.Info;
                x = x.Next;
            }
            int top=0,but=arr[0];
            for(int i = 1; i < arr.Length-1; i++)
            {
                if(arr [i - 1] > arr [i] && arr [i] < arr [i + 1])
                    if(arr[i]<but)
                        but = arr [i];
                if(arr [i - 1] < arr [i] && arr [i] > arr [i + 1])
                    if(arr [i] > top)
                        top = arr [i];
            }
            return top-but;
        }

    }
}
