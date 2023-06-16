using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion: Weapon {
        protected int Volume { set; get; }
        private int ReceivedDamage { set; get; }
        protected List<CharacterRace> PossibleOwners { set; get; }
        
        public abstract void ReduceVolume();
        public abstract bool IsEnoughVolume();

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            ReceivedDamage = ToDamage(raceAttackingCharacter);
            targetCharacter.HandleDamage(ReceivedDamage);
        }
    }
}