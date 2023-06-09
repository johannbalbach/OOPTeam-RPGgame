using System;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        private const int DOSE = 20;
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, bool isAvailable, int valueHealing) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.valueHealing = valueHealing;
            damage = 0;
        }

        public override int GetHurt() {
            Reduce();
            return damage;
        }

        public override void Reduce() {
            if (volume >= DOSE) {
                volume -= DOSE;
            }
        }
        
        public override void Increase() {
            volume += DOSE;
        }
    }
}