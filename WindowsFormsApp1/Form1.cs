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
        public List<string> portfel = new List<string>(); // портфель от раздоющий колоды
        
        public List<Button> panelrazB = new List<Button>();
        public List<Button> portfelB = new List<Button>();
        public List<Button> pan1B = new List<Button>();
        public List<Button> pan2B = new List<Button>();
        public List<Button> pan3B = new List<Button>();
        public List<Button> pan4B = new List<Button>();
        public List<Button> pan5B = new List<Button>();
        public List<Button> pan6B = new List<Button>();
        public List<Button> pan7B = new List<Button>();

        public string selectCard = "";

        public List<string> cardl = new List<string>() { "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "cj", "cq", "ck", "ca",
         "p2", "p3", "p4", "p5", "p6", "p7", "p8", "p9", "p10", "pj", "pq", "pk", "pa",
         "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "b10", "bj", "bq", "bk", "ba",
         "k2", "k3", "k4", "k5", "k6", "k7", "k8", "k9", "k10", "kj", "kq", "kk", "ka"}; // c - чери, p - пики, b - буби, k - крести

        public Form1()
        {
            InitializeComponent();
            randomCard();
            startDrawCard();
        }

        private void startDrawCard()
        {
            for (int i = panelraz.Count - 1; i >= 0; i--)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(29, 83),
                    BackColor = Color.Black,
                    Text = panelraz[i]
                };
                but.Click += new EventHandler(card_click);
                but.BringToFront();
                panelrazB.Add(but);
                panel2.Controls.Add(but);
            }

            int my = 15;
            int y = 253 + (pan1.Count * my);

            for (int i = 0; i < pan1.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(29, y - my),
                    Text = pan1[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan1[i][pan1[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }

                pan1B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan2.Count * my);
            for (int i = 0; i < pan2.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(171, y - my),
                    Text = pan2[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan2[i][pan2[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan2B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan3.Count * my);
            for (int i = 0; i < pan3.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(314, y - my),
                    Text = pan3[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan3[i][pan3[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan3B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan4.Count * my);
            for (int i = 0; i < pan4.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(475, y - my),
                    Text = pan4[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan4[i][pan4[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan4B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan5.Count * my);
            for (int i = 0; i < pan5.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(625, y - my),
                    Text = pan5[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan5[i][pan5[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan5B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan6.Count * my);
            for (int i = 0; i < pan6.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(756, y - my),
                    Text = pan6[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan6[i][pan6[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan6B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            y = 253 + (pan7.Count * my);
            for (int i = 0; i < pan7.Count; i++)
            {
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(892, y - my),
                    Text = pan7[i],
                };
                but.Click += new EventHandler(card_click);
                if (pan7[i][pan7[i].Length - 1] == 'o')
                {
                    but.BackColor = Color.White;
                }
                else
                {
                    but.BackColor = Color.Black;
                }
                pan7B.Add(but);
                panel2.Controls.Add(but);
                y -= my;
            }

            panel12.Visible = false;
            panel11.Visible = false;
            panel10.Visible = false;
            panel3.Visible = false;
            panel9.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
        }

        public string pred = "";
        private void card_click (object sender, EventArgs e)
        {
            selectCard = (sender as Button).Text.ToString();
            label3.Text = selectCard;
            label5.Text = pred;

            if (panelraz.Contains(selectCard))
            { 
                panelraz.Remove(selectCard);
                StringBuilder sb = new StringBuilder(selectCard);
                sb[sb.Length - 1] = 'o';
                portfel.Add(sb.ToString());

                panel4.Visible = false;
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(152, 83),
                    BackColor = Color.White,
                    Text = sb.ToString()
                };
                portfelB.Add(but);
                but.Click += new EventHandler(card_click);
                but.BringToFront();
                panel2.Controls.Add(but);
                panel2.Controls.SetChildIndex(but, 0);
                visableEl(selectCard, panelrazB);
                if (panelraz.Count == 0)
                {
                    panel3.Visible = true;
                }
            }
            else if (pan1.Contains(selectCard) && isopen(selectCard))
            {
                if (colopencar(pan1) < 2)
                {
                    MessageBox.Show("s");
                }
            }

            pred = selectCard;
        }

        private bool proverkacard(string s)
        {
            if (isopen(s) && (pan1.Contains(s) || pan2.Contains(s) || pan3.Contains(s) || pan4.Contains(s) || pan5.Contains(s) || pan6.Contains(s) || pan7.Contains(s) || portfel.Contains(s)))
            {
                return true;
            }
            return false;
        }

        private bool isopen(string s)
        {
            if (s[s.Length - 1] == 'c')
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private int colopencar(List<string> a)
        {
            int isopen = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i][a[i].Length - 1] == 'o')
                {
                    isopen++;
                }
            }
            return isopen;
        }

        private void randomCard()
        {
            Random random = new Random();
            int el1 = random.Next(cardl.Count);
            pan1.Add(cardl[el1] + "o");
            cardl.RemoveAt(el1);

            for (int i = 0; i < 2; i++)
            {
                int el2 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan2.Add(cardl[el2] + "o");
                    cardl.RemoveAt(el2);
                }
                else
                {
                    pan2.Add(cardl[el2] + "c");
                    cardl.RemoveAt(el2);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int el3 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan3.Add(cardl[el3] + "o");
                    cardl.RemoveAt(el3);
                }
                else
                {
                    pan3.Add(cardl[el3] + "c");
                    cardl.RemoveAt(el3);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                int el4 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan4.Add(cardl[el4] + "o");
                    cardl.RemoveAt(el4);
                }
                else
                {
                    pan4.Add(cardl[el4] + "c");
                    cardl.RemoveAt(el4);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                int el5 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan5.Add(cardl[el5] + "o");
                    cardl.RemoveAt(el5);
                }
                else
                {
                    pan5.Add(cardl[el5] + "c");
                    cardl.RemoveAt(el5);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                int el6 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan6.Add(cardl[el6] + "o");
                    cardl.RemoveAt(el6);
                }
                else
                {
                    pan6.Add(cardl[el6] + "c");
                    cardl.RemoveAt(el6);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                int el7 = random.Next(cardl.Count);
                if (i == 0)
                {
                    pan7.Add(cardl[el7] + "o");
                    cardl.RemoveAt(el7);
                }
                else
                {
                    pan7.Add(cardl[el7] + "c");
                    cardl.RemoveAt(el7);
                }
            }

            for (int i = 0; i < 24; i++)
            {
                int el24 = random.Next(cardl.Count);
                panelraz.Add(cardl[el24] + "c");
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

        private void panel4_Click(object sender, EventArgs e)
        {
            if (panelraz.Contains(selectCard) == true)
            {
                panelraz.Remove(selectCard);
                StringBuilder sb = new StringBuilder(selectCard);
                sb[sb.Length - 1] = 'o';
                portfel.Add(sb.ToString());

                panel4.Visible = false;
                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(152, 83),
                    BackColor = Color.White,
                    Text = sb.ToString()
                };
                portfelB.Add(but);
                but.Click += new EventHandler(card_click);
                but.BringToFront();
                panel2.Controls.Add(but);
                visableEl(selectCard, panelrazB);
            }
        }

        private void visableEl(string text, List<Button> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Text == text)
                {
                    a[i].Visible = false;
                }
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            for (int i = 0; i < portfel.Count; i++)
            {
                StringBuilder sb = new StringBuilder(portfel[i]);
                sb[sb.Length - 1] = 'o';
                panelraz.Add(sb.ToString());
                panel4.Visible = true;

                Button but = new Button
                {
                    Size = new Size(87, 110),
                    Location = new Point(29, 83),
                    BackColor = Color.Black,
                    Text = panelraz[i]
                };
                but.Click += new EventHandler(card_click);
                but.BringToFront();
                panelrazB.Add(but);
                panel2.Controls.Add(but);
                visableEl(portfel[i], portfelB);
            }

            for (int i = 0; i < panelraz.Count; i++)
            {
                portfel.Remove(panelraz[i]);
            }
        }
    }
}
