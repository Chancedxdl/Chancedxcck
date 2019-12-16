using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructChance
{
    class BiTree
    {
        TreeNode root;
        public BiTree()
        {
            root = null;
        }
        public void CreateBiTreeByString(string s)
        {
            int i = 0;
            CreateBiTree(ref root,ref s,ref i);
        }
        private  void CreateBiTree(ref TreeNode T,ref string s,ref int index)
        {
            
            char ch = s[index];
            if (ch == '#')
            {
                T = null;
            }
            else
            {
                T = new TreeNode(ch);
                ++index;
                CreateBiTree(ref T.leftchild,ref s,ref index );
                ++index;
                CreateBiTree(ref T.rightchild, ref s, ref index);
            }
        }
        class TreeNode
        {
            public object data;
            public TreeNode leftchild;
            public TreeNode rightchild;
            public TreeNode()
            {
                data = null;
                leftchild = null;
                rightchild = null;
            }
            public TreeNode(object e)
            {
                data = e;
                leftchild = null;
                rightchild = null;
            }
        }
    }
}
