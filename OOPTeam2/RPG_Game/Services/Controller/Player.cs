using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;

namespace OOPTeam2.RPG_Game.Services
{
    public class Player
    {
        public GameCharacter managedCharacter { get; private set; }
        public Race race { get; private set; }

        public Player(GameCharacter character, Race race)
        {
            this.managedCharacter = character;
            this.race = race;
        }
        private void DirtyTalk(int probability = config.talkProbability){
            SingletonRand randomSingleton = SingletonRand.getInstance();
            if (probability <= randomSingleton.Next(config.talkMax))
            {
                managedCharacter.Talk();
            }
        }

        public void Update(GameCharacter enemy)
        {
            if (config.InDistance(enemy.position, managedCharacter.position)){
                //enemy.Hit();
                this.DirtyTalk();
            }
            else{
                //Console.WriteLine("movePlayer");
                this.DirtyTalk(config.talkProbability /10);
            }
        }
        public void MoveLeft()
        {
            if (true)//границы карты
            {
                managedCharacter.Move(managedCharacter.position, Direction.Left);
            }
        }
        public void MoveRight()
        {
            if (true)//границы карты
            {
                managedCharacter.Move(managedCharacter.position, Direction.Right);
            }
        }

    }
}