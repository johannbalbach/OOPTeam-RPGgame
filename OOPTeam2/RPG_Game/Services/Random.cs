using System;

namespace OOPTeam2.RPG_Game.Services {
    public class RandomGenerator {
        private static RandomGenerator instance;
        private static Random random;

        private RandomGenerator() {
            random = new Random();
        }

        public static RandomGenerator Instance {
            get {
                if (instance == null) {
                    instance = new RandomGenerator();
                }
                return instance;
            }
        }

        public int Next(int minValue = int.MinValue, int maxValue = int.MinValue) {
            if (minValue != int.MinValue && maxValue != int.MinValue) {
                return random.Next(minValue, maxValue);
            }

            if (minValue != int.MinValue) {
                return random.Next(minValue);
            }

            return random.Next();
        }
    }
}