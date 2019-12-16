using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructChance
{
    public partial class Form9 : Form
    {
        HuffmanTree hfmtree = new HuffmanTree();
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = textBox1.Text.Split(',').Length;
            int[] a = new int[len];
            int i = 0;
            foreach (string str in textBox1.Text.Split(','))
            {
                a[i++] = int.Parse(str);
            }
            hfmtree.CreateHuffmanTreeByArray(a);
            label3.Show();
        }
    }
}
