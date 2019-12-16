using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class Stack
    {
        Node top;
        Node bottom;
        public Stack()
        {
            top = new Node();
            bottom = top;
        }
        public bool Push(object e)
        {
            Node q = new Node(e);
            q.next  = top.next ;
            top.next =q;
            if (bottom == top)
                bottom = q;
            return true;
        }
        public object  Pop()
        {
            if (top == bottom)
                return null;
            else
            {
                object e = top.next.data;
                top = top.next;
                return e;
            }             
        }
        public bool isempty()
        {
            if (top == bottom)
                return true;
            else
                return false;
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
