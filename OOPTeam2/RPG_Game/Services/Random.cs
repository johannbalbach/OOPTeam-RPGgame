using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class SingletonRand
    {
        private static SingletonRand instance = null;
        private static Random _rnd;

        private SingletonRand()
        {
            _rnd = new Random();
        }

        public static SingletonRand getInstance()
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
                    return _rnd.Next(v1, v2);
                }
                else if(v1 != int.MinValue){
                    return _rnd.Next(v1);
                }
                else
                    return _rnd.Next();
            }
        }
    }
}
