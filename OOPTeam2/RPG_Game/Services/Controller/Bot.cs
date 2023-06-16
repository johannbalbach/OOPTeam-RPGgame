using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Services.Controller;
namespace OOPTeam2.RPG_Game.Services
{
    public class Bot: GameCharacterController
    {
        public Bot(ref GameCharacter character)
        {
            managedCharacter = character;
        }

        public override void Update(GameCharacter player)
        {
            if (managedCharacter.LifePoint != 0) 
            {
                if (config.InDistance(player.Position, managedCharacter.Position))
                {
                    managedCharacter.Inventory.Weapons.CurrentWeapon.Hit(player, managedCharacter.CharacterRace);
                    //DirtyTalk();
                }
                else
                {
                    if (player.Position.X < managedCharacter.Position.X)
                    {
                        managedCharacter.Move(managedCharacter.Position, Direction.Left);
                    }
                    else
                    {
                        managedCharacter.Move(managedCharacter.Position, Direction.Right);
                    }

                    //DirtyTalk();
                }

            }

        }
    }
}