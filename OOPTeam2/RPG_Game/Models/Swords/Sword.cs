using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public abstract class Sword: Weapon {
        protected double Weight { set; get; }
        protected double Agility { set; get; }
        protected double Quality { set; get; }
        protected int Attack { set; get; }
        protected bool IsAvailable { set; get; }
        protected List<CharacterRace> PossibleOwners { set; get; }
        
        public abstract int CalculateDamage();
        
        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            // The sword can only chain mail
            Damage = ToDamage(raceAttackingCharacter) - targetCharacter.Inventory.GetChainMailDefenseBonus();
            targetCharacter.HandleDamage(Damage);
        }
    }
}