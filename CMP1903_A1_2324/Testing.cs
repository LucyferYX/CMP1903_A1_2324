using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For Debug.Assert()
using System.Diagnostics;

namespace CMP1903_A1_2324 {
    internal class Testing {
        // Constants for minimum and maximum die and game value
        private const int MinDie = 1;
        private const int MaxDie = 6;
        private const int MinGame = 3;
        private const int MaxGame = 18;

        // Method
        public void TestingResults() {
            // Declares objects
            Die die = new Die();
            Game game = new Game();

            // Variables
            int dieRoll = die.DieRoll();
            int dieSum = game.RollAndSum();

            // Tests 
            Debug.Assert(dieRoll >= MinDie && dieRoll <= MaxDie, $"Die roll should be between {MinDie} and {MaxDie}. Instead got {dieRoll}.");
            Debug.Assert(dieSum >= MinGame && dieSum <= MaxGame, $"Sum of 3 die rolls should be between {MinGame} and {MaxGame}. Instead got {dieSum}.");
        }
    }
}
