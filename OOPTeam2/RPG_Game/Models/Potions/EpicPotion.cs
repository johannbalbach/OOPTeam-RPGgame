using System;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class EpicPotion: Potion {
        private const int BONUS = 10;
        public int bonusPercent { set; get; }
        
        public EpicPotion(int volume, string description, bool isAvailable, int bonusPercent, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.bonusPercent = bonusPercent;
            this.damage = damage;
        }
        
        public override int GetHurt() {
            Reduce();
            return damage * bonusPercent;
        }
        
        public override void Reduce() {
            if (volume >= BONUS) {
                volume -= BONUS;
            }
        }
        
        public override void Increase() {
            bonusPercent += BONUS;
        }
    }
}
