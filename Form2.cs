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
    public partial class Form2 : Form
    {
        private LinkList ele;
        private LinkList ele2;
        Random r;
        public Form2()
        {
            InitializeComponent();
            r = new Random(DateTime.Now.Millisecond);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ele = new LinkList();
            for (int i = 1; i <= 5; i++)
            {
                ele.insert(i, r.Next(-2,2));
                ele.StraightInsertionSort();
            }
            textBox1.Text = ele.print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ele.insert(int.Parse(textBox2.Text),textBox3.Text);
            textBox1.Text = ele.print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ele.delete(int.Parse(textBox4.Text));
            textBox1.Text = ele.print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = ele.Getelement(int.Parse(textBox5.Text)).ToString() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ele = null;
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text=ele.getLocation(ele.findmax());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ele2 = new LinkList();
            for (int i = 1; i <= 5; i++)
            {
                ele2.insert(i, r.Next(-2,2));
                ele2.StraightInsertionSort();
            }
            textBox7.Text = ele2.print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ele.mergejiao(ele2);
            ele.quchong();
            textBox8.Text = ele.print();
        }
    }
}
