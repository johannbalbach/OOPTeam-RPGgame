using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Bot
    {
        private ref GameCharacter managedCharacter = new GameCharacter();
        private double randomCoefficcient = 1 / 10000;//??
        private int talkCoefficcient = 10;
        private int playerSize = 10;
        private int randomMax = 100;
        private int attackDistance = 5;
        private int botSize = 10;

        public Bot(ref GameCharacter character)
        {
            this.managedCharacter = character;
        }

        private predict()
        {
            //??
        }
        public controlProcess() 
        {
            //??
        }
        public bool inDistance(GameCharacter player){
            if ((managedCharacter.position.X - botSize - attackDistance <= player.position.X + playerSize)
            || (managedCharacter.position.X + botSize + attackDistance >= player.position.X - playerSize)){
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

        public void Update(GameCharacter player)
        {
            if (inDistance(player)){
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
                
                DirtyTalk(talkCoefficcient/10);
            }
        }
    }
}
//Animater Controller
