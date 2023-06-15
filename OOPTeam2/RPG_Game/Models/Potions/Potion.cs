using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion: Weapon {
        public int Volume { set; get; }
        public int ReceivedDamage { set; get; }
        public string Description { set; get; }
        public List<CharacterRace> PossibleOwners { set; get; }
        
        public abstract void ReduceVolume();
        public abstract bool IsEnoughVolume();

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            ReceivedDamage = ToDamage(raceAttackingCharacter);
            targetCharacter.HandleDamage(ReceivedDamage);
        }
    }
}