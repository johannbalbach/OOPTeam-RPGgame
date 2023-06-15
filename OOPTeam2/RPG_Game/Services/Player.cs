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
            if (config.InDistance(enemy.position, managedCharacter.position)){
                //enemy.Hit();
                DirtyTalk();
            }
            else{
                DirtyTalk(config.talkProbability /10);
            }
        }
        public void MoveLeft()
        {
            if (true)//������� �����
            {
                managedCharacter.move("left");
            }
        }
        public void MoveRight()
        {
            if (true)//������� �����
            {
                managedCharacter.move("right");
            }
        }

    }
}