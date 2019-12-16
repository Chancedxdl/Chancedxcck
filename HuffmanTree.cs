using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class HuffmanTree
    {
        HfNode Root;

        public HuffmanTree()
        {
            Root = new HfNode(0);
        }

        public void CreateHuffmanTreeByArray(int[] a)
        {
            int n = a.Length;
            if (n <= 0)
                return;
            if (n == 1)
            {
                Root = new HfNode(a[0]);
                return;
            }
            int m = n * 2 - 1;
            HfNode[] ht = new HfNode[m + 1];
            for (int i = 0; i <= n; ++i)
            {
                if (i > 0)
                    ht[i] = new HfNode(a[i - 1]);
                else
                    ht[i] = new HfNode(1000000000);
            }
            CreateHuffmanTree(ht);
        }

        private void CreateHuffmanTree(HfNode[] HT)
        {
            int n = HT.Length / 2;
            int m = n * 2 - 1;
            HfNode s1, s2;
            for (int i = n + 1; i <= m; ++i)
            {
                HT[i] = new HfNode(0);
                Select(HT, i - 1, out s1, out s2);
                s1.parent = HT[i];
                s2.parent = HT[i];
                HT[i].lchild = s1;
                HT[i].rchild = s2;
                HT[i].weigt = s1.weigt + s2.weigt;
            }
            Root = HT[m];
        }

        private void Select(HfNode[] ht, int n, out HfNode S1, out HfNode S2)
        {
            int j = 0;
            while (ht[j].parent != null)
                j++;
            S1 = ht[j];
            S2 = ht[j];
            int k = 0;
            for (int i = j + 1; i <= n; i++)
                if (ht[i].parent == null && S1.weigt > ht[i].weigt)
                {
                    S1 = ht[i];
                    k = i;
                }//选出权重最小的

            for (int i = j + 1; i <= n; i++)
                if (ht[i].parent == null && S2.weigt > ht[i].weigt && i != k)
                    S2 = ht[i];//选出权重第二小的
        }

        class HfNode
        {
            public int weigt;
            public HfNode parent, lchild, rchild;
            public HfNode(int qz)
            {
                weigt = qz;
                parent = null;
                lchild = null;
                rchild = null;
            }
        }
    }
}
