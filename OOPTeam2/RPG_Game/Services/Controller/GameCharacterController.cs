using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

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
        public virtual void Update(GameCharacter character) { }
    }
}
