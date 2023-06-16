using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class GameCharacterController
    {
        public GameCharacter managedCharacter { get; protected set; }

        public GameCharacterController() { }

        protected void DirtyTalk(int probability = config.talkProbability)
        {
            SingletonRand randomSingleton = SingletonRand.GetInstance();
            if (randomSingleton.Next(config.talkMax) <= probability)
            {
                managedCharacter.Talk();
            }
        }
        public virtual void Update(GameCharacter character, List<Bot> bots) { }
        public virtual void Update(GameCharacter character) { }
    }
}
