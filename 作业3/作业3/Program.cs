using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业3
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

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
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> i = Head; i != null; i = i.Next)
            {
                action(i.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //整型list
            GenericList<int> intList = new GenericList<int>();

            for (int x = 0; x < 10; x++)
            {
                intList.Add(x);
            }
            int max = intList.Head.Data;
            int min = intList.Head.Data;
            int sum = 0;
            intList.ForEach((x) =>
            {

                max = Math.Max(max, x);
                min = Math.Min(min, x);
                sum += x;
            });
            Console.WriteLine("max= {0} , min= {1} , total= {2}", max, min, sum);
            Console.ReadKey();
        }
    }
}
