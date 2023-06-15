using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    
    public class ToxicPotion: Potion {
        public ToxicPotion(int volume, string description, int damage) {
            Volume = volume;
            Description = description;
            Damage = damage;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Human,
                CharacterRace.Alien,
                CharacterRace.Elf,
                CharacterRace.Gnome
            };
        }
        
        public ToxicPotion() : this (ToxicPotionVolume, ToxicPotionDescription, ToxicPotionDamage) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (PossibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                ReduceVolume();
                return Damage;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return Volume >= ToxicPotionVolume;
        }
        
        public override void Drop() {
            Volume = 0;
        }
        
        public override void Improve() {
            Volume += ToxicPotionDamageHealth;
        }

        public override void ReduceVolume() {
            Volume -= ToxicPotionDamageHealth;
        }
    }
}