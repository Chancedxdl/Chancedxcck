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
    public partial class Form5 : Form
    {
        String mystring = new String();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            mystring.sinsert("a");
            mystring.sinsert("3");
            mystring.sinsert(" ");
            mystring.sinsert("5");
            mystring.sinsert("v");
            mystring.sinsert("g");
            mystring.sinsert("f");
            mystring.sinsert("h");
            mystring.sinsert("l");
            mystring.sinsert("c");
            mystring.sinsert(" ");
            mystring.sinsert("a");
            mystring.sinsert(" ");
            mystring.sinsert("c");
            mystring.sinsert("j");
            mystring.sinsert("x");
            mystring.sinsert("h");
            mystring.sinsert("i");
            tbPrint.Text = mystring.print();
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            if (numericUpDownin.Value == 0)
            {
                mystring.sinsert(tbinsert.Text);
            }
            else
            {
                mystring.sinsert(Convert.ToInt32(numericUpDownin.Value), tbinsert.Text);
            }
            tbPrint.Text=mystring.print();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (numericUpDownf.Value == 0)
            {
                mystring.sdelete();
                tbPrint.Text = mystring.print();
            }
            else
            {
                mystring.sdelete(Convert.ToInt32(numericUpDownf.Value), Convert.ToInt32(numericUpDown.Value));
                tbPrint.Text = mystring.print();
            }
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            textBoxsub.Text = mystring.Substing(Convert.ToInt32(numericUpDownf.Value), Convert.ToInt32(numericUpDown.Value));
        }

        private void btifempty_Click(object sender, EventArgs e)
        {
            if (mystring.isEmpty())
                label1.Text = "是";
            else
                label1.Text = "否";
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            mystring.sclear();
            tbPrint.Text = mystring.print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mystring.sContain(tBinput.Text))
                label4.Text = "是";
            else
                label4.Text = "否";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBLocation.Text ="第"+mystring.findIndexOf(tBinput.Text).ToString()+"位";
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            mystring.sReplace(tBinput.Text, tBtarget.Text);
            tbPrint.Text = mystring.print();
        }

        private void bttrim_Click(object sender, EventArgs e)
        {
            mystring.sTrim();
            tbPrint.Text = mystring.print();
        }

        private void btupper_Click(object sender, EventArgs e)
        {
            mystring.ToUpper();
            tbPrint.Text = mystring.print();
        }

        private void btlower_Click(object sender, EventArgs e)
        {
            mystring.ToLower();
            tbPrint.Text = mystring.print();
        }

        private void btcopy2_Click(object sender, EventArgs e)
        {
            mystring.sinsert(mystring.copy(Convert.ToInt32(numericUpDownf.Value), Convert.ToInt32(numericUpDown.Value)));
            tbPrint.Text = mystring.print();
        }

        private void btcopy_Click(object sender, EventArgs e)
        {
            mystring.copy(Convert.ToInt32(numericUpDownf.Value), Convert.ToInt32(numericUpDown.Value));
        }
    }
}
