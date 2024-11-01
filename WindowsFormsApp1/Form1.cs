using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public List<string> panelraz = new List<string>(); // раздaющая колода(лево вверх) тут 24 карты 
        public List<string> pan1 = new List<string>(); // первая с лева колода и далее по очереди, тут 1 карта по началу
        public List<string> pan2 = new List<string>(); // тут 2 карты по началу
        public List<string> pan3 = new List<string>(); // тут 3 карты по началу
        public List<string> pan4 = new List<string>(); // тут 4 карты по началу
        public List<string> pan5 = new List<string>(); // тут 5 карты по началу
        public List<string> pan6 = new List<string>(); // тут 6 карты по началу
        public List<string> pan7 = new List<string>(); // последняя,  тут 7 карты по началу

        public List<string> portfel = new List<string>(); // последняя,  тут 7 карты по началу


        public List<string> cardl = new List<string>() { "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "cj", "cq", "ck", "ca",
         "p2", "p3", "p4", "p5", "p6", "p7", "p8", "p9", "p10", "pj", "pq", "pk", "pa",
         "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "b10", "bj", "bq", "bk", "ba",
         "k2", "k3", "k4", "k5", "k6", "k7", "k8", "k9", "k10", "kj", "kq", "kk", "ka"}; // c - чери, p - пики, b - буби, k - крести

        public Form1()
        {
            InitializeComponent();
            randomCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void randomCard()
        {
            Random random = new Random();
            int el1 = random.Next(cardl.Count);
            pan1.Add(cardl[el1]);
            cardl.RemoveAt(el1);

            for (int i = 0; i < 2; i++)
            {
                int el2 = random.Next(cardl.Count);
                pan2.Add(cardl[el2]);
                cardl.RemoveAt(el2);
            }

            for (int i = 0; i < 3; i++)
            {
                int el3 = random.Next(cardl.Count);
                pan3.Add(cardl[el3]);
                cardl.RemoveAt(el3);
            }

            for (int i = 0; i < 4; i++)
            {
                int el4= random.Next(cardl.Count);
                pan4.Add(cardl[el4]);
                cardl.RemoveAt(el4);
            }

            for (int i = 0; i < 5; i++)
            {
                int el5 = random.Next(cardl.Count);
                pan5.Add(cardl[el5]);
                cardl.RemoveAt(el5);
            }

            for (int i = 0; i < 6; i++)
            {
                int el6 = random.Next(cardl.Count);
                pan6.Add(cardl[el6]);
                cardl.RemoveAt(el6);
            }

            for (int i = 0; i < 7; i++)
            {
                int el7 = random.Next(cardl.Count);
                pan7.Add(cardl[el7]);
                cardl.RemoveAt(el7);
            }

            for (int i = 0; i < 24; i++)
            {
                int el24 = random.Next(cardl.Count);
                panelraz.Add(cardl[el24]);
                cardl.RemoveAt(el24);
            }
        }

        private string tstr(List<string> a)
        {
            string res = "";
            for (int i = 0; i < a.Count; i++)
            {
                res += a[i] + " ";
            }
            return res + "\n";
        }

        private void showCards()
        {
            MessageBox.Show("p = " + tstr(panelraz) + "p1 = " + tstr(pan1) + "p2 = " + tstr(pan2) + "p3 = " + tstr(pan3)
            + "p4 = " + tstr(pan4) + "p5 = " + tstr(pan5) + "p6 = " + tstr(pan6) + "p7 = " + tstr(pan7));
        }
    }
}
