using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public abstract class Sword: Weapon {
        public double Weight { set; get; }
        public double Agility { set; get; }
        public double Quality { set; get; }
        public int Attack { set; get; }
        public bool IsAvailable { set; get; }
        public List<CharacterRace> PossibleOwners { set; get; }
        
        public abstract int CalculateDamage();
        
        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            // The sword can only chain mail
            Damage = ToDamage(raceAttackingCharacter) - targetCharacter.Inventory.GetChainMailDefenseBonus();
            targetCharacter.HandleDamage(Damage);
        }
    }
}