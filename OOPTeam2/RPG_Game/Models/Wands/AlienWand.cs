using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {

    public class AlienWand: Wand {
        private bool IsAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, double agility, bool isAvailable, bool isAvailableOnEarth) {
            Damage = damage;
            IsAvailable = isAvailable;
            IsAvailableOnEarth = isAvailableOnEarth;
            Agility = agility;
            SkinId = AlienWandSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Alien
            };
        }
        
        public AlienWand() : this (AlienWandDamage, AlienWandAgility, 
            true, true) {
            
        }

        protected override int ToDamage(CharacterRace characterRace) {
            if (IsAvailable && PossibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return Damage;
        }

        private int CalculateDamage() {
            if (IsAvailableOnEarth) {
                return Damage * Damage;
            }
            return Damage;
        }

        public override void Drop() {
            if (IsAvailable) {
                IsAvailable = false;
            }
            // The wand continues to work on Earth after it is dropped
        }
        
        public override void Improve() {
            if (IsAvailableOnEarth) {
                Damage += AlienWandImprovePower;
            }
        }
        
        // Why is getWandInfo() missing?
        // As suggested in the game, the alien language is unknown to other races and players
    }
}