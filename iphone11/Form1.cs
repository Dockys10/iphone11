using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iphone11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text=="")
            {
                label1.Text = "asdf";

            }
            else
            {
                int text = Convert.ToInt32(textBox1.Text);
                int text1 = Convert.ToInt32(textBox2.Text);
                label1.Text = "xd"+(text + text1);
                label2.Text = "nasobeni" + (text * text1);
                label3.Text = "odcitani" + (text - text1);
            }
        }
    }
}
