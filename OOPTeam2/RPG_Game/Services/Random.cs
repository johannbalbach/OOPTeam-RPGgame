using System;

namespace OOPTeam2.RPG_Game.Services {
    public class SingletonRand {
        private static SingletonRand instance = null;
        private static Random random;

        private SingletonRand() {
            random = new Random();
        }

        public static SingletonRand GetInstance() {
            if (instance == null) {
                instance = new SingletonRand();
            }
            return instance;
        }

        public int Next(int v1 = int.MinValue, int v2 = int.MinValue) {
            if (v1 != int.MinValue && v2 != int.MinValue) {
                return random.Next(v1, v2);
            }

            if (v1 != int.MinValue) {
                return random.Next(v1);
            }

            return random.Next();
        }
    }
}