using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aDayAtTheRaces
{
    class Guy:Punter
    {
        public string Name;
        public int Money;
        public Bet Bet;

        //guy's gui controls
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public override void UpdateLabels()
        {
            //set the label to my bet's description and label on radio button to show money
            MyLabel.Text = this.Bet.GetDescription();//"Bets $"+Bet.Amount + " on dog " + (Bet.Dog +1);
        }

        public void ClearBet()
        {
            //reset my bet so it's zero
        }

        //Set the Max limit for bucks to spend = 15
        public override bool IsExceedBetLimit(int amount)
        {
            if (amount > 20 && amount >= 5)
                return true;

            return false;
        }
        public override bool PlaceBet(int BetAmount, int DogToWin)
        {
            //Place a new bet and store it
            //return true if guy had enough money to bet
            if (this.Money > BetAmount)
            {
                if (IsExceedBetLimit(BetAmount))
                {
                    MessageBox.Show("You can't spend greater than 20 on dog.", "DOG RACE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                
                else
                {
                    Bet = new Bet()
                    {
                        Amount = BetAmount,
                        Dog = DogToWin,
                        Bettor = this//Amount = numBets.Value, Bettor = Name, Dog = numDog.Value -1
                    };
                }
                UpdateLabels();

                //Console.WriteLine(this.Name + " had enough to bet");
                return true;
            }
            else
            {
                Console.WriteLine(this.Name + " didn't have enough to bet");
                return false;
            }
        }

        public void Collect(int num)
        {
            //ask my bet to pay out, clear my bet, and update my labels
        }
    }
}
