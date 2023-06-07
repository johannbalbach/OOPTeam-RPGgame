using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player
    {
        public GameCharacter managedCharacter { get; private set; }

        public Player(ref GameCharacter character)
        {
            this.managedCharacter = character;
        }

        public bool inDistance(ref GameCharacter enemy){
            if ((managedCharacter.position.X - config.playerSize - config.attackDistance <= enemy.position.X + config.playerSize)
            || (managedCharacter.position.X + config.playerSize + config.attackDistance >= enemy.position.X - config.playerSize)){
                return true;
            }
            else{
                return false;
            }
        }
        public void DirtyTalk(int probability = config.talkProbability){
            SingletonRand randomSingleton = SingletonRand.getInstance();
            if (probability <= randomSingleton.Next(config.talkMax))
            {
                managedCharacter.talk();
            }
        }

        public void Update(ref GameCharacter enemy)
        {
            if (inDistance(ref enemy)){
                managedCharacter.hit();
                this.DirtyTalk();
            }
            else{
                this.DirtyTalk(config.talkProbability /10);
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