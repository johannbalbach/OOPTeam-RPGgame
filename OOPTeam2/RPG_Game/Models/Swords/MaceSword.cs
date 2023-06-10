using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class MaceSword : Sword {
        public MaceSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }

        public MaceSword() {
            weight = MACE_SWORD_WEIGHT;
            agility = MACE_SWORD_AGILITY;
            quality = MACE_SWORD_QUALITY;
            attack = MACE_SWORD_ATTACK;
        }
        
        public override int GetDamage() {
            // если предки персонажа (его раса) владели техникой меча, то урон увеличивается
            if (isAvailable && quality > MACE_SWORD_QUALITY) {
                return attack * MACE_SWORD_BONUS_COEFFICIENT;
            }
            return attack;
        }
        
        public override void Drop() {
            // если выкенешь меч, то потеряешь его навсегда
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}