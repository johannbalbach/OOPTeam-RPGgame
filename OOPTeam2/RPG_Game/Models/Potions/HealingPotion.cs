using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, bool isAvailable, int valueHealing) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.valueHealing = valueHealing;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.HealingPotion;
        }
        
        public HealingPotion() {
            volume = HEALING_POTION_VOLUME;
            description = HEALING_POTION_DESCRIPTION;
            valueHealing = HEALING_POTION_VALUE_HEALING;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.HealingPotion;
        }

        public override int GetHurt(CharacterRace batterCharacterRace) {
            Reduce();
            return damage;
        }

        public override void Reduce() {
            if (volume >= HEALING_POTION_DOSE) {
                volume -= HEALING_POTION_DOSE;
            }
        }
        
        public override void Increase() {
            volume += HEALING_POTION_DOSE;
        }
    }
}