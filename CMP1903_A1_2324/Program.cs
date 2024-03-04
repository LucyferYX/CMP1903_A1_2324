using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Program {
        static void Main(string[] args) {
            // Creates a Die and Game object
            Die die = new Die();
            Game game = new Game();

            // Creates a Testing object to verify the output and operation of the other classes
            Testing tester = new Testing();

            // Outputs instructions to console
            bool doRoll = true;
            Console.WriteLine("Press 1 for Die, 2 for Game and any other key to exit.");

            // Continuous dice rolls
            while (doRoll) {
                // Reads user's pressed key
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                // Rolls die for input 1
                if (keyInfo.Key == ConsoleKey.D1) {
                    Console.WriteLine($"Number of die is {die.DieRoll()}.");
                    // Outputs dice sum for input 2
                } else if (keyInfo.Key == ConsoleKey.D2) {
                    Console.WriteLine($"Sum of 3 die rolls is {game.RollAndSum()}.");
                    // Exits for any other input
                } else {
                    doRoll = false;
                }

                tester.TestingResults();
            }
        }
    }
}
