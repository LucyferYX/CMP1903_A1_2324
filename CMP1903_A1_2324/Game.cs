using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Game {
        // Declaring 3 die objects
        private readonly Die _die1 = new Die();
        private readonly Die _die2 = new Die();
        private readonly Die _die3 = new Die();

        // Method
        public int RollAndSum() {
            // Rolling the dice
            int roll1 = _die1.DieRoll();
            int roll2 = _die2.DieRoll();
            int roll3 = _die3.DieRoll();

            // Calculating the sum
            return roll1 + roll2 + roll3;
        }
    }
}
