using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    interface MapStorage
    {
        void OnCreate();
        void OnDelete();
    }
    public class Map: MapStorage
    {
        private AliveObject aliveObjects;
        private StaticObject staticObjects;
        private Player player;
        private Generator generator;

        ///
        private const int enemySpawnChance = 10;
        private const int npcSpawnChance = 10;
        private const int randomMax = 100;
        ///

        public Map(GameCharacter PlayerCharacter)
        {
            aliveObjects = new AliveObject();
            staticObjects = new StaticObject();
            //подгрузить карту, достать дефолтные AliveObjects и StaticObjects

            player = new Player(ref PlayerCharacter);
            generator = new Generator();
        }

        public void Update()
        {
            SingletonRand rnd = SingletonRand.getInstance();
            if (enemySpawnChance <= rnd.Next(randomMax))
            {
                aliveObjects.Enemies.Add(generator.SpawnEnemyExcept(player.managedCharacter.position));
            }
            if (npcSpawnChance <= rnd.Next(randomMax))
            {

            }
            //отрисовка
        }
        public void OnCreate(){}

        public void OnDelete(){}
    }
}