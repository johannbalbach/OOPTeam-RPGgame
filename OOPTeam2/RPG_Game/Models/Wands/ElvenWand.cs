using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        public int lifePercentage { set; get; }

        public ElvenWand(int damage, string description, double agility, int lifePercentage, bool isAvailable) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.agility = agility;
            this.lifePercentage = lifePercentage;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Elf
            };
        }

        public ElvenWand() : this (ElvenWandDamage, ElvenWandDescription, ElvenWandAgility, 
            ElvenWandCapacity, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                lifePercentage -= ElvenWandCoefficient;
                return CalculateDamage();
            }
            return 0;
        }
        
        private int CalculateDamage() {
            int adjustedDamage = damage * damage;
            int adjustedLife = lifePercentage / ElvenWandCoefficient;
            return adjustedDamage / adjustedLife;
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;    
            }
        }

        public override void Improve() {
            if (isAvailable) {
                lifePercentage += ElvenWandCoefficient;
            }
        }

        public string getWandInfo() {
            return $"Power coefficient: {damage}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n" +
                   $"Agility: {agility}\n" +
                   $"Life percentage: {lifePercentage}\n";
        }
    }
}