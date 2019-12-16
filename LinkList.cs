using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class LinkList
    {
        private int length;
        private Node head;

        public LinkList()
        {
            head = new Node();
            length = 0;
        }

        public bool insert(int i, object e)
        {
            Node p = head;
            int j = 0;
            if (i < 1 || i > length + 1)
                return false;
            while (j < i - 1)
            {
                p = p.next;
                j++;
            }
            Node q = new Node(e);
            q.next = p.next;
            p.next = q;
            length++;
            return true;
        }

        public string  findmax()
        {
            Node p = head.next ;
            Node q = head.next;
            int j = 1;
            while (p != null)
            {
                if (Convert.ToDecimal(q.data) < Convert.ToDecimal(p.data))
                {
                    q = p;
                    j++;
                }
                p = p.next;
            }
            return q.data.ToString();
        }

        public string getLocation(object Elem) 
        {
            int location = 0;
            string Loc = "";  
            Node p = this.head.next;
            while (p != null)
            {
                location++;
                if (p.data.ToString() == Elem.ToString())
                {
                    Loc = location.ToString();
                }
                p = p.next;
            }
            return Loc;
        }

        public void mergejiao(LinkList l2)
        {
            Node p = this.head.next;
            Node q = l2.head.next;
            bool aaa = true;
            while (p != null && q != null)
            {
                if (Convert.ToDecimal(p.data) == Convert.ToDecimal(q.data))
                {
                    if (aaa)
                    {
                        head = new Node();
                        length = 0;
                    }
                    aaa = false ;
                    this.insert(length+1, p.data);
                    p = p.next;
                    q = q.next;
                }
                else if (Convert.ToDecimal(p.data) < Convert.ToDecimal(q.data))
                {
                    p = p.next;
                }
                else
                {
                    q = q.next;
                }
            }
        }

        public void quchong()
        {
            Node p = this.head.next;
            int i = 1;
            while (p != null)
            {
                Node q = p.next;
                while (q != null)
                {
                    int j = i+1;
                    if (Convert.ToDecimal(q.data) == Convert.ToDecimal(p.data))
                    {
                        this.delete(j);
                    }
                    q = q.next;
                    j++;
                }
                p = p.next;
                i++;
            }
        }

        public void DeleteElems(object Elem) //单链表的 删除 操作，删除特定具体的数据,返回删除个数，位置索引从“1”开始
        {
            Node p = this.head;
            while (p.next != null)
            {
                if (p.next.data.ToString() == (Elem as Node).data.ToString())
                {
                    Node q = p.next;
                    p.next = q.next;
                    q = null;
                    length--;
                    continue;
                }
                p = p.next;
            }
        }

        public void StraightInsertionSort()
        {
            Node p = this.head.next;
            while (p.next != null)
            {
                //decimal stop = 0;
                if (Convert.ToDecimal(p.data) > Convert.ToDecimal(p.next.data))
                {
                    Node q = p.next;
                    p.next = q.next;
                    length--;
                    q.next = null;
                    Node t = this.head;
                    while (Convert.ToDecimal(t.next.data) < Convert.ToDecimal(q.data))
                    {
                        t = t.next;
                    }
                    q.next = t.next;
                    t.next = q;
                    length++;
                    q = null;
                    continue;
                }
                p = p.next;
            }
        }

        public bool delete(int i)
        {
            Node p = head;
            int j = 0;
            if (i < 1 || i > length)
                return false;
            while (j < i - 1)
            {
                p = p.next;
                j++;
            }
            Node q = new Node();
            q = p.next;
            p.next  = q.next;
            return true;
        }

        public bool isEmpty()
        {
            return length == 0 ? true : false;
        }

        public object Getelement(int i)
        {
            Node p = head;
            int j = 0;
            if (i < 1 || i > length)
                return false;
            while (j < i - 1)
            {
                p = p.next;
                j++;
            }
            return p.next.data;
        }

        public string print()
        {
            string str = "";
            Node p = head.next;
            while (p != null)
            {
                if (p != head.next)
                    str += ",";
                str += p.data.ToString();
                p = p.next;
            }
            return str;
        }

        class Node
        {
            public object data;
            public Node next;
            public Node()
            {
                data=null;
                next=null;
            }
            public Node(object e)
            {
                data=e;
                next=null;
            }
        }
    }
}
