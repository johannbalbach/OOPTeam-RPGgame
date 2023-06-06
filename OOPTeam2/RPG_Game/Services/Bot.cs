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
        private double randomCoefficcient = 1 / 10000;//??
        private const int talkCoefficcient = 10;
        private const int playerSize = 10;
        private const int randomMax = 100;
        private const int attackDistance = 5;
        private const int botSize = 10;

        public Bot(ref GameCharacter character)
        {
            this.managedCharacter = character;
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
        public void PrintName()
        {
            Console.WriteLine(managedCharacter.name);
        }
    }
}

//handler для игрока(лево право)
//Map'у
//ID для всех обьектов с текстуркой
//Прописать объекты
//Генератор челиков
