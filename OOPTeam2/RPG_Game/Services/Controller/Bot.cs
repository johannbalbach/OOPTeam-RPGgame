using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;

namespace OOPTeam2.RPG_Game.Services
{
    public class Bot
    {
        public GameCharacter managedCharacter { get; private set; }


        public Bot(ref GameCharacter character)
        {
            this.managedCharacter = character;
        }

        private void DirtyTalk(int probability = config.talkProbability)
        {
            SingletonRand randomSingleton = SingletonRand.getInstance();
            if (probability <= randomSingleton.Next(config.talkMax))
            {
                managedCharacter.Talk();
            }
        }

        public void Update(GameCharacter player)
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
