using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        not eleman = new not();
        private void button1_Click(object sender, EventArgs e)
        {
            eleman.not1 = Convert.ToDouble(textBox1.Text);
            eleman.not2 = Convert.ToDouble(textBox2.Text);
            eleman.not3 = Convert.ToDouble(textBox3.Text);
            label1.Text = eleman.ortalama().ToString();
            label2.Text = eleman.sonuc();
        }
    }
}
