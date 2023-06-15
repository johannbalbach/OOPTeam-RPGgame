using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    
    public class ToxicPotion: Potion {
        public ToxicPotion(int volume, string description, int damage) {
            this.volume = volume;
            this.description = description;
            this.damage = damage;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Human,
                CharacterRace.Alien,
                CharacterRace.Elf,
                CharacterRace.Gnome
            };
        }
        
        public ToxicPotion() : this (ToxicPotionVolume, ToxicPotionDescription, ToxicPotionDamage) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                Reduce();
                return damage;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return volume >= ToxicPotionVolume;
        }
        
        public override void Drop() {
            volume = 0;
        }
        
        public override void Improve() {
            volume += ToxicPotionDamageHealth;
        }

        public override void Reduce() {
            volume -= ToxicPotionDamageHealth;
        }
    }
}