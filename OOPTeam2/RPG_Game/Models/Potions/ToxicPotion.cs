using System;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class ToxicPotion: Potion {
        public const int DAMAGE_HEALTH = 30;
        public int valueToxic { set; get; }
        public int coverageArea { set; get; }
        
        public ToxicPotion(int volume, string description, bool isAvailable, int valueToxic, int coverageArea, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.valueToxic = valueToxic;
            this.coverageArea = coverageArea;
            this.damage = damage;
        }

        public override int GetHurt() {
            Reduce();
            return damage;
        }
        
        public override void Increase() {
            valueToxic += DAMAGE_HEALTH;
        }

        public override void Reduce() {
            if (volume >= DAMAGE_HEALTH) {
                volume -= DAMAGE_HEALTH;
            }
        }
    }
}