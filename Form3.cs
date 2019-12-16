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
    public partial class Form3 : Form
    {
        Stack zhan;
        public Form3()
        {
            InitializeComponent();
            zhan = new Stack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            while (n >= 8)
            {
                zhan.Push(n%8);
                n = n / 8;
            }
            zhan.Push(n);
            string s8="";
            while(zhan.isempty()==false)
                s8 += zhan.Pop().ToString();
            textBox2.Text = s8;
        }
    }
}
