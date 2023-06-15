using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public abstract class Sword: Weapon {
        public double weight { set; get; }
        public double agility { set; get; }
        public double quality { set; get; }
        public int attack { set; get; }
        
        public int damage { set; get; }
        public bool isAvailable { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }
        
        public abstract int CalculateDamage();
        
        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            // The sword can only chain mail
            damage = ToDamage(raceAttackingCharacter) - targetCharacter.inventory.GetChainmailDefenseBonus();
            targetCharacter.HandleDamage(damage);
        }
    }
}