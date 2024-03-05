using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Die {
        // Constants for minimum and maximum die value
        private const int MinDie = 1;
        private const int MaxDie = 6;

        // Property
        public int DieValue {
            get;
            private set;
        }

        // Generates random number
        private static readonly Random _random = new Random();

        // Method
        public int Roll() {
            // Rolls dice to get value between 1 and 6
            DieValue = _random.Next(MinDie, MaxDie+1);
            return DieValue;
        }
    }
}
