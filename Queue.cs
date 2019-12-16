using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    public class Queue
    {
        private Node front;
        private Node rear;
        public Queue()
        {
            front = new Node();
            rear = front;
        }

        public void EnQueue(object e)
        {
            Node q = new Node(e);
            rear.next = q;
            rear = q;
        }

        public object DeQueue()
        {
            Node q = new Node();
            q = front.next;
            front.next = q.next;
            if (q.next == null)
            {
                rear = front;
            }
            return q.data;
        }
        public bool isempty()
        {
            if (front == rear)
                return true;
            else
                return false;
        }

        public string output()//特意设置了一个方法用来输出队列内所有的数据
        {
            string s = "";
            Node q = new Node();
            q = front;
            while (q.next != null)
            {
                s += q.next.data + " ";
                q = q.next;
            }
            return s;
        }

        class Node
        {
            public object data;
            public Node next;
            public Node()
            {
                data = null;
                next = null;
            }
            public Node(object e)
            {
                data = e;
                next = null;
            }
        }
    }
}
