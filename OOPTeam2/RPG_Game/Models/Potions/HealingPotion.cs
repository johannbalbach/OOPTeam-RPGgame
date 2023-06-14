using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, int valueHealing) {
            this.volume = volume;
            this.description = description;
            this.valueHealing = valueHealing;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.HealingPotion;
        }
        
        public HealingPotion() : this (HEALING_POTION_VOLUME, 
            HEALING_POTION_DESCRIPTION, HEALING_POTION_VALUE_HEALING)  {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                Reduce();
                return valueHealing;
            }
            return 0;
        }
        
        public override bool IsEnoughVolume() {
            return volume >= HEALING_POTION_DOSE;
        }

        public override void Reduce() {
            volume -= HEALING_POTION_DOSE;
        }

        public override void Drop() {
            volume = 0;
        }

        public override void Improve() {
            volume += HEALING_POTION_DOSE;
        }
    }
}