using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand : Weapon  {
        public int ReceivedDamage { set; get; }
        public double Agility { set; get; }
        public string Description { set; get; }
        public bool IsAvailable { set; get; }
        public List<CharacterRace> PossibleOwners { set; get; }

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            ReceivedDamage = ToDamage(raceAttackingCharacter) - targetCharacter.Inventory.GetCloakDefenseBonus();
            targetCharacter.HandleDamage(ReceivedDamage);
        }
    }
}