using System;

namespace OOPTeam2.RPG_Game.Services
{
    public class SingletonRand
    {
        private static SingletonRand instance;
        private static Random random;

        private SingletonRand()
        {
            random = new Random();
        }

        public static SingletonRand GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonRand();
            }
            return instance;
        }

        public int Next(int v1 = int.MinValue, int v2 = int.MinValue)
        {
            //lock (_sync)
            {
                if (v1 != int.MinValue && v2 != int.MinValue){
                    return random.Next(v1, v2);
                }
                else if(v1 != int.MinValue){
                    return random.Next(v1);
                }
                else
                    return random.Next();
            }
        }
    }
}