using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand : Weapon  {
        private int ReceivedDamage { set; get; }
        protected double Agility { set; get; }
        protected bool IsAvailable { set; get; }
        protected List<CharacterRace> PossibleOwners { set; get; }

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            ReceivedDamage = ToDamage(raceAttackingCharacter) - targetCharacter.Inventory.GetCloakDefenseBonus();
            targetCharacter.HandleDamage(ReceivedDamage);
        }
    }
}