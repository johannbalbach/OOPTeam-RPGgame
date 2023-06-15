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
                CharacterRace.Human,
                CharacterRace.Alien,
                CharacterRace.Elf,
                CharacterRace.Gnome
            };
        }
        
        public HealingPotion() : this (HealingPotionVolume, 
            HealingPotionDescription, HealingPotionValueHealing)  {
            
        }

        public override void Hit(GameCharacter gameCharacter, CharacterRace attackingCharacterRace) {
            gameCharacter.lifePoint += ToDamage(attackingCharacterRace);
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                ReduceVolume();
                return valueHealing;
            }
            return 0;
        }
        
        public override bool IsEnoughVolume() {
            return volume >= HealingPotionDose;
        }

        public override void ReduceVolume() {
            volume -= HealingPotionDose;
        }

        public override void Drop() {
            volume = 0;
        }

        public override void Improve() {
            volume += HealingPotionDose;
        }
    }
}