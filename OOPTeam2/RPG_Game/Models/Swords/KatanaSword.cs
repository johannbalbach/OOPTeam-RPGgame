using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class KatanaSword : Sword {
        public KatanaSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public KatanaSword() {
            weight = KATANA_SWORD_WEIGHT;
            agility = KATANA_SWORD_AGILITY;
            quality = KATANA_SWORD_QUALITY;
            attack = KATANA_SWORD_ATTACK;
        }
        
        public override int GetDamage() {
            if (isAvailable && agility > KATANA_SWORD_AVERAGE_AGILITY 
                            && quality > KATANA_SWORD_AVERAGE_QUALITY && weight < KATANA_SWORD_AVERAGE_WEIGHT) {
                return attack * KATANA_SWORD_BONUS_COEFFICIENT;
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