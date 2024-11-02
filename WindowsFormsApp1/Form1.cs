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

        public Button draggedCard = null;

        public string selectCard = "";

        public List<string> cardl = new List<string>() { "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "cj", "cq", "ck", "ca",
         "p2", "p3", "p4", "p5", "p6", "p7", "p8", "p9", "p10", "pj", "pq", "pk", "pa",
         "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9", "b10", "bj", "bq", "bk", "ba",
         "k2", "k3", "k4", "k5", "k6", "k7", "k8", "k9", "k10", "kj", "kq", "kk", "ka"}; // c - чери, p - пики, b - буби, k - крести; k и p - черные 

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
                    AllowDrop = true,
                    Text = panelraz[i]
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "panelrazB";

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
                    AllowDrop = true,
                    Text = pan1[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan1B";
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
                    AllowDrop = true,
                    Text = pan2[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan2B";
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
                    AllowDrop = true,
                    Text = pan3[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan3B";
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
                    AllowDrop = true,
                    Text = pan4[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan4B";
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
                    AllowDrop = true,
                    Text = pan5[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan5B";
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
                    AllowDrop = true,
                    Text = pan6[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan6B";
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
                    AllowDrop = true,
                    Text = pan7[i],
                };
                but.Click += new EventHandler(card_click);
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "pan7B";
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

        private void But_MouseUp(object sender, MouseEventArgs e) => isDragging = false;
        
        private bool CanPlaceCards(List<string> movingCards, string targetCardText)
        {
            if (movingCards == null || movingCards.Count == 0)
                return false; // Нет карт для перемещения
            for (int i = 0; i < movingCards.Count - 1; i++)
            {
                string currentCard = movingCards[i];
                string nextCard = movingCards[i + 1];

                if (!IsValidSequence(currentCard, nextCard))
                    return false; // Если последовательность нарушена, перемещение невозможно
            }

            string topMovingCard = movingCards[0];
            return CanPlaceCard(topMovingCard, targetCardText);
        }

        private bool IsValidSequence(string upperCardText, string lowerCardText)
        {
            // Разбираем карты
            string upperSuit, upperRank;
            ParseCard(upperCardText, out upperSuit, out upperRank);
            int upperValue = RankToValue(upperRank);

            string lowerSuit, lowerRank;
            ParseCard(lowerCardText, out lowerSuit, out lowerRank);
            int lowerValue = RankToValue(lowerRank);

            // Проверка на корректность рангов
            if (upperValue == -1 || lowerValue == -1)
                return false;

            bool upperIsRed = IsSuitRed(upperSuit);
            bool lowerIsRed = IsSuitRed(lowerSuit);
            bool colorsAreOpposite = upperIsRed != lowerIsRed;
            bool rankIsOneGreater = upperValue == lowerValue + 1;
            return colorsAreOpposite && rankIsOneGreater;
        }

        private void ParseCard(string cardText, out string suit, out string rank)
        {
            if (string.IsNullOrEmpty(cardText))
            {
                suit = "";
                rank = "";
                return;
            }

            suit = cardText[0].ToString();

            if (char.IsDigit(cardText[1]))
            {
                int rankd = 0;
                int.TryParse(string.Join("", cardText.Where(c => char.IsDigit(c))), out rankd);
                rank = rankd.ToString();
            }
            else
            {
                rank = cardText[1].ToString();
            }
        }

        private int RankToValue(string rank)
        {
            switch (rank.ToLower())
            {
                case "a":
                    return 1;  // В "Косынке" туз обычно считается как 1
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "j":
                    return 11;
                case "q":
                    return 12;
                case "k":
                    return 13;
                default:
                    return -1;  // инвалид
            }
        }
        private bool IsSuitRed(string suit)
        {
            switch (suit.ToLower())
            {
                case "c": // Черви
                case "b": // Буби
                    return true;  // КРасные идут

                case "p": // Пики

                case "k": // Крест
                    return false; // негр
                default:
                    return false; // негр
            }
        }
        private bool CanPlaceCard(string sourceCardText, string targetCardText)
        {
            string sourceSuit, sourceRank;
            ParseCard(sourceCardText, out sourceSuit, out sourceRank);
            int sourceValue = RankToValue(sourceRank);

            if (string.IsNullOrEmpty(targetCardText))
                return sourceValue == 13;

            string targetSuit, targetRank;
            ParseCard(targetCardText, out targetSuit, out targetRank);
            int targetValue = RankToValue(targetRank);

            if (sourceValue == -1 || targetValue == -1)
                return false;
            bool sourceIsRed = IsSuitRed(sourceSuit);
            bool targetIsRed = IsSuitRed(targetSuit);
            bool colorsAreOpposite = sourceIsRed != targetIsRed;
            bool rankIsOneLess = sourceValue == targetValue - 1;
            return colorsAreOpposite && rankIsOneLess;
        }


        private bool isDragging = false;
        private Point mouseOffset;

        private void But_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void But_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent("CardTexts"))
            {
                e.Effect = DragDropEffects.Move;
                Button aa = sender as Button;
                aa.MouseMove += But_MouseMove;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void But_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
            {
                MessageBox.Show("Ошибка: e.Data равен null.");
                return;
            }
            if (e.Data.GetDataPresent("CardTexts"))
            {
                Button targetCard = sender as Button;
                List<string> movingCardTexts = e.Data.GetData("CardTexts") as List<string>;
                if (CanPlaceCards(movingCardTexts, targetCard.Text))
                {
                    List<Button> cardsToMove = GetButtonsByTexts(movingCardTexts);
                    CardMoveFromTo(cardsToMove, targetCard);
                    var targetLocation = targetCard.Location;
                    for (int i = 0; i < cardsToMove.Count; i++)
                    {
                        Button card = cardsToMove[i];
                        card.Location = new Point(targetLocation.X, targetLocation.Y + 15 * (i + 1));
                        card.BringToFront();
                    }
                    //MessageBox.Show($"Перемещена последовательность карт на {targetCard.Text}");
                }
            }
        }

        private List<Button> GetButtonsByTexts(List<string> cardTexts)
        {
            List<Button> buttons = new List<Button>();

            foreach (string text in cardTexts)
            {
                Button cardButton = FindCardButtonByText(text);
                if (cardButton != null)
                    buttons.Add(cardButton);
                else
                    MessageBox.Show($"Карта с текстом '{text}' не найдена.");
            }
            return buttons;
        }

        private Button FindCardButtonByText(string text)
        {
            foreach (Control control in panel2.Controls)
                if (control is Button btn && btn.Text == text)
                    return btn;
            return null;
        }

        private void CardMoveFromTo(List<Button> cardsToMove, Button cardTarget)
        {
            if (cardsToMove == null || cardsToMove.Count == 0)
                return;

            Button firstCard = cardsToMove[0];
            string srcTextList = firstCard.Tag as string;
            string trgtTextList = cardTarget.Tag as string;

            List<Button> srcList = GetButtonListByName(srcTextList);
            List<Button> trgtList = GetButtonListByName(trgtTextList);

            foreach (Button card in cardsToMove)
            {
                if (srcTextList == "portfelB")
                {
                    portfel.Remove(card.Text);
                }
                srcList.Remove(card);
            }
            OpenLastCard(srcList);
            trgtList.AddRange(cardsToMove);
            foreach (Button card in cardsToMove)
            {
                card.Tag = trgtTextList;
            }
        }

        private void CardMoveToF(Button cardTarget, Panel panel)
        {
            string trgtTextList = cardTarget.Tag as string;
            List<Button> trgtList = GetButtonListByName(trgtTextList);

            if (trgtTextList == "portfelB")
                portfel.Remove(cardTarget.Text);
            trgtList.Remove(cardTarget);
            OpenLastCard(trgtList); 
            Button but = new Button
            {
                Size = new Size(87, 110),
                Location = new Point(),
                BackColor = Color.White,
                Text = cardTarget.Text.ToString()
            };
            panel2.Controls.Remove(cardTarget);
            but.Location = new Point();
            but.BringToFront();
            panel.Controls.Add(but); 
        }


        private void CardMoveFromTo(Button cardSource, Button cardTarget)
        {
            string srcTextList = cardSource.Tag as string;
            string trgtTextList = cardTarget.Tag as string;
            List<Button> srcList = GetButtonListByName(srcTextList);
            List<Button> trgtList = GetButtonListByName(trgtTextList);
            if (srcTextList == "portfelB")
                portfel.Remove(cardSource.Text);
            OpenLastCard(srcList);
            srcList.Remove(cardSource);
            trgtList.Add(cardTarget);
        }

        private List<Button> GetCardsToMove(Button sourceCard)
        {
            string srcTextList = sourceCard.Tag as string;
            List<Button> srcList = GetButtonListByName(srcTextList);
            int startIndex = srcList.IndexOf(sourceCard);
            List<Button> cardsToMove = new List<Button>();
            for (int i = startIndex; i < srcList.Count; i++)
            {
                Button card = srcList[i];
                if (!card.Text.EndsWith("c"))
                    cardsToMove.Add(card);
                else
                    break;
            }
            return cardsToMove;
        }

        private List<Button> GetButtonListByName(string listName)
        {
            switch (listName)
            {
                case "panelrazB": return panelrazB;
                case "pan1B": return pan1B;
                case "pan2B": return pan2B;
                case "pan3B": return pan3B;
                case "pan4B": return pan4B;
                case "pan5B": return pan5B;
                case "pan6B": return pan6B;
                case "pan7B": return pan7B;
                case "portfelB": return portfelB;
                default: return null;
            }
        }

        private List<string> GetListByName(string listName)
        {
            switch (listName)
            {
                case "panelraz": return panelraz;
                case "pan1": return pan1;
                case "pan2": return pan2;
                case "pan3": return pan3;
                case "pan4": return pan4;
                case "pan5": return pan5;
                case "pan6": return pan6;
                case "pan7": return pan7;
                case "portfel": return portfel;
                default: return null;
            }
        }

        private void OpenLastCard(List<Button> cards)
        {
            if (cards.Count >= 1)
            {
                Button button = cards[0];
                if (!isopen(button.Text))
                {
                    button.BackColor = Color.White;
                    button.Text = button.Text.Replace('c', 'o');
                }
            }
        }


        private void But_MouseDown(object sender, MouseEventArgs e)
        {
            Button card = sender as Button;
            string selectCard = card.Text;

            string rank = "";
            string suit = "";

            label1.Text = selectCard;
            ParseCard(selectCard, out suit, out rank);
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
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "portfelB";
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

            if (suit == "c" && panel5.Controls.Count == (RankToValue(rank) - 1) && !card.Text.EndsWith("c"))
                CardMoveToF(card, panel5);
            else if (suit == "k" && panel6.Controls.Count == (RankToValue(rank) - 1) && !card.Text.EndsWith("c"))
                CardMoveToF(card, panel6);
            else if (suit == "b" && panel7.Controls.Count == (RankToValue(rank) - 1) && !card.Text.EndsWith("c"))
                CardMoveToF(card, panel7);
            else if (suit == "p" && panel8.Controls.Count == (RankToValue(rank) - 1) && !card.Text.EndsWith("c"))
                CardMoveToF(card, panel8);
            else if (card != null)
            {
                List<string> cardsToMoveTexts = GetCardsToMove(card).Select(c => c.Text).ToList();
                if (cardsToMoveTexts.Count > 0)
                {
                    isDragging = true;
                    // Получаем текущую позицию мыши
                    mouseOffset = e.Location;
                    draggedCard = card;
                    DataObject data = new DataObject();
                    data.SetData("CardTexts", cardsToMoveTexts);
                    DoDragDrop(data, DragDropEffects.Move);
                    card.GiveFeedback += Card_GiveFeedback;
                }
            }
        }

        private void Card_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
        }

        public string pred = "";
        private void card_click(object sender, EventArgs e)
        {
            string rank = "";
            string suit = "";

            selectCard = (sender as Button).Text.ToString();
            label3.Text = selectCard;
            label5.Text = pred;

            Button card = sender as Button;

            ParseCard(selectCard, out suit, out rank);

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
                but.MouseDown += But_MouseDown;
                but.DragEnter += But_DragEnter;
                but.DragDrop += But_DragDrop;
                but.MouseUp += But_MouseUp;
                but.Tag = "portfelB";
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
                    //MessageBox.Show("s");
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
            //if (panelraz.Contains(selectCard) == true)
            //{
            //    panelraz.Remove(selectCard);
            //    StringBuilder sb = new StringBuilder(selectCard);
            //    sb[sb.Length - 1] = 'o';
            //    portfel.Add(sb.ToString());

            //    panel4.Visible = false;
            //    Button but = new Button
            //    {
            //        Size = new Size(87, 110),
            //        Location = new Point(152, 83),
            //        BackColor = Color.White,
            //        Text = sb.ToString()
            //    };
            //    portfelB.Add(but);
            //    but.Click += new EventHandler(card_click);
            //    but.BringToFront();
            //    panel2.Controls.Add(but);
            //    visableEl(selectCard, panelrazB);
            //}
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
