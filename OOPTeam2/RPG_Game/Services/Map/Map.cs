using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using OOPTeam2.RPG_Game.Models.Characters;

namespace OOPTeam2.RPG_Game.Services.Map
{
    public class Map
    {
        public AliveObject aliveObjects { get; private set; } = new AliveObject();
        public List<StaticObject> staticObjects { get; private set; } = new List<StaticObject>();
        public Player player { get; private set; }
        public AvatarController avatarController { get; private set; }

        private Generator generator = new Generator();
        private List<Bot> bots = new List<Bot>();
        private GameCharacter closestEnemy = new GameCharacter();
        private WorldGenerator worldGenerator;

        public Map(GameCharacter PlayerCharacter, Race race)
        {
            player = new Player(PlayerCharacter, race);
            Avatar avatar = new Avatar("Avatar");
            avatar.Position = new Position(100, 130);
            avatarController = new AvatarController(ref avatar);

            worldGenerator = new WorldGenerator(staticObjects);
            worldGenerator.CreateWorld();
        }

        public void Update()
        {
            GameCharacter enemy = generator.SpawnEnemyExcept(player.managedCharacter.Position, player.race);
            if (enemy != null)
            {
                aliveObjects.Enemies.Add(enemy);
                Bot bot = new Bot(ref enemy);
                bots.Add(bot);
            }
            for (int i = 0; i < bots.Count; i++)
            {
                Position playerPos = player.managedCharacter.Position;
                bots[i].Update(player.managedCharacter);

                if ((playerPos.X - config.playerSize - config.attackDistance <= bots[i].managedCharacter.Position.X + config.playerSize)
                    || (playerPos.X + config.playerSize + config.attackDistance >= bots[i].managedCharacter.Position.X - config.playerSize))
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