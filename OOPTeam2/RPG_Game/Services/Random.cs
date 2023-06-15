using System;

namespace OOPTeam2.RPG_Game.Services {
    public class SingletonRandomGenerator {
        private static SingletonRandomGenerator instance = null;
        private static Random random;

        private SingletonRandomGenerator() {
            random = new Random();
        }

        public static SingletonRandomGenerator GetInstance() {
            if (instance == null) {
                instance = new SingletonRandomGenerator();
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