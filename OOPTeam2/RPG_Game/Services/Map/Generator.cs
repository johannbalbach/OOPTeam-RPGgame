using System;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace OOPTeam2.RPG_Game.Services
{
    public class Generator
    {
        public GameCharacter nonSpawnCharacter;//??
        public Generator() { }//?? nonSpawn

        private const int enemySpawnChance = 1;
        private const int npcSpawnChance = 1;
        private const int randomMax = 100;

        public GameCharacter SpawnEnemyExcept(Position position, Race race)
        {
            SingletonRand rnd = SingletonRand.GetInstance();
            if (rnd.Next(randomMax) <= enemySpawnChance)
            {
                int age = rnd.Next(0, 100);
                string name ="", skinIndex = "";
                Position spawnPosition = SpawnPlace(position);

                
                int enemyType = rnd.Next(0, 5);
                while (enemyType == (int)race)
                {
                    enemyType = rnd.Next(0, 5);
                }
                switch (enemyType)
                {
                    case 0:
                        name = "WandEnemy";
                        skinIndex = "WandCharacter";
                        break;
                    case 1:
                        name = "AlienEnemy";
                        skinIndex = "AlienCharacter";
                        break;
                    case 2:
                        name = "HumanEnemy";
                        skinIndex = "HumanCharacter";
                        break;
                    case 3:
                        name = "OrkEnemy";
                        skinIndex = "OrkCharacter";
                        break;
                    case 4:
                        name = "ElvEnemy";
                        skinIndex = "ElfCharacter";
                        break;
                    case 5:
                        name = "GnomeEnemy";
                        skinIndex = "GnomeCharacter";
                        break;
                }
                GameCharacter enemy = new GameCharacter(CreateEnemy(name, spawnPosition, age, skinIndex));
                
                return enemy;
            }
            else
                return null;
        }
        private Position SpawnPlace(Position exception)
        {
            int x, y;
            y = exception.Y;
            SingletonRand rnd = SingletonRand.GetInstance();

            x = rnd.Next(1, 2000);//границы поля
            while (config.InDistance(exception, x))
            {
                x = rnd.Next(1, 2000);//границы поля
            }
            Position position = new Position(x, y);

            return position;
        }
        private GameCharacter CreateEnemy(string name, Position spawnPosition, int age, string skinIndex)
        {
            GameCharacterBuilder enemy = new GameCharacterBuilder();
            enemy.WithPosition(spawnPosition);
            enemy.WithName(name);
            enemy.WithAge(age);
            enemy.WithSkinId(skinIndex);
            return enemy.Build();
        }
    }
}
