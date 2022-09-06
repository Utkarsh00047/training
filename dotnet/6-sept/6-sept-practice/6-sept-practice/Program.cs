using System;
using System.Collections.Generic;

namespace _6_sept_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>()
            {
                "Utkarsh","abhshek","Mudit"
            };
            foreach (var name in lst)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("");


            HashSet<string> st = new HashSet<string>(); //data should be unique
            st.Add("India");
            st.Add("USA");
            st.Add("India");
            st.Add("Japan");
            foreach (var i in st)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            Stack<int> stck = new Stack<int>();

            stck.Push(1);
            stck.Push(2);
            stck.Push(3);
            stck.Pop();
            foreach (var i in stck)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            LinkedList<int> lnkdlst = new LinkedList<int>();
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(1);
            lnkdlst.AddFirst(2);

            lnkdlst.RemoveFirst();
            foreach (int i in lnkdlst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            LinkedListNode<int> node = lnkdlst.Find(1);
            lnkdlst.AddAfter(node, 5);
            foreach (int i in lnkdlst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Utkarsh");
            dict.Add(2, "Abhsek");
            dict.Add(3, "Abhsek");
            dict.Add(4, "amit");
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine("");
            Console.WriteLine(dict.Values.Count);
        }
    }
}
