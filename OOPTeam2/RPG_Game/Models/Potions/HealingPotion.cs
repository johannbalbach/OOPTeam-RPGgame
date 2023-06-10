using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, bool isAvailable, int valueHealing) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.valueHealing = valueHealing;
        }
        
        public HealingPotion() {
            volume = HEALING_POTION_VOLUME;
            description = HEALING_POTION_DESCRIPTION;
            valueHealing = HEALING_POTION_VALUE_HEALING;
        }

        public override int GetHurt() {
            Reduce();
            return damage;
        }

        public override void Reduce() {
            if (volume >= HEALING_POTION_DOSE) {
                volume -= HEALING_POTION_DOSE;
            }
        }
        
        public override void Increase() {
            volume += HEALING_POTION_DOSE;
        }
    }
}