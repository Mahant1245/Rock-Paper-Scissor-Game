using System;
using System.IO;
using System.Windows.Forms;

namespace Rock_Paper_Scissor_Game
{
    public partial class Form1 : Form
    {
        int numberOfGames = 10;//player plays 10 games
        string userchoice="";
        string computerchoice="";
        int userscore=0;
        int computerscore = 0;
        int highscore=0;
        string playerName="";
        
        string[] choices = { "r", "p", "s", "r", "p", "s" };//i have wrote the r,p,s twice to give comp more chance to choose random value
        Random random = new Random();

        

        public Form1()
        {
            InitializeComponent();
        }


       private string UpdateDisplay(string choice, PictureBox display)//returns the choice and update the picture in picturebox.
        {
            string word = "";
            if(choice=="r")
            {
                word = "Rock";
                display.Image = Properties.Resources.rock;
            }
            if (choice == "s")
            {
                word = "Scissors";
                display.Image = Properties.Resources.Scissors1;
            }
            if (choice == "p")
            {
                word = "Paper";
                display.Image = Properties.Resources.Paper1;
            }
            return word;
        }

        private void ComputerPicUpdate()
        {
            int i = random.Next(0, choices.Length);
            computerchoice = choices[i];//randomly selects from rock paper or scissors.
            labelCompChoice.Text = "Computer choose  " + UpdateDisplay(computerchoice, ComputerPic);
            labelUserChoice.Text = playerName + " choose  " + UpdateDisplay(userchoice, UserPic);
        }

        

        private void UpdateScores()
        {
            if (numberOfGames > 1)//will only update the score if the player hasnt yet played 10 games.
            {
                if (userchoice == computerchoice)//game is draw
                {

                    numberOfGames--;

                }
                //when comp wins
                else if (userchoice == "r" && computerchoice == "p" || userchoice == "s" && computerchoice == "r" || userchoice == "p" && computerchoice == "s")
                {
                    computerscore++;
                    numberOfGames--;

                }
                //if comp is not winning and its not a draw then user wins
                else
                {
                    userscore++;
                    numberOfGames--;

                }
                //update the label.
                labelCompResult.Text = "Computer score is " + computerscore;
                labelPlayerResult.Text = playerName+" score is " + userscore;
            }
            else
            {
                decision();
            }
        }

        private void decision()
        {
            if (userscore > computerscore)
            {
                FinalResultLable.Text = playerName + "wins the game \n press restart button";//update the final result label
                if (userscore>=highscore)// check if player has beat the highscore
                {
                    //first writes the high score to the text file and then display it.
                    highscore = userscore;
                    WriteHighscore();
                    ReadHighscore();
                }
            }
            else
            {
                FinalResultLable.Text = "computer wins the game \n press restart";
                ReadHighscore();//display the previous highscore.
            }
            
        }
        private void WriteHighscore()
        {
            if (userscore >= highscore)
            {
                TextWriter tw = new StreamWriter("Highscore.txt");//creates the text file
                tw.WriteLine(playerName+" scored "+userscore);//write the highscore.
                tw.Close();
            }
        }

        private void ReadHighscore()
        {
            if(!File.Exists("highscore.txt"))//if file doesnt exist it creates the text file
            {
                TextWriter tw = new StreamWriter("Highscore.txt");
                tw.WriteLine("0");
                tw.Close();
            }
            TextReader tr = new StreamReader("highscore.txt");
           HighscoresLabel.Text= tr.ReadToEnd();
            tr.Close();
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            userchoice = "r";
            ComputerPicUpdate();
           
            UpdateScores();



        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            userchoice = "p";
            ComputerPicUpdate();
           

            UpdateScores();
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            userchoice = "s";
            ComputerPicUpdate();
            
            UpdateScores();
        }

        private void RestartButton_Click(object sender, EventArgs e)
           
        {
            userscore = 0;
            computerscore = 0;
            numberOfGames = 10;
            labelCompResult.Text = "Computer score is " + computerscore;
            labelPlayerResult.Text = "Player score is " + userscore;
            FinalResultLable.Text = "Final Result";
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            playerName=UserName.Text;//assign the  value in the textbox to the variable.
        }
    }
}
