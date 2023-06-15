using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {

    public class AlienWand: Wand {
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, string description, double agility, bool isAvailable, bool isAvailableOnEarth) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
            this.agility = agility;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Alien
            };
        }
        
        public AlienWand() : this (AlienWandDamage, AlienWandDescription, AlienWandAgility, 
            true, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return damage;
        }

        private int CalculateDamage() {
            if (isAvailableOnEarth) {
                return damage * damage;
            }
            return damage;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
            // The wand continues to work on Earth
        }
        
        public override void Improve() {
            if (isAvailableOnEarth) {
                damage += AlienWandImprovePower;
            }
        }
        
        // Why is getWandInfo() missing?
        // As suggested in the game, the alien language is unknown to other races and players
    }
}