using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Project
{
    public partial class Form1 : Form
    {
        //declaring global variable and constant win score
        int globalscore1 = 0, globalscore2 = 0, roundscore1 = 0, roundscore2 = 0, roll=0, win = 20;
        private void diceroll()
        {
            //method for rolling the dice
            roll = 0;
            Random rand = new Random();
            roll = (rand.Next(5)) + 1;
        }

        private void game()
        {
            //declaring which items should be visible during the game itself and starts with player 1
            player1label.Visible = true;
            player2label.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            player1name.Visible = false;
            player2name.Visible = false;
            startgamebutton.Visible = false;
            dicepic.Visible = true;
            player1rollbutton.Visible = true;
            player1holdbutton.Visible = true;
            player1globallabel.Visible = true;
            player1roundlabel.Visible = true;
            player2globallabel.Visible = true;
            player2roundlabel.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            winnerlabel.Visible = false;
            label3.Visible = true;
            turnlabel.Visible = true;
        }

        private void startpage()
        {
            //declaring which items to be visible when back at the start menu and emptying name boxes
            player1label.Visible = false;
            player2label.Visible = false;
            dicepic.Visible = false;
            player1rollbutton.Visible = false;
            player1holdbutton.Visible = false;
            player2rollbutton.Visible = false;
            player2holdbutton.Visible = false;
            player1globallabel.Visible = false;
            player1roundlabel.Visible = false;
            player2globallabel.Visible = false;
            player2roundlabel.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            label3.Visible = false;
            turnlabel.Visible = false;
            winnerlabel.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            player1name.Visible = true;
            player2name.Visible = true;
            startgamebutton.Visible = true;
            exitbutton.Visible = true;
            player1name.Text = player2name.Text = "";
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startgame_Click(object sender, EventArgs e)
        {
            //start game
            //show the player names and restart scores
            game();
            player1label.Text = player1name.Text;
            player2label.Text = player2name.Text;
            turnlabel.Text = player1name.Text;
            player1globallabel.Text = player2globallabel.Text = "0";
        }

        private void player1switch()
        {
            //switch sides from 1 to 2
            player1rollbutton.Visible = false;
            player1holdbutton.Visible = false;
            player2rollbutton.Visible = true;
            player2holdbutton.Visible = true;
        }

        private void player2switch()
        {
            //switch sides from 2 to 1
            player2rollbutton.Visible = false;
            player2holdbutton.Visible = false;
            player1rollbutton.Visible = true;
            player1holdbutton.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startpage();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dieone()
        {
            //show dice 1
            dicepic.Image = Image.FromFile("Die1.bmp");
        }

        private void dietwo()
        {
            //show dice 2
            dicepic.Image = Image.FromFile("Die2.bmp");
        }

        private void diethree()
        {
            //show dice 3
            dicepic.Image = Image.FromFile("Die3.bmp");
        }

        private void diefour()
        {
            //show dice 4
            dicepic.Image = Image.FromFile("Die4.bmp");
        }

        private void diefive()
        {
            //show dice 5
            dicepic.Image = Image.FromFile("Die5.bmp");
        }

        private void diesix()
        {
            //show dice 6
            dicepic.Image = Image.FromFile("Die6.bmp");
        }

        private void player1hold_Click(object sender, EventArgs e)
        {
            //Player 1 Holding
            //switch sides (turns) and add score to global
            //check if won and start again
            player1switch();//switch sides
            globalscore1 = int.Parse(player1globallabel.Text);//global score
            globalscore1 = globalscore1 + int.Parse(player1roundlabel.Text);
            player1globallabel.Text = globalscore1.ToString();//new global score
            player1roundlabel.Text = "0";//reset round socre
            if (globalscore1 >= win)//check if won
            {
                winnerlabel.Visible = true;
                winnerlabel.Text = player1name.Text + " wins";//winner laber
                startpage();//start menu
            }
            turnlabel.Text = player2name.Text;//turn label
        }

        private void player2hold_Click(object sender, EventArgs e)
        {
            //Player 2 Holding
            //switch sides (turns) and add score to global
            //check if won and start again
            player2switch();//switch sides
            globalscore2 = int.Parse(player2globallabel.Text);//get global score
            globalscore2 = globalscore2 + int.Parse(player2roundlabel.Text);
            player2globallabel.Text = globalscore2.ToString();//new global score 
            player2roundlabel.Text = "0";//reset round score
            if (globalscore2 >= win)//if they won
            {
                winnerlabel.Visible = true;
                winnerlabel.Text = player2name.Text + " wins";//winner label
                startpage();//start menu
            }
            turnlabel.Text = player1name.Text;//turn label
        }
        private void player2roll_Click(object sender, EventArgs e)
        {
            //Player 2 Rolling
            //add roll number to round score
            //if one switch sides and delete score
            diceroll();
            if (roll == 1)//roll 1
            {
                dieone();
                player2roundlabel.Text = "0";
                player2switch();
                turnlabel.Text = player1name.Text;
            }
            if (roll == 2)//roll 2
            {
                dietwo();
                roundscore2 = int.Parse(player2roundlabel.Text);
                roundscore2 = roundscore2 + 2;
                player2roundlabel.Text = roundscore2.ToString();
            }
            if (roll == 3)//roll 3
            {
                diethree();
                roundscore2 = int.Parse(player2roundlabel.Text);
                roundscore2 = roundscore2 + 3;
                player2roundlabel.Text = roundscore2.ToString();
            }
            if (roll == 4)//roll 4
            {
                diefour();
                roundscore2 = int.Parse(player2roundlabel.Text);
                roundscore2 = roundscore2 + 4;
                player2roundlabel.Text = roundscore2.ToString();
            }
            if (roll == 5)//roll 5
            {
                diefive();
                roundscore2 = int.Parse(player2roundlabel.Text);
                roundscore2 = roundscore2 + 5;
                player2roundlabel.Text = roundscore2.ToString();
            }
            if (roll == 6)//roll 6
            {
                diesix();
                roundscore2 = int.Parse(player2roundlabel.Text);
                roundscore2 = roundscore2 + 6;
                player2roundlabel.Text = roundscore2.ToString();
            }
        }

        private void player1roll_Click(object sender, EventArgs e)
        {
            //Player 1 rolling
            //add roll number to round score
            //if 1, switch sides and delete score
            diceroll();
            if (roll == 1) //roll 1
            { 
                dieone();
                player1roundlabel.Text = "0";
                player1switch();
                turnlabel.Text = player2name.Text;
            }
            if (roll == 2) //roll 2
            {
                dietwo();
                roundscore1 = int.Parse(player1roundlabel.Text);
                roundscore1 = roundscore1 + 2;
                player1roundlabel.Text = roundscore1.ToString();
            }
            if (roll == 3) //roll 3
            {
                diethree();
                roundscore1 = int.Parse(player1roundlabel.Text);
                roundscore1 = roundscore1 + 3;
                player1roundlabel.Text = roundscore1.ToString();
            }
            if (roll == 4) //roll 4
            { 
                diefour();
                roundscore1 = int.Parse(player1roundlabel.Text);
                roundscore1 = roundscore1 + 4;
                player1roundlabel.Text = roundscore1.ToString();
            }
            if (roll == 5) //roll 5
            { 
                diefive();
                roundscore1 = int.Parse(player1roundlabel.Text);
                roundscore1 = roundscore1 + 5;
                player1roundlabel.Text = roundscore1.ToString();
            }
            if (roll == 6) //roll 6
            { 
                diesix();
                roundscore1 = int.Parse(player1roundlabel.Text);
                roundscore1 = roundscore1 + 6;
                player1roundlabel.Text = roundscore1.ToString();
            }
        }
    }
}