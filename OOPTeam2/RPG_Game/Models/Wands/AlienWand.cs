using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {

    public class AlienWand: Wand {
        public bool IsAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, string description, double agility, bool isAvailable, bool isAvailableOnEarth) {
            Damage = damage;
            Description = description;
            IsAvailable = isAvailable;
            IsAvailableOnEarth = isAvailableOnEarth;
            Agility = agility;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Alien
            };
        }
        
        public AlienWand() : this (AlienWandDamage, AlienWandDescription, AlienWandAgility, 
            true, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
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
            // The wand continues to work on Earth
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