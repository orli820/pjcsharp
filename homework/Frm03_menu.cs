﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Frm03_menu : Form
    {
        public Frm03_menu()
        {
            InitializeComponent();
        }

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        string w;
        string x;
        string y;
        string z;
        int a;
        int b;
        int c;
        int d;

        private void button1_Click(object sender, EventArgs e)
        {
            count1 += 1;
            w = "飼料x" + count1 + "共NT$" + (30 * count1)+ "元\r\n";
            textBox2.Text = w+x+y+z;
            a =  (30 * count1);
            textBox1.Text = "NT$" + (a + b + c + d) .ToString() + "元";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count2 += 1;
            x = "麵包蟲x" + count2 + "共NT$" + (90 * count2) + "元\r\n";
            textBox2.Text = w + x + y + z;
            b =( 90 * count2);
            textBox1.Text = "NT$" + (a + b + c + d).ToString() + "元";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count3 += 1;
            y = "起司x" + count3 + "共NT$" + (120 * count3) + "元\r\n";
            textBox2.Text = w + x + y + z;
            c = (120 * count3);
            textBox1.Text = "NT$" + (a + b + c + d).ToString() + "元";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count4 += 1;
            z = "點心棒x" + count4 + "共NT$" + (40 * count4) + "元\r\n";
            textBox2.Text = w + x + y + z;
            d = (40 * count4);
            textBox1.Text = "NT$" + (a + b + c + d).ToString() + "元";
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額" + textBox1.Text);
        }

        private void btn_visa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額" + textBox1.Text+Environment.NewLine+"折扣後金額"+ ((a + b + c + d) * 0.9).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            w = "";
            x = "";
            y = "";
            z = "";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;

            textBox2.Text = w+x+y+z+"尚未點餐";
            textBox1.Text = "NT$"+ 0.ToString()+"元";

        }
    }
}
