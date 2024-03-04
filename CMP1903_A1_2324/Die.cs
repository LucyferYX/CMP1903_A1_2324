using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Die {
        // Property
        public int DieValue {
            get; // Public by default
            set; // Private by default
        }

        // Generates random number
        private static Random random = new Random();

        // Method
        public int DieRoll() {
            // Rolls dice to get value between 1 and 6
            DieValue = random.Next(1, 7);
            return DieValue;
        }
    }
}
