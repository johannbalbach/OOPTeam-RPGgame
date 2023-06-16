using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        public int ValueHealing { set; get; }
        
        public HealingPotion(int volume, string description, int valueHealing) {
            Volume = volume;
            Description = description;
            ValueHealing = valueHealing;
            PossibleOwners = new List<CharacterRace> { 
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
            gameCharacter.LifePoint += ToDamage(attackingCharacterRace);
            gameCharacter.NormalizeLifePoint();
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (PossibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                ReduceVolume();
                return ValueHealing;
            }
            return 0;
        }
        
        public override bool IsEnoughVolume() {
            return Volume >= HealingPotionDose;
        }

        public override void ReduceVolume() {
            Volume -= HealingPotionDose;
        }

        public override void Drop() {
            Volume = 0;
        }

        public override void Improve() {
            Volume += HealingPotionDose;
        }
    }
}