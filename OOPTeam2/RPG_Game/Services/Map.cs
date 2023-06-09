using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Map
    {
        public AliveObject aliveObjects { get; set; }
        public StaticObject staticObjects { get; set; }
        public Player player { get; }

        private Generator generator;
        private List<Bot> bots = new List<Bot>();
        private GameCharacter enemy;

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

            player = new Player(PlayerCharacter);
            generator = new Generator();
        }

        public void Update(Player player)
        {
            SingletonRand rnd = SingletonRand.getInstance();
            if (enemySpawnChance <= rnd.Next(randomMax))
            {
                //GameCharacter enemy = generator.SpawnEnemyExcept(player.managedCharacter.position);
                //aliveObjects.Enemies.Add(enemy);
                //Bot bot = new Bot(ref enemy);
                //bots.Add(bot);
            }
            if (npcSpawnChance <= rnd.Next(randomMax))
            {

            }
            for (int i = 0; i < bots.Count; i++)
            {
                Position playerPos = player.managedCharacter.position;
                bots[i].Update(player.managedCharacter);

                if ((playerPos.X - config.playerSize - config.attackDistance <= bots[i].managedCharacter.position.X + config.playerSize)
                    || (playerPos.X + config.playerSize + config.attackDistance >= bots[i].managedCharacter.position.X - config.playerSize))
                {
                    enemy = bots[i].managedCharacter;
                }
                player.Update(enemy);
            }


            //отрисовка
        }
        public void OnCreate() { }

        public void OnDelete() { }
    }
}