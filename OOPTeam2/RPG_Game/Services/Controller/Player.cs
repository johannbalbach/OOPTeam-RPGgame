using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Services.Controller;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player : GameCharacterController
    {
        public Player(GameCharacter character, Race race)
        {
            managedCharacter = character;
            this.race = race;
        }

        public override void Update(GameCharacter enemy)
        {
            if (config.InDistance(enemy.Position, managedCharacter.Position)){
                //enemy.Hit();
                //DirtyTalk();
            }
            else{
                //DirtyTalk(config.talkProbability /10);
            }
        }
        public void MoveLeft()
        {
            if (true)
            {
                managedCharacter.Move(managedCharacter.Position, Direction.Left);
            }
        }
        public void MoveRight()
        {
            if (true)
            {
                managedCharacter.Move(managedCharacter.Position, Direction.Right);
            }
        }

    }
}