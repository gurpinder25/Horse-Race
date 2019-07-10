using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacingGame
{
    public class HorseRunning
    {
        //The following are the Global variables
        public int StPosition;
        public int HorseTrackLength;
        public PictureBox pictureBox = null;
        public int location = 0;
        public Random RandomNumbers;


        //This function is used to make horse run
        public bool HorseRunningFunction()
        {
            RandomNumbers = new Random();//random variable is defined as a new instance 
            int dist = RandomNumbers.Next(1, 5);//Random numbers are assigned to the variables
            MovingHorses(dist);//The function for moving the horses is defined below and is is called here

            location += dist;//Distance is increamented and assigned in location it means location is changed
            if (location >= (HorseTrackLength - StPosition))
            {
                return true;
            }
            return false;
        }
        //The following function moves the horses
        public void MovingHorses(int dist)
        {
            Point p = pictureBox.Location;
            p.Y += dist;
            pictureBox.Location = p;
        }//the following functions resets the position of pictureboxes
        public void TakeStartingPosition()
        {
            MovingHorses(-location);
            location = 0;
        }



    }
}
