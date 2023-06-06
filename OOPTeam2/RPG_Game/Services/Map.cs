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
        //private Picture picture;
        private AliveObject aliveObjects;
        private StaticObject staticObjects;
        private Player player;
        private Generator generator;
        private const int enemySpawnChance = 10;
        private const int randomMax = 100;
        Random rnd;

        public Map(GameCharacter PlayerCharacter)
        {
            aliveObjects = new AliveObject();
            staticObjects = new StaticObject();
            //подгрузить карту(как?)

            player = new Player(ref PlayerCharacter);
            generator = new Generator();
        }

        public void Update()
        {
            rnd = new Random();
            if (enemySpawnChance <= rnd.Next(randomMax))
            {
                generator.SpawnEnemyExcept(player.managedCharacter.position); //???????
            }
            //Draw??? Нарушает ли принципы ООП? логика и отрисовка в одном месте
            //chance -> generator
        }
        public void OnCreate(){}

        public void OnDelete(){}
    }
}