using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class String
    {
        private int length;
        private Node head;

        public String()
        {
            head = new Node();
            length = 0;
        }

        public bool sinsert(int i, string e)
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
        }//在特定位置插入字符串

        public bool sinsert(string e)//在最后插入e
        {
            Node p = head;
            int j = 0;
            while (j < length)
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

        public void sdelete()
        {
            Node p = head;
            int j = 0;
            while (j < length - 1)
            {
                p = p.next;
                j++;
            }
            p.next = null;
            length--;
        }//从后删除

        public string Substing(int i, int j)
        {
            Node p1 = head;
            Node p2 = head;
            string deletestring = "";
            int m = 0;
            int n = 0;
            if (i < 1 || j > length)
                return null;
            while (m < i - 1)
            {
                p1 = p1.next;
                p2 = p2.next;
                m++;
                n++;
            }
            while (m >= i - 1 && n <= j - 1)
            {
                p2 = p2.next;
                deletestring += p2.data;
                m++;
                n++;
            }
            return deletestring;
        }//从特定位置开始截取k个字符串

        public string sdelete(int i, int j)
        {
            Node p1= head;
            Node p2 = head;
            string deletestring = "";
            int m = 0;
            int n = 0;
            if (i < 1 || j> length)
                return null;
            while (m < i-1)
            {
                p1 = p1.next;
                p2 = p2.next;
                m++;
                n++;
            }
            while(m>=i-1&&n<=j-1)
            {
                p2 = p2.next;
                deletestring += p2.data;
                m++;
                n++;
            }
            Node q = new Node();
            q = p2.next;
            p1.next = q.next;
            return deletestring;
        }//删除两个位置之间的字符串

        public bool isEmpty()//字符串是否为空
        {
            return length == 0 ? true : false;
        }

        public void sclear()//字符串清空
        {
            Node p = head;
            head.next = null;
            length = 0;
        }

        public string Getelement(int i)
        {
            Node p = head;
            int j = 0;
            if (i < 1 || i > length)
                return null;
            while (j < i - 1)
            {
                p = p.next;
                j++;
            }
            return p.next.data;
        }//取出特定位置的字符串

        public int findIndexOf(string substring)
        {
            bool find = false;
            Node p = head;
            int j = 0;
            while (j < length+1)
            {
                if (p.data == substring)
                {
                    find = true;
                    break;
                }
                else
                {
                    p = p.next;
                    j++;
                }
            }
            if (find)
            {
                return j;
            }
            else
            {
                return -1;
            }
        }//找到字符串第一次出现的位置

        public bool sContain(string e)//是否包含e
        {
            bool contain = false;
            Node p = head;
            int j = 0;
            while (j < length+1)
            {
                if (p.data == e)
                {
                    contain = true;
                    break;
                }
                else
                    p = p.next;
                j++;
            }
            return contain;
        }

        public bool sReplace(string olds, string news)//字符串的替换
        {
            Node p = head;
            int j = 0;
            while (j < length+1)
            {
                if (p.data == olds)
                {
                    p.data = news;
                }
                p = p.next;
                j++;
            }
            return true;
        }

        public void sTrim()//去空格
        {
            Node p = head;
            int j = 0;
            while (j < length+1)
            {
                if (p.data ==" ")
                {
                    p.data = null;
                }
                p = p.next;
                j++;
            }
        }

        public void ToUpper()//所有字母变大写
        {
            Node p = head;
            for (int j = 0; j < length; j++)
            {
                p = p.next;
                p.data=p.data.ToUpper();
            }
        }

        public void ToLower()//所有字母变小写
        {
            Node p = head;
            for (int j = 0; j < length; j++)
            {
                p = p.next;
                p.data=p.data.ToLower();
            }
        }

        public string print()
        {
            string str = "";
            Node p = head.next;
            while (p != null)
            {
                str += p.data;
                p = p.next;
            }
            return str;
        }//输出整个字符串

        public string copy(int i, int j)
        {
            Node p1 = head;
            Node p2 = head;
            string copystring = "";
            int m = 0;
            int n = 0;
            if (i < 1 || j > length)
                return null;
            while (m < i - 1)
            {
                p1 = p1.next;
                p2 = p2.next;
                m++;
                n++;
            }
            while (m >= i - 1 && n <= j - 1)
            {
                p2 = p2.next;
                copystring += p2.data;
                m++;
                n++;
            }
            return copystring;
        }//复制与粘贴

        class Node
        {
            public string data;
            public Node next;
            public Node()
            {
                data = null;
                next = null;
            }
            public Node(string e)
            {
                data = e;
                next = null;
            }
        }
    }
}
