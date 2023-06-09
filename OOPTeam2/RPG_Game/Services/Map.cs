using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Map
    {
        public AliveObject aliveObjects { get; set; } = new AliveObject();
        public StaticObject staticObjects { get; set; } = new StaticObject();
        public Player player { get; }

        static Position pos = new Position(1000, 1200);
        public GameCharacter avatar = new GameCharacter("avatar", pos, 10);
        private AvatarController avatarController;


        private Generator generator = new Generator();
        private List<Bot> bots = new List<Bot>();
        private GameCharacter closestEnemy = new GameCharacter();
        

        public Map(GameCharacter PlayerCharacter)
        {
            //���������� �����, ������� ��������� AliveObjects � StaticObjects

            player = new Player(PlayerCharacter);
            avatarController = new AvatarController(ref avatar);
        }

        public Player GetPlayer()
        {
            return player;
        }

        public void Update()
        {
            //GameCharacter enemy = generator.SpawnEnemyExcept(player.managedCharacter.position);
            //if (enemy != null)
            //{
            //    aliveObjects.Enemies.Add(enemy);
            //    Bot bot = new Bot(ref enemy);
            //    bots.Add(bot);
            //}
            for (int i = 0; i < bots.Count; i++)
            {
                Position playerPos = player.managedCharacter.position;
                bots[i].Update(player.managedCharacter);

                if ((playerPos.X - config.playerSize - config.attackDistance <= bots[i].managedCharacter.position.X + config.playerSize)
                    || (playerPos.X + config.playerSize + config.attackDistance >= bots[i].managedCharacter.position.X - config.playerSize))
                {
                    closestEnemy = bots[i].managedCharacter;
                }
                player.Update(closestEnemy);
            }
            avatarController.Update(player.managedCharacter);

            //���������
        }
        public void OnCreate() { }

        public void OnDelete() { }
    }
}