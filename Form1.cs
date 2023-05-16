using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        bool IsGameOn = false;
        int[,] XOs = new int[3,3];
        bool turaX = false;


        public Form1()
        {
            InitializeComponent();

            XOs =new int[3,3] { 
                { 3, 3,3 }, 
                { 3, 3,3 }, 
                { 3, 3,3 } };
        }

        private void XorO(object sender, EventArgs e)
        {
            if (IsGameOn)
            {


                Button btn = (Button)sender;
                if (turaX)
                {
                    if (btn.Text == "")
                    {
                        switch (btn.TabIndex)
                        {
                            case 0:
                                XOs[0, 0] = 1;
                                Refresh();
                                break;

                            case 1:
                                XOs[0, 1] = 1;
                                Refresh();
                                break;

                            case 2:
                                XOs[0, 2] = 1;
                                Refresh();
                                break;
                            ///////////
                            case 3:
                                XOs[1, 0] = 1;
                                Refresh();
                                break;

                            case 4:
                                XOs[1, 1] = 1;
                                Refresh();
                                break;

                            case 5:
                                XOs[1, 2] = 1;
                                Refresh();
                                break;
                            /////////////
                            case 6:
                                XOs[2, 0] = 1;
                                Refresh();
                                break;

                            case 7:
                                XOs[2, 1] = 1;
                                Refresh();
                                break;

                            case 8:
                                XOs[2, 2] = 1;
                                Refresh();
                                break;
                            default:
                                break;
                        }

                    }
                }
                else
                {
                    if (btn.Text == "")
                    {
                        switch (btn.TabIndex)
                        {
                            case 0:
                                XOs[0, 0] = 2;
                                Refresh();
                                break;

                            case 1:
                                XOs[0, 1] = 2;
                                Refresh();
                                break;

                            case 2:
                                XOs[0, 2] = 2;
                                Refresh();
                                break;
                            ///////////
                            case 3:
                                XOs[1, 0] = 2;
                                Refresh();
                                break;

                            case 4:
                                XOs[1, 1] = 2;
                                Refresh();
                                break;

                            case 5:
                                XOs[1, 2] = 2;
                                Refresh();
                                break;
                            /////////////
                            case 6:
                                XOs[2, 0] = 2;
                                Refresh();
                                break;

                            case 7:
                                XOs[2, 1] = 2;
                                Refresh();
                                break;

                            case 8:
                                XOs[2, 2] = 2;
                                Refresh();
                                break;
                            default:
                                break;
                        }

                    }
                }
                ///////////////////
            }
        }
    
        public void Refresh()
        {
            if (XOs[0, 0] == 1)
            { button1.Text = "X"; } else if (XOs[0,0] == 2) { button1.Text = "O"; };

            if (XOs[0, 1] == 1)
            { button2.Text = "X"; }
            else if (XOs[0, 1] == 2) { button2.Text = "O"; };

            if (XOs[0, 2] == 1)
            { button3.Text = "X"; }
            else if (XOs[0, 2] == 2) { button3.Text = "O"; };

            ////////////////

            if (XOs[1, 0] == 1)
            { button4.Text = "X"; }
            else if (XOs[1, 0] == 2) { button4.Text = "O"; };

            if (XOs[1, 1] == 1)
            { button5.Text = "X"; }
            else if (XOs[1, 1] == 2) { button5.Text = "O"; };

            if (XOs[1, 2] == 1)
            { button6.Text = "X"; }
            else if (XOs[1, 2] == 2) { button6.Text = "O"; };

            ////////////

            if (XOs[2, 0] == 1)
            { button7.Text = "X"; }
            else if (XOs[2, 0] == 2) { button7.Text = "O"; };

            if (XOs[2, 1] == 1)
            { button8.Text = "X"; }
            else if (XOs[2, 1] == 2) { button8.Text = "O"; };

            if (XOs[2, 2] == 1)
            { button9.Text = "X"; }
            else if (XOs[2, 2] == 2) { button9.Text = "O"; };

            if (turaX)
            {
                turaX = false;
            }
            else { turaX = true; }
            Check();
        }

        public void Check()
        {
            if (IsGameOn)
            {
                for (int i = 0; i < 3; i++)
                {

                    if (XOs[i, 0] == XOs[i, 1] && XOs[i, 1] == XOs[i, 2])
                    {
                        if (XOs[i, 0] == 3)
                        {

                        }
                        else
                        {
                            MessageBox.Show("--" + i.ToString());
                            IsGameOn = false;
                            EndGame(XOs[i, 0]);
                        }
                    }

                    if (XOs[0, i] == XOs[1, i] && XOs[1, i] == XOs[2, i])
                    {
                        if (XOs[0, i] != 3)
                        {
                            MessageBox.Show(" | " + i.ToString());
                            IsGameOn = false;
                            EndGame(XOs[1, i]);
                        }
                    }

                }

                if (XOs[0, 2] == XOs[1, 1] && XOs[1, 1] == XOs[2, 0])
                {
                    if (XOs[1, 1] != 3)
                    {
                        MessageBox.Show("/");
                        IsGameOn = false;
                        EndGame(XOs[1, 1]);
                    }
                }

                if (XOs[0, 0] == XOs[1, 1] && XOs[1, 1] == XOs[2, 2])
                {
                    if (XOs[1, 1] != 3)
                    {
                        MessageBox.Show(@"\");
                        IsGameOn = false;
                        EndGame(XOs[1, 1]);
                    }
                }
            }
            else
            {//Reset game
                XOs = new int[3, 3] {
                { 3, 3,3 },
                { 3, 3,3 },
                { 3, 3,3 } };
                Controls.OfType<Button>().ToList().ForEach(button => { button.Text = ""; });
            }

            if (!XOs.Cast<int>().ToList().Contains(3))
            {
                //Game should be finished by now
                MessageBox.Show("You stuck ?");
                label1.Text = "Finished";
            }
            
        }

        private void MasterBtn_Click(object sender, EventArgs e)
        {
            if (!IsGameOn) //Check for running game
            {
                label1.Text = "Game is on";
                panel1.Hide();
                label2.Hide();
                IsGameOn = true;
            }
            else
            {
                EndGame(666);
                //panel1.Show();
                //label2.Text = "Thanks for Playing";
                //label2.Show();
            }
        }

        void EndGame(int GameState)
        {
            label1.Text = "Finished";
            switch (GameState)
            {
                case 1:
                    //MessageBox.Show("X Wins");
                    label2.Text = "X Wins";
                    break;

                case 2:
                    //MessageBox.Show("O Wins");
                    label2.Text = "O Wins";
                    break;

                case 3:
                    MessageBox.Show("Err St:3");
                    break;

                default:
                    MessageBox.Show("Game Brokie ?");
                    break;
            }
            panel1.Show();
            label2.Show();
            XOs = new int[3, 3] {
                { 3, 3,3 },
                { 3, 3,3 },
                { 3, 3,3 } };
            Controls.OfType<Button>().ToList().ForEach(button => { button.Text = ""; });
            MasterBtn.Text = "Restart";
            IsGameOn= false;
        }
    }
}
