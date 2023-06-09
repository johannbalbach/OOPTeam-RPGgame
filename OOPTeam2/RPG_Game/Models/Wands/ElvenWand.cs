using System;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        private const int WAND_COEFFICIENT = 10;
        private const int INIT_CAPACITY = 30;
        public int lifePercentage { set; get; }

        public ElvenWand(int damage, string description, bool isAvailable, double agility) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            lifePercentage = INIT_CAPACITY;
            this.agility = agility;
        }

        public override int GetHarm() {
            if (isAvailable) {
                lifePercentage -= WAND_COEFFICIENT;
                return CalculateDamage();
            }
            return damage;
        }
        
        private int CalculateDamage() {
            int adjustedDamage = damage * damage;
            int adjustedLifePercentage = lifePercentage / WAND_COEFFICIENT;
            int result = adjustedDamage / adjustedLifePercentage;
            return result;
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;    
            }
        }

        public override void Improve() {
            if (isAvailable) {
                lifePercentage += WAND_COEFFICIENT;
            }
        }

        public string getWandInfo() {
            return $"Power coefficient: {damage}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n" +
                   $"Life percentage: {lifePercentage}\n";
        }
    }
}