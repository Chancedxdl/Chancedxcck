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
    public partial class Form7 : Form
    {
        BiTree btree = new BiTree();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '#' && textBox1.Text[textBox1.Text.Length - 2] == '#'&&(textBox1.Text.Length+1)%4==0)
            {
                btree.CreateBiTreeByString(textBox1.Text);
                label2.Show();
            }
            else
            {
                Form8 f = new Form8();
                f.Show();
            }
        }
    }
}
