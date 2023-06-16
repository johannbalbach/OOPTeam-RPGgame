using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Services.Controller;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player : GameCharacterController
    {
        public Player(GameCharacter character, CharacterRace race)
        {
            managedCharacter = character;
        }

        public override void Update(GameCharacter enemy)
        {
            if (config.InDistance(enemy.Position, managedCharacter.Position)){
                managedCharacter.Inventory.Weapons.CurrentWeapon.Hit(enemy, managedCharacter.CharacterRace);
                //DirtyTalk();
            }
            else{
                //DirtyTalk(config.talkProbability /10);
            }
        }
        public void MoveLeft()
        {
             managedCharacter.Move(managedCharacter.Position, Direction.Left);
        }
        public void MoveRight()
        {
             managedCharacter.Move(managedCharacter.Position, Direction.Right);
        }

    }
}