﻿using System;
using System.Collections;
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
    public partial class Frm05_studentlist : Form
    {
        public Frm05_studentlist()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList sclist = new ArrayList();
            score sco;


            sco.studentname = txtN.Text;
            sco.scorechi = int.Parse(txtC.Text);
            sco.scoreeng = int.Parse(txte.Text);
            sco.scoremat = int.Parse(txtma.Text);
            sco.scoreto = sco.scorechi + sco.scoreeng + sco.scoremat;
            sco.scoreav = Math.Round((sco.scoreto / 3), 2, MidpointRounding.AwayFromZero);

            int[] sc = { Convert.ToInt32(sco.scorechi), Convert.ToInt32(sco.scoreeng), Convert.ToInt32(sco.scoremat) };
            string[] su = { "國文", "英文", "數學" };
            int maxSc = sc.ToList().IndexOf(sc.Max());
            int minSc = sc.ToList().IndexOf(sc.Min());


            sclist.Add(sco);


            for (int i = 0; i < sclist.Count; i++)
            {
                labuser.Text += $"{((score)sclist[i]).studentname.PadRight(5)}{((score)sclist[i]).scorechi.ToString().PadLeft(7)}{((score)sclist[i]).scoreeng.ToString().PadLeft(7)}{((score)sclist[i]).scoremat.ToString().PadLeft(7)}{((score)sclist[i]).scoreto.ToString().PadLeft(8)}{((score)sclist[i]).scoreav.ToString().PadLeft(8)}{su[minSc].PadLeft(8)}{sc.Min().ToString()}{su[maxSc].PadLeft(7)}{sc.Max().ToString()}\n";

            }


        }
        int count = 1;
    
        public void O()
        {
            Random myObject = new Random();
            int ranNum1 = myObject.Next(0, 100);
            int ranNum2 = myObject.Next(0, 100);
            int ranNum3 = myObject.Next(0, 100);


            int[] SCO = { ranNum1, ranNum2, ranNum3 };
            string[] SUB = { "國文", "英文", "數學" };
            int MAXS = SCO.ToList().IndexOf(SCO.Max());
            int MINS = SCO.ToList().IndexOf(SCO.Min());
            decimal av = Math.Round(((decimal)(ranNum1 + ranNum2 + ranNum3) / 3), 2, MidpointRounding.AwayFromZero);


            labuser.Text += (count++.ToString().PadRight(5) + ranNum1.ToString().PadLeft(7) + ranNum2.ToString().PadLeft(7) + ranNum3.ToString().PadLeft(7)) + (ranNum1 + ranNum2 + ranNum3).ToString().PadLeft(8) + av.ToString().PadLeft(8) + (SUB[MINS].PadLeft(7)) + (SCO.Min().ToString().PadLeft(3)) + (SUB[MAXS].PadLeft(7)) + (SCO.Max().ToString().PadLeft(3)) + "\n";
            //不能在外面count++，若在外面count++,count先+1再算式的+=又再+1一次，count會一直是單數

        }

        public void button1_Click(object sender, EventArgs e)   //隨機加入資料
        {
            O();            
        }

        private void button3_Click(object sender, EventArgs e)   //各科統計
        {

        }



        private void button4_Click(object sender, EventArgs e)  //重設所有資料
        {
            labuser.Text = "";
            count = 1;
        }

        string result;

        private void button5_Click(object sender, EventArgs e)  //隨機加入20筆資料
        {


            for (int i = 0; i <= 20; i++)
            {
                //result += O(i);
            }



        }
    }
}



