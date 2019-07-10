using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacingGame
{
    public class Bet
    {
        //global variables declaration
        public int Amount;
        public int Horse;
        public Guy Client;

        public Bet(int Amount, int Horse, Guy Client)//this is constructor
        {
            this.Amount = Amount;
            this.Horse = Horse;
            this.Client = Client;
        }

        public string GetDescription()//this function is for setting the description of labels when bet is placed and amount is changed
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets ${1} on Horse #{2}", Client.n, Amount, Horse);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", Client.n);
            }


            return description;
        }

        public int PayOut(int Winner)//this function is for payout to those who win the race
        {
            if (Horse == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
