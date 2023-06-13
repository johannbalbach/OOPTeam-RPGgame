using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using OOPTeam2.RPG_Game.Models.Characters;

namespace OOPTeam2.RPG_Game.Services
{
    public class Map
    {
        public AliveObject aliveObjects { get; private set; } = new AliveObject();
        public StaticObject staticObjects { get; private set; } = new StaticObject();
        public Player player { get; private set; }
        public AvatarController avatarController { get; private set; }

        private Generator generator = new Generator();
        private List<Bot> bots = new List<Bot>();
        private GameCharacter closestEnemy = new GameCharacter();
        

        public Map(GameCharacter PlayerCharacter, Race race)
        {
            //���������� �����, ������� ��������� AliveObjects � StaticObjects

            player = new Player(PlayerCharacter, race);
            Avatar avatar = new Avatar(); // Avatar("avatar", Position(PlayerCharacter.position.x, PlayerCharacter.position.y + config.avatarDistance))
            avatar.position = new Position(100, 130);
            avatarController = new AvatarController(ref avatar);
        }

        public void Update()
        {
            GameCharacter enemy = generator.SpawnEnemyExcept(player.managedCharacter.position, player.race);
            if (enemy != null)
            {
                aliveObjects.Enemies.Add(enemy);
                Bot bot = new Bot(ref enemy);
                bots.Add(bot);
            }
            for (int i = 0; i < bots.Count; i++)
            {
                Position playerPos = player.managedCharacter.position;
                bots[i].Update(player.managedCharacter);

                if ((playerPos.x - config.playerSize - config.attackDistance <= bots[i].managedCharacter.position.x + config.playerSize)
                    || (playerPos.x + config.playerSize + config.attackDistance >= bots[i].managedCharacter.position.x - config.playerSize))
                {
                    closestEnemy = bots[i].managedCharacter;
                }
                player.Update(closestEnemy);
            }
            avatarController.Update(player.managedCharacter);
        }
        public void OnCreate() { }

        public void OnDelete() { }
    }
}