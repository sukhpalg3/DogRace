using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDayAtTheRaces
{
    abstract class Punter
    {
        public abstract void UpdateLabels();
        public abstract bool IsExceedBetLimit(int amount);
        public abstract bool PlaceBet(int BetAmount, int DogToWin);
    }
}
