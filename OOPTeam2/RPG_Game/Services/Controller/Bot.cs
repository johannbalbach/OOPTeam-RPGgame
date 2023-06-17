using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models;
using OOPTeam2.RPG_Game.Services.Controller;
namespace OOPTeam2.RPG_Game.Services
{
    public class Bot: GameCharacterController
    {
        public bool isDead = false;
        public Bot(ref GameCharacter character)
        {
            managedCharacter = character;
        }
        private void MoveCharacter (GameCharacter player)
        {
            if (player.Position.X < managedCharacter.Position.X)
            {
                managedCharacter.Move(managedCharacter.Position, Direction.Left);
            }
            else
            {
                managedCharacter.Move(managedCharacter.Position, Direction.Right);
            }
        }
        private void ManageBot(GameCharacter player)
        {
            if (config.InDistance(player.Position, managedCharacter.Position))
            {
                managedCharacter.Inventory.Weapons.CurrentWeapon.Hit(player, managedCharacter.CharacterRace);
                //DirtyTalk();
            }
            else
            {
                MoveCharacter(player);
                //DirtyTalk();
            }
        }
        public override void Update(GameCharacter player)
        {
            if (managedCharacter.LifePoint != 0 && !isDead) 
            {
                ManageBot(player);
            }
            else
            {
                isDead = true;
            }
        }
    }
}