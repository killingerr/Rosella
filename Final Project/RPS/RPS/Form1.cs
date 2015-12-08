using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        Player player1 = new Player();
        Player npcPlayer = new Player();
     
        public Form1()
        {
            InitializeComponent();
            RockButton.Enabled = false;
            PaperButton.Enabled = false;
            ScissorsButton.Enabled = false;
            StartButton.Enabled = false;
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            int[] npcShowChoice = player1.Play(0, npcPlayer); //Returns player and A.I. choice in an array
           
            playerLabel.Text = Convert.ToString(player1.wins); // Converts wins int to string
            npcLabel.Text = Convert.ToString(npcPlayer.wins);  //
           
            
            // Picture displays A.I choice
            if (npcShowChoice[1] == 0)
            {
                pictureBox1.Image = RPS.Properties.Resources.rockv2b;
            }
            else if (npcShowChoice[1] == 1)
            {
                pictureBox1.Image = RPS.Properties.Resources.paperv2b;
            }
            else if (npcShowChoice[1] == 2)
            {
                pictureBox1.Image = RPS.Properties.Resources.scissorsv2b;
            }
            
            
            if (comboBox1.Text == "First to 3")
            {
                if (player1.wins == 3 && player1.wins > npcPlayer.wins)  //Block for user win conditions
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 3 && npcPlayer.wins > player1.wins) //Block for A.I. win conditions
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }

            }//End if of 3

            if (comboBox1.Text == "First to 5")
            {
                if (player1.wins == 5 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 5 && npcPlayer.wins > player1.wins)  
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End if of 5

            if (comboBox1.Text == "First to 7")
            {
                if (player1.wins == 7 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 7 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End of if 7  

            if (comboBox1.Text == "First to 9")
            {
                if (player1.wins == 9 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 9 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
            }//End of if 9
       
        }//End RockButton

        private void PaperButton_Click(object sender, EventArgs e)
        {
            int[] npcShowChoice = player1.Play(1, npcPlayer);
            playerLabel.Text = Convert.ToString(player1.wins);
            npcLabel.Text = Convert.ToString(npcPlayer.wins);

            // Picture displays A.I choice
            if (npcShowChoice[1] == 0)
            {
                pictureBox1.Image = RPS.Properties.Resources.rockv2b;
            }
            else if (npcShowChoice[1] == 1)
            {
                pictureBox1.Image = RPS.Properties.Resources.paperv2b;
            }
            else if (npcShowChoice[1] == 2)
            {
                pictureBox1.Image = RPS.Properties.Resources.scissorsv2b;
            }

            if (comboBox1.Text == "First to 3")
            {
                if (player1.wins == 3 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 3 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
            }//End of if 3

            if (comboBox1.Text == "First to 5")
            {
                if (player1.wins == 5 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 5 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End if of 5

            if (comboBox1.Text == "First to 7")
            {
                if (player1.wins == 7 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 7 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End of if 7  

            if (comboBox1.Text == "First to 9")
            {
                if (player1.wins == 9 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 9 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
            }//End of if 9

        }//End of PaperButton

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            int[] npcShowChoice = player1.Play(2, npcPlayer);
      
            playerLabel.Text = Convert.ToString(player1.wins);
            npcLabel.Text = Convert.ToString(npcPlayer.wins);

            // Picture displays A.I choice
            if (npcShowChoice[1] == 0)
            {
                pictureBox1.Image = RPS.Properties.Resources.rockv2b;
            }
            else if (npcShowChoice[1] == 1)
            {
                pictureBox1.Image = RPS.Properties.Resources.paperv2b;
            }
            else if (npcShowChoice[1] == 2)
            {
                pictureBox1.Image = RPS.Properties.Resources.scissorsv2b;
            }

            
            if (comboBox1.Text == "First to 3")
            {
                if (player1.wins == 3 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 3 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
            }//End of if 3

            if (comboBox1.Text == "First to 5")
            {
                if (player1.wins == 5 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 5 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End if of 5

            if (comboBox1.Text == "First to 7")
            {
                if (player1.wins == 7 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 7 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;

                }

            }//End of if 7    

            if (comboBox1.Text == "First to 9")
            {
                if (player1.wins == 9 && player1.wins > npcPlayer.wins)
                {
                    playerLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
                else if (npcPlayer.wins == 9 && npcPlayer.wins > player1.wins)
                {
                    npcLabel.Text = "YOU WIN!";
                    RockButton.Enabled = false;
                    PaperButton.Enabled = false;
                    ScissorsButton.Enabled = false;
                    StartButton.Enabled = false;
                    comboBox1.Enabled = true;
                    player1.wins = 0;
                    npcPlayer.wins = 0;
                }
            }//End of if 9

        }//End of ScissorsButton

        private void StartButton_Click(object sender, EventArgs e)
        {
            roundsWonP.Text = Convert.ToString(player1.rounds);  //Displays rounds won
            roundsWonN.Text = Convert.ToString(npcPlayer.rounds);//
            RockButton.Enabled = true;
            PaperButton.Enabled = true;
            ScissorsButton.Enabled = true;
            StartButton.Enabled = false;

        }

        // Drop down list for game type options
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "First to 3")
            {

                StartButton.Enabled = true;
                comboBox1.Enabled = false;
                player1.wins = 0;
                npcPlayer.wins = 0;
                pictureBox1.Image = null;

            }

            else if (comboBox1.Text == "First to 5")
            {

                StartButton.Enabled = true;
                comboBox1.Enabled = false;
                player1.wins = 0;
                npcPlayer.wins = 0;
                pictureBox1.Image = null;
            }

            else if (comboBox1.Text == "First to 7")
            {

                StartButton.Enabled = true;
                comboBox1.Enabled = false;
                player1.wins = 0;
                npcPlayer.wins = 0;
                pictureBox1.Image = null;
            }
            else if (comboBox1.Text == "First to 9")
            {

                StartButton.Enabled = true;
                comboBox1.Enabled = false;
                player1.wins = 0;
                npcPlayer.wins = 0;
                pictureBox1.Image = null;
            }
        }
       
        // Resets all values for a fresh game
        private void ResetButton_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            player1.wins = 0;
            player1.rounds = 0;
            npcPlayer.wins = 0;
            npcPlayer.rounds = 0;
            roundsWonP.Text = Convert.ToString(player1.rounds);
            roundsWonN.Text = Convert.ToString(npcPlayer.rounds);
            playerLabel.Text = Convert.ToString(player1.wins);
            npcLabel.Text = Convert.ToString(npcPlayer.wins);
            pictureBox1.Image = null;
        }

        //Closes program
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
