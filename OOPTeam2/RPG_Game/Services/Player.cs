using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player
    {
        public GameCharacter managedCharacter { get; private set; }

        private const int talkCoefficcient = 10;
        private const int playerSize = 10;
        private const int randomMax = 100;
        private const int attackDistance = 5;
        private const int botSize = 10;

        public Player(ref GameCharacter character)
        {
            this.managedCharacter = character;
        }

        public bool inDistance(GameCharacter enemy){
            if ((managedCharacter.position.X - playerSize - attackDistance <= enemy.position.X + playerSize)
            || (managedCharacter.position.X + playerSize + attackDistance >= enemy.position.X - playerSize)){
                return true;
            }
            else{
                return false;
            }
        }
        public void DirtyTalk(int probability = talkCoefficcient){
            Random rnd = new Random();
            if (probability <=  rnd.Next(randomMax)){
                managedCharacter.talk();
            }
        }

        public void Update(GameCharacter enemy)
        {
            if (inDistance(enemy)){
                managedCharacter.hit();
                this.DirtyTalk();
            }
            else{
                this.DirtyTalk(talkCoefficcient/10);
            }
        }
        public void MoveLeft()
        {
            if (true)//границы карты
            {
                managedCharacter.move("left");
            }
        }
        public void MoveRightn()
        {
            if (true)//границы карты
            {
                managedCharacter.move("right");
            }
        }

    }
}