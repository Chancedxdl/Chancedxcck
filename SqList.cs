using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class SqList
    {
        private const int Ini = 200;
        private const int Increament = 10;
        private int size;
        private int length;
        public object[] element;
        public int Size
        {
            get  {return  size;}
        }
        public int Length
        {
            get { return length; }
        }
        public  SqList()
        {
            element = new object[Ini];
            size = Ini;
            length = 0;
        }
        public bool insert(int i, object e)
        { 
            if(i<0||i>length+1)
                return false;
            if(length >=size)
            {
                object []newelement=new object[size+Increament];
                Array.Copy(element,newelement,element.Length);
                element=newelement;
                size+=Increament;
            }
            for(int j=length;j>i;j--)
            {
                element[j]=element[j-1];
            }
            element[i] = e;
            length++;
            return true;
        }
        public bool delete(int i)
        {
            if (i < 0 || i > length)
                return false;
            for (int j = i; j <= length-1; j++)
            {
                element[j-1] = element[j];
            }
            --length;
            return true;
        }
        public  object  getdeletevalue(int i)
        {
            return element[i - 1];
        }
        public string print()
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                s += element[i];
                if (i != 199)
                {
                    s += ",";
                }
            }
            return s;
        }
    }
}
