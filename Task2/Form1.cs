using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        int[] array = new int[6];
        int[] left_array = new int[3];
        int[] right_array = new int[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Txt1.Text);
            num2 = int.Parse(Txt2.Text);
            num3 = int.Parse(Txt3.Text);
            num4 = int.Parse(Txt4.Text);
            num5 = int.Parse(Txt5.Text);
            num6 = int.Parse(Txt6.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6 };
            int i = num1;
          int j = num4;
            for (int k=1;k<=6;k++)
            {
                


            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
