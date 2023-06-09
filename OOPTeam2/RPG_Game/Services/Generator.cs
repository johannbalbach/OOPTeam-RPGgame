using System;

namespace OOPTeam2.RPG_Game.Services
{
    public class Generator
    {
        public GameCharacter nonSpawnCharacter;//??
        public Generator() { }//?? nonSpawn

        private const int enemySpawnChance = 1;
        private const int npcSpawnChance = 1;
        private const int randomMax = 100;

        public GameCharacter SpawnEnemyExcept(Position position)
        {
            SingletonRand rnd = SingletonRand.getInstance();
            if (enemySpawnChance <= rnd.Next(randomMax))
            {
                int age = rnd.Next(0, 100);
                int sex = rnd.Next(0, 1);
                string gender, name = "";
                string skinIndex = "enemy";
                if (sex == 1)
                    gender = "male";
                else
                    gender = "female";
                Position spawnPosition = SpawnPlace(position);

                int enemyType = rnd.Next(0, 5);
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
                GameCharacter enemy = new GameCharacter(name, spawnPosition, age, gender, skinIndex);
                return enemy;
            }
            else
                return null;
        }
        private Position SpawnPlace(Position exception)
        {
            int x, y;
            y = exception.Y;
            Random rnd = new Random();

            x = rnd.Next(1, 2000);//границы поля


            while (!((exception.X - config.playerSize - config.attackDistance >= x + config.botSize) || (exception.X + config.playerSize + config.attackDistance <= x - config.botSize)))
            {
                x = rnd.Next(1, 2000);//границы поля
            }
            Position position = new Position(x, y);
            return position;
        }

    }
}
