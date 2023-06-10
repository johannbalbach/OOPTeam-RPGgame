using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class LevithanSword: Sword {
        public LevithanSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public LevithanSword() {
            weight = LEVITHAN_SWORD_WEIGHT;
            agility = LEVITHAN_SWORD_AGILITY;
            quality = LEVITHAN_SWORD_QUALITY;
            attack = LEVITHAN_SWORD_ATTACK;
        }
        
        public override int GetDamage() {
            if (isAvailable && weight >= LEVITHAN_SWORD_BONUS_WEIGHT) {
                return attack * LEVITHAN_SWORD_BONUS_COEFFICIENT;
            }
            return attack;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}