using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Services.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Map
{
    internal class WorldGenerator
    {
        private int worldSizeX = 100;
        private int worldSizeY = 100;
        private int tileSize = 16;

        private StaticObject staticObjects;
        public WorldGenerator(StaticObject staticObjects)
        {
            this.staticObjects = staticObjects;
        }

        public void CreateWorld()
        {
            for (int i = 0; i < worldSizeX; i++)
            {
                for (int j = 0; j < worldSizeY; j++)
                {
                    Stone stone = new Stone();
                    stone.position = new Position(i * tileSize, j * tileSize);
                    //staticObjects.stones.Add(stone);
                }
            }
        }
    }
}
