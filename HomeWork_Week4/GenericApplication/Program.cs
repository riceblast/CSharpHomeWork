using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication {

    // 链表节点
    public class Node<T> {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t) {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T> {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() {
            tail = head = null;
        }

        public Node<T> Head {
            get => head;
        }

        public void Add(T t) {
            Node<T> n = new Node<T>(t);
            if (tail == null) {
                head = tail = n;
            } else {
                tail.Next = n;
                tail = n;
            }
        }


        public void ForEach(Action<T> action) {
            // 变量声明
            Node<T> p = head;

            while (p != null)
            {
                action(p.Data);
                p = p.Next;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            // 变量声明
            int sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++) {
                intlist.Add(x);
            }

            // 打印所有元素
            intlist.ForEach(entry =>Console.WriteLine(entry));

            // 求和
            intlist.ForEach(entry => sum += entry);

            // 求最大值
            intlist.ForEach(entry => { if (entry > max) max = entry; });

            // 最小值
            intlist.ForEach(entry => { if (entry < min) min = entry; });

            Console.WriteLine($"和：{sum},最大值：{max}，最小值：{min}");
        }
    }
}