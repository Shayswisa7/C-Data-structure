using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    class Rupin
    {
        public static void Second_Main()
        {
            Node<int> pos = new Node<int>(2, new Node<int>(3, new Node<int>(5, new Node<int>(1, new Node<int>(2, new Node<int>(4, new Node<int>(4, new Node<int>(3))))))));
            Node<int> pos1 = pos;
            Queue<int> queue = new Queue<int>();
            while(pos1 != null)
            {
                queue.Insert(pos1.Info);
                pos1 = pos1.Next;
            }
            Console.WriteLine(Unique(pos));
            Console.WriteLine(Unique(queue));
            
        } 
        public static Node<int> Unique( Node<int> inList )
        {
            Node<int> pos = inList;
            Node<int> p = null;
            while(pos!=null)
            {
                bool flag = true;
                Node<int> p1 = p;
                if(p1 != null)
                {
                    while(p1.Next != null)
                    {
                        if(pos.Info == p1.Info)
                            flag = false;
                        p1 = p1.Next;
                    }
                     if(p1.Info == pos.Info)
                       flag = false;
                }
                if(flag)
                {
                    if(p != null)
                        p1.Next = new Node<int>(pos.Info);
                    else
                        p = new Node<int>(pos.Info);
                }
                pos = pos.Next;
            }
            return p;
        }
        public static Queue<int> Unique( Queue<int> inQ )
        {
            Queue<int> que = new Queue<int>();
            Queue<int> que1 = new Queue<int>();
            Queue<int> queReturn = new Queue<int>();
            while(!inQ.IsEmpty)
            {
                bool flag = true;
                while(!que.IsEmpty)
                {
                    if(inQ.Head == que.Head)
                        flag = false;
                    que1.Insert(que.Remove);
                }
                while(!que1.IsEmpty)
                    que.Insert(que1.Remove);
                if(flag)
                    queReturn.Insert(inQ.Head);
                que.Insert(inQ.Remove);
            }
            return queReturn;
        }
    }
    class Toranut
    {
        private int dayOfWeek;
        private Role role;
        private string seniority;

        public enum Role
        {
            Financial_Complaints=1,
            Complaints_about_delivery_times,
            UI_issues,
            Logical_problems,
            General_problems
        }
        public Toranut(int dayOfWeek, int role )
        {
            this.dayOfWeek = dayOfWeek;
            this.role = (Role)(role);
            if(role < 3 || role==5)
                this.seniority = "high";
            else
                this.seniority = "low";
        }

        public bool CanSwitch(Toranut agreeToSwitch )
        {
            if(this.seniority=="low" && agreeToSwitch.seniority == "high" && this.dayOfWeek==agreeToSwitch.dayOfWeek)
                return false;
            return true;
        }
    }
}
