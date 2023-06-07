using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Bot
    {
        public GameCharacter managedCharacter { get; private set; }

        public Bot(ref GameCharacter character)
        {
            this.managedCharacter = character;
        }

        public bool inDistance(ref GameCharacter player){
            if ((managedCharacter.position.X - config.botSize - config.attackDistance <= player.position.X + config.playerSize)
            || (managedCharacter.position.X + config.botSize + config.attackDistance >= player.position.X - config.playerSize)){
                return true;
            }
            else{
                return false;
            }
        }
        public void DirtyTalk(int probability = config.talkProbability)
        {
            SingletonRand randomSingleton = SingletonRand.getInstance();
            if (probability <= randomSingleton.Next(config.talkMax))
            {
                managedCharacter.talk();
            }
        }

        public void Update(ref GameCharacter player)
        {
            if (inDistance(ref player)){
                managedCharacter.hit();
                DirtyTalk();
            }
            else{
                if (player.position.X < managedCharacter.position.X){
                    managedCharacter.move("left");
                }
                else{
                    managedCharacter.move("right");
                }
                
                DirtyTalk();
            }
        }
        public void PrintName()
        {
            Console.WriteLine(managedCharacter.name);
        }
    }
}

//Map'�
//��������� �������