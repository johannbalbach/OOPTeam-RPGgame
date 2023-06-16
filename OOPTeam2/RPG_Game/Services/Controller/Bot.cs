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
            if (config.InDistance(player.position, managedCharacter.position)){
                //player.Hit();
                DirtyTalk();
            }
            else{
                if (player.position.x < managedCharacter.position.x){
                    managedCharacter.Move(managedCharacter.position, Direction.Left);
                }
                else{
                    managedCharacter.Move(managedCharacter.position, Direction.Right);
                }
                
                DirtyTalk();
            }
        }
    }
}

//Map'у
//Генератор челиков
