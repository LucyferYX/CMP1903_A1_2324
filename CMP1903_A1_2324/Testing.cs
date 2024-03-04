using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For Debug.Assert()
using System.Diagnostics;

namespace CMP1903_A1_2324 {
    internal class Testing {
        // Method
        public void TestingResults() {
            // Declares objects
            Die die = new Die();
            Game game = new Game();

            // Variables
            int dieRoll = die.DieRoll();
            int dieSum = game.RollAndSum();

            // Tests 
            Debug.Assert(dieRoll >= 1 && dieRoll <= 6, $"Die roll should be between 1 and 6. Instead got {dieRoll}.");
            Debug.Assert(dieSum >= 3 && dieSum <= 18, $"Sum of 3 die rolls should be between 3 and 18. Instead got {dieSum}.");
        }
    }
}
