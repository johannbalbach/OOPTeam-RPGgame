using OOPTeam2.RPG_Game.Models;
using OOPTeam2.RPG_Game.Services.Objects;
using System.Collections.Generic;
 
namespace OOPTeam2.RPG_Game.Services.Map
{
    internal class WorldGenerator
    {
        private int worldSizeX = 300;
        private int worldSizeY = 21;
        private int tileSize = 16;

        private List<StaticObject> staticObjects;
        public WorldGenerator(List<StaticObject> staticObjects)
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
                    stone.Position = new Position(i * tileSize - (worldSizeX * tileSize)/2, j * tileSize);
                    staticObjects.Add(stone);
                }
            }
        }
    }
}
