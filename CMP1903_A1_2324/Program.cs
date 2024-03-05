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

            bool doRoll = true;
            int sumOfDie = 0;
            int sumOfGame = 0;

            // Outputs instructions to console
            Console.WriteLine("Press 1 for Die, 2 for Game, 3 for die sum of Die, 4 for die sum of Game and any other key to exit.");

            // Continuous dice rolls
            while (doRoll) {
                // Reads user's pressed key
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.D1) {
                    // Outputs Die roll for input 1
                    int dieRoll = die.Roll();
                    sumOfDie += dieRoll;
                    Console.WriteLine($"Number of die is {dieRoll}.");
                } else if (keyInfo.Key == ConsoleKey.D2) {
                    // Outputs Game die sum for input 2
                    int gameRoll = game.RollAndSum();
                    sumOfGame += gameRoll;
                    Console.WriteLine($"Sum of 3 die rolls is {gameRoll}.");
                } else if (keyInfo.Key == ConsoleKey.D3) {
                    // Outputs all Die roll sum for input 3
                    Console.WriteLine($"Total die sum for Die is {sumOfDie}.");
                } else if (keyInfo.Key == ConsoleKey.D4) {
                    // Outputs all Game roll sum for input 4
                    Console.WriteLine($"Total die sum for Game is {sumOfGame}.");
                } else {
                    // Exits for any other input
                    doRoll = false;
                }

                tester.TestingResults();
            }
        }
    }
}
