using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;
using System.Runtime.InteropServices;

namespace _1
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data{ get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head; private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n; tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> n = head; n != null; n = n.Next)
            {
                action(n.Data);
            }
        }
    }
    //字符串型List

    internal class Program
    {
        static void Main(string[] args)
        {

            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            int max=-999, min=999, sum=0;
            Console.WriteLine("遍历元素:");
            intlist.ForEach((int x) => { Console.WriteLine(x); });
            intlist.ForEach((int x) => { if (x > max) max = x; });
            intlist.ForEach((int x) => { if (x < min) min = x; });
            intlist.ForEach((int x) => { sum += x; });
            Console.WriteLine("");
            Console.WriteLine($"最大值:{max}");
            Console.WriteLine($"最小值:{min}");
            Console.WriteLine($"总和:{sum}");
        }
    }
}