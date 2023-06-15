using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand : Weapon  {
        public int damage { set; get; }
        public int receivedDamage { set; get; }
        public double agility { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            receivedDamage = ToDamage(raceAttackingCharacter) - targetCharacter.inventory.GetCloakDefenseBonus();
            targetCharacter.HandleDamage(receivedDamage);
        }
    }
}