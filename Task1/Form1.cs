using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
class MergeSort
{
   
    void merge(int[] arr, int l, int m, int r)
    {

        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;


        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    void sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            sort(arr, l, m);
            sort(arr, m + 1, r);
            merge(arr, l, m, r);
        }
    }


    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }


    public static void Main(String[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given Array");
        printArray(arr);
        MergeSort ob = new MergeSort();
        ob.sort(arr, 0, arr.Length - 1);
        Console.WriteLine("\nSorted array");
        printArray(arr);
    }
}

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      public  int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        int[] array = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Txt1.Text);
            num2 = int.Parse(Txt2.Text);
            num3 = int.Parse(Txt3.Text);
            num4 = int.Parse(Txt4.Text);
            num5= int.Parse(Txt5.Text);
            num6 = int.Parse(Txt6.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6 };
              string sorted_array = string.Join(",",array);
            label3.Text = sorted_array;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            array = new int[6];
            Txt1.Text = "";
            Txt2.Text = "";
            Txt3.Text = "";
            Txt4.Text = "";
            Txt5.Text = "";
            Txt6.Text = "";
            label3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
