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
    public partial class Form1 : Form
    {
        private SqList ele;
        Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random(DateTime.Now.Millisecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ele=new SqList();
            for (int i = 0; i < 200; i++)
            {
                ele.insert(0, r.Next(-200, 200));
            }
            textBox1.Text = ele.print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ele.insert(0,textBox2.Text );
            textBox1.Text = ele.print(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = ele.getdeletevalue((int)numericUpDown1.Value).ToString();
            ele.delete((int)numericUpDown1.Value);
            textBox1.Text = ele.print();            
        }
    }
}
