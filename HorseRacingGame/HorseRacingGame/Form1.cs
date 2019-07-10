using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacingGame
{
    public partial class Form1 : Form
    {
        HorseRunning[] horseRace = new HorseRunning[4];//instance of greyhound class
        Guy[] guys = new Guy[3];//object of guy class
        public Form1()
        {
            InitializeComponent();
            HorsesRaceTrack();//calling the set race track funtion
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            HorsesRaceStart();
        }

        private void HorsesRaceStart()//this is function for starting the race
        {
            bool NoWinner = true;
            int winningHorse;
            btnRace.Enabled = false;//Button will be false whenever race is continue

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < horseRace.Length; i++)//loop start and it will continue whenever length of greyhound class or track is not finished
                {
                    Thread.Sleep(1);//sleep function for the speed of horses
                    if (horseRace[i].HorseRunningFunction())//here run function is called from greyhound class for running the cars and condition is checked for three random cars
                    {
                        winningHorse = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Horse #" + winningHorse);
                        foreach (Guy guy in guys)
                        {
                            if (guy.betting != null)//condition is checked for betting
                            {
                                guy.Collect(winningHorse);
                                guy.betting = null;
                                guy.LabelUpdated();
                            }
                        }

                        foreach (HorseRunning horse in horseRace)
                        {
                            horse.TakeStartingPosition();
                        }

                        break;
                    }
                }

            }

            btnRace.Enabled = true;//here race button is enabled when race is finished

        }

        private void HorsesRaceTrack()//this funtion is for setting the race track
        {
            MinimumBet.Text = string.Format("Minimum Bet $1", (int)numericUpDownBets.Minimum);//Showing the minimum bet rate in label

            int startingPosition = horse1.Bottom - horseTrack.Top; //Setting the variable for starting position 
            int raceTrackLength = horseTrack.Size.Height;//Setting the variable of length of racetrack

            //Setting values of the array of the class greyhound for racing for the first part of the game as suggested in assignment
            horseRace[0] = new HorseRunning()
            {
                pictureBox = horse1,
                HorseTrackLength = raceTrackLength,
                StPosition = startingPosition
            };

            horseRace[1] = new HorseRunning()
            {
                pictureBox = horse2,
                HorseTrackLength = raceTrackLength,
                StPosition = startingPosition
            };
            horseRace[2] = new HorseRunning()
            {
                pictureBox = horse3,
                HorseTrackLength = raceTrackLength,
                StPosition = startingPosition
            };
            horseRace[3] = new HorseRunning()
            {
                pictureBox = horse4,
                HorseTrackLength = raceTrackLength,
                StPosition = startingPosition
            };

            //this part is for assigning the constructor values which is created in guy class
            guys[0] = new Guy("Joe", null, 50, joeRadioButton, joeLabel);
            guys[1] = new Guy("Bob", null, 50, bobRadioButton, bobLabel);
            guys[2] = new Guy("Al", null, 50, aiRadioButton, aiLabel);

            foreach (Guy guy in guys)
            {
                guy.LabelUpdated();//using the foreach loop for assigning the values of labels for bet
            }
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (joeRadioButton.Checked)
            {
                GuyNumber = 0;//when radio button joe is checked then set its id is 0
            }
            if (bobRadioButton.Checked)
            {
                GuyNumber = 1;//when radio button bob is checked then set its id is 1
            }
            if (aiRadioButton.Checked)
            {
                GuyNumber = 2;//when radio button ai is checked then set its id is 2
            }

            guys[GuyNumber].PlaceBet((int)numericUpDownBets.Value, (int)numericUpDownMember.Value);//when any radio button is checked then place bet function is called and bet is placed and show amount and car number
            guys[GuyNumber].LabelUpdated();//with this code line the labels are updated
        }
    }
}
