using System;

namespace OOPTeam2.RPG_Game.Services
{
    public class Generator
    {
        public GameCharacter nonSpawnCharacter;//??
        public Generator() { }//?? nonSpawn

        public GameCharacter SpawnEnemyExcept(Position position)
        {
            SingletonRand rnd = SingletonRand.getInstance();
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
        private Position SpawnPlace(Position exception)
        {
            int x, y;
            y = exception.Y;
            Random rnd = new Random();

            x = rnd.Next(1, 2000);//границы поля

            while ((exception.X - config.botSize - config.attackDistance <= x + config.playerSize)
             || (exception.X + config.botSize + config.attackDistance >= x - config.playerSize))
            {
                x = rnd.Next(1, 2000);//границы поля
            }

            Position position = new Position(x, y);
            return position;
        }

    }
}
