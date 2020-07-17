using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    public partial class Form1 : Form
    {
        //Initialize array of guys
        Guy[] guys = new Guy[3];

        //intialize array of greyhounds
        Greyhound[] GreyhoundArray = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();

            lblAl.Visible = false;
            lblBob.Visible = false;
            lblJoe.Visible = false;

            guys[0] = new Guy() { Money = 100, Name = "Smith", MyLabel= lblJoe, MyRadioButton = radioJoe };
            guys[1] = new Guy() { Money = 100, Name = "David", MyLabel = lblBob, MyRadioButton = radioBob };
            guys[2] = new Guy() { Money = 100, Name = "Tom", MyLabel = lblAl, MyRadioButton = radioAl };
            foreach(Guy guy in guys)
                guy.PlaceBet(0, 0);

            //set the default bet name to Joe
            lblName.Text = guys[0].Name;

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = new Random()
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };
        
            updateForm();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            //reset dog positions
            foreach(Greyhound g in GreyhoundArray){
                g.MyPictureBox.Left = g.StartingPosition;
            }

            //start timer for race
            
                timer1.Enabled = true;
            
          // disable the Race and Bet button during race
            btnRace.Enabled = false;
            btnBets.Enabled = false;
        }

        public void updateForm() //update the msg on labels
        {
            radioJoe.Text = guys[0].Name + " has $" + guys[0].Money;
            radioBob.Text = guys[1].Name + " has $" + guys[1].Money;
            radioAl.Text = guys[2].Name + " has $" + guys[2].Money;
        }

        public void radioJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[0].Name; //set the name of guy on label for Smith
        }

        private void radioBob_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[1].Name; //set the name of guy on label for David
        }

        private void radioAl_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Text = guys[2].Name; //set the name of guy on label for Tom
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            // Bets button working here
            int guy;
            if (radioJoe.Checked)
            {
                guy = 0;
                lblJoe.Visible = true;
            }
            else if(radioBob.Checked)
            {
                guy = 1;
                lblBob.Visible = true;

            }
            else
            {
                guy = 2;
                lblAl.Visible = true;
            }

            /*place the bet for the selected amount on the selected dog 
             by the selected guy */
            guys[guy].PlaceBet((int)numBets.Value, (int)numDog.Value - 1);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run(racetrackPictureBox))
                {
                    winner = i;
                    timer1.Enabled = false;
                    MessageBox.Show("Dog #" + (winner + 1) + " Wins!");
                    for (int j = 0; j < guys.Length; j++)
                    {
                        if (guys[j].Bet.PayOut(winner) != 0)
                            guys[j].Money += guys[j].Bet.PayOut(winner);
                        guys[j].MyRadioButton.Text = guys[j].Name + " has $" + guys[j].Money;
                        if (guys[0].Money < 5)
                        {
                            lblJoe.Text = "BUSTED!";
                            guys[0].MyRadioButton.Enabled = false;
                        }
                        else if (guys[1].Money < 5)
                        {
                            lblBob.Text = "BUSTED!";
                            guys[1].MyRadioButton.Enabled = false;

                        }
                        else if (guys[2].Money < 5)
                        {
                            lblAl.Text = "BUSTED!";
                            guys[2].MyRadioButton.Enabled = false;
                        }
                        else if (guys[0].Money < 5 && guys[1].Money < 5 && guys[2].Money < 5)
                        {
                            lblAl.Text = "BUSTED!"; lblBob.Text = "BUSTED!"; lblJoe.Text = "BUSTED!";
                            guys[0].MyRadioButton.Enabled = false;
                            guys[1].MyRadioButton.Enabled = false;
                            guys[2].MyRadioButton.Enabled = false;
                            MessageBox.Show("GAME OVER");

                            // buttons disabled here
                            btnBets.Enabled = false;
                            btnRace.Enabled = false;
                        }
                    }

                    // buttons enabled again
                    btnBets.Enabled = true;
                    btnRace.Enabled = true;

                    // label text clear again
                    lblAl.Visible = false;
                    lblBob.Visible = false;
                    lblJoe.Visible = false;
                   

                    break;
                    
                }
            }
            

        }
    }
}
