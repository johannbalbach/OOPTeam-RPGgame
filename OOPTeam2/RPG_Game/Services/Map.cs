using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    interface MapStorage
    {
        void create();
        void delete();
    }
    public class Map: MapStorage
    {
        private Picture picture;

        public void create(){}
        public void delete(){}
    }
}