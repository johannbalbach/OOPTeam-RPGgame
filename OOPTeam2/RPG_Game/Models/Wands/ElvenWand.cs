using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        public int lifePercentage { set; get; }

        public ElvenWand(int damage, string description, bool isAvailable, double agility) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.agility = agility;
            lifePercentage = ELVEN_WAND_CAPACITY;
        }

        public ElvenWand() {
            damage = ELVEN_WAND_DAMAGE;
            description = ELVEN_WAND_DESCRIPTION;
            lifePercentage = ELVEN_WAND_CAPACITY;
            agility = ELVEN_WAND_AGILITY;
        }

        public override int GetHarm() {
            if (isAvailable) {
                lifePercentage -= ELVEN_WAND_COEFFICIENT;
                return CalculateDamage();
            }
            return damage;
        }
        
        private int CalculateDamage() {
            int adjustedDamage = damage * damage;
            int adjustedLifePercentage = lifePercentage / ELVEN_WAND_COEFFICIENT;
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
                lifePercentage += ELVEN_WAND_COEFFICIENT;
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