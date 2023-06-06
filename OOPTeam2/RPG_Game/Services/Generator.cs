using System;

namespace OOPTeam2.RPG_Game.Services
{
    public class Generator
    {
        public GameCharacter nonSpawnCharacter;//??
        public Generator() { }//?? nonSpawn

        public ref GameCharacter SpawnEnemyExcept(Position position)
        {
            Random rnd = new Random();
            int age = rnd.Next(0, 100);
            int sex = rnd.Next(0, 1);
            string gender, name = "";
            UInt32 skinIndex = 0;
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
                    skinIndex = 1;//
                    break;
                case 1:
                    name = "AlienEnemy";
                    skinIndex = 2;//
                    break;
                case 2:
                    name = "HumanEnemy";
                    skinIndex = 3;//
                    break;
                case 3:
                    name = "OrkEnemy";
                    skinIndex = 4;//
                    break;
                case 4:
                    name = "ElvEnemy";
                    skinIndex = 5;//
                    break;
                case 5:
                    name = "GnomeEnemy";
                    skinIndex = 6;//
                    break;
            }
            GameCharacter enemy = new GameCharacter(name, spawnPosition, age, gender, skinIndex);

            return enemy;////???????
        }
        private Position SpawnPlace(Position exception)
        {
            int x, y;
            y = exception.Y;
            Random rnd = new Random();
            ///
            const int playerSize = 10;
            const int attackDistance = 5;
            const int botSize = 10;
            ///

            x = rnd.Next(1, 2000);//границы поля

            while ((exception.X - botSize - attackDistance <= x + playerSize)
             || (exception.X + botSize + attackDistance >= x - playerSize))
            {
                x = rnd.Next(1, 2000);//границы поля
            }

            Position position = new Position(x, y);
            return position;
        }

    }
}
