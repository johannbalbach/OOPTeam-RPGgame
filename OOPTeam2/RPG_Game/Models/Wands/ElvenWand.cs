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
                CharacterRace.ElvesCharacter
            };
        }

        public ElvenWand() : this (ELVEN_WAND_DAMAGE, ELVEN_WAND_DESCRIPTION, ELVEN_WAND_AGILITY, 
            ELVEN_WAND_CAPACITY, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                lifePercentage -= ELVEN_WAND_COEFFICIENT;
                return CalculateDamage();
            }
            return 0;
        }
        
        private int CalculateDamage() {
            int adjustedDamage = damage * damage;
            int adjustedLife = lifePercentage / ELVEN_WAND_COEFFICIENT;
            return adjustedDamage / adjustedLife;
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;    
            }
        }

        public override void Improve() {
            if (isAvailable) {
                lifePercentage += ELVEN_WAND_COEFFICIENT;
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