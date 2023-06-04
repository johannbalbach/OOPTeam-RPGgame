using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player
    {
        private ref GameCharacter managedCharacter = new GameCharacter();
        private int attackDistance = 5;

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
                if (enemy.position.X < managedCharacter.position.X){
                    managedCharacter.move(managedCharacter.position.Step("left"));
                }
                else{
                    managedCharacter.move(managedCharacter.position.Step("right"));
                }
                
                this.DirtyTalk(talkCoefficcient/10);
            }
        }
    }
}