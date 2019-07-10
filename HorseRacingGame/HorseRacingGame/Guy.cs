using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacingGame
{
    public class Guy
    {
        //The gloabl variables are decleared
        public string n;
        public Bet betting;
        public int cash;
        public RadioButton radioButton;
        public Label label;

        public Guy(string name, Bet bet, int cash, RadioButton radioButton, Label Label) //this is constructor
        {
            this.n = name;
            this.betting = bet;
            this.cash = cash;
            this.radioButton = radioButton;
            this.label = Label;
        }
        //The following function is created to update the vales of the labels 
        public void LabelUpdated()        {
            if (betting == null)
            {
                label.Text = String.Format("{0} hasn't placed any bets", n);
            }
            else
            {
                label.Text = betting.GetDescription();
            }
            radioButton.Text = n + " has " + cash + " dollars";
            //The following conditional statement executes When bettor has no money to bet.
            if (cash == 0)
            {
                label.Text = String.Format("BUSTED");
                label.ForeColor = System.Drawing.Color.Red;
                radioButton.Enabled = false;
            }

        }
        
       //The follwoing function clears the bet and reset the value of bet as 0
       public void ClearBet()         {
            betting.Amount = 0;
        }
        //The following function is used for placing the bet 
        public bool PlaceBet(int Amount, int Horse) {
            if (Amount <= cash)
            {
                betting = new Bet(Amount, Horse, this);
                return true;
            }

            return false;
        }

        //The following function calculates the cash for the winner
        public void Collect(int Winner)      {
            cash += betting.PayOut(Winner);
        }

    }
}
