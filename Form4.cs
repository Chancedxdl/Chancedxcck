
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataStructChance
{
    public partial class Form4 : Form
    {
        Queue boys;
        Queue girls;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            boys = new Queue();
            girls = new Queue();
            #region enterandprint
            string filename1 = Application.StartupPath + "\\" + "girls.TXT";
            StreamReader sr1 = new StreamReader(filename1, System.Text.Encoding.Default);
            while (!sr1.EndOfStream)
            {
                string s = sr1.ReadLine();
                girls.EnQueue(s);
            }
            sr1.Close();
            sr1.Dispose();
            string filename2 = Application.StartupPath + "\\" + "boys.TXT";
            StreamReader sr2 = new StreamReader(filename2, System.Text.Encoding.Default);
            while (!sr2.EndOfStream)
            {
                string s = sr2.ReadLine();
                boys.EnQueue(s);
            }
            sr2.Close();
            sr2.Dispose();
            #endregion
            //让文件中的人以此入队。
            label1.Text = "空场";
            label2.Text = "空场";
            refresh();
        }

        public void refresh()//此方法用来每次加载候场的人，每一次换人跳舞都要换候场的人
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            string[] strs1 = boys.output().Split(' ');
            foreach (string s in strs1)
            {
                ListViewItem lstVwItem = new ListViewItem(s);
                listView1.Items.Add(lstVwItem);
            }
            listView2.Items.Clear();
            listView2.View = View.Details;
            string[] strs2 = girls.output().Split(' ');
            foreach (string s in strs2)
            {
                ListViewItem lstVwItem = new ListViewItem(s);
                listView2.Items.Add(lstVwItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)//第一对舞伴上舞台
        {
            label1.Text = boys.DeQueue().ToString();
            label2.Text = girls.DeQueue().ToString();
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)//换一对舞伴上舞台
        {
            boys.EnQueue(label1.Text);
            girls.EnQueue(label2.Text);//让在舞台上的人重新入队
            label1.Text = boys.DeQueue().ToString();
            label2.Text = girls.DeQueue().ToString();
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)//休息一下，没人在舞台上，都在候场
        {
            boys.EnQueue(label1.Text);
            girls.EnQueue(label2.Text);
            label1.Text = "空场";
            label2.Text = "空场";
            refresh();
        }

    }
}
