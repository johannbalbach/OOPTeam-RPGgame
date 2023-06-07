using System;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class EpicPotion: Potion {
        private const int BONUS = 10;
        public bool alert { set; get; }
        public int timeAction { set; get; }
        public int bonusPercent { set; get; }
        
        public EpicPotion(int volume, string description, bool isAvailable, bool alert, int timeAction, int bonusPercent, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.alert = alert;
            this.timeAction = timeAction;
            this.bonusPercent = bonusPercent;
            this.damage = damage;
        }
        
        public override void Use() {
            Reduce();
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
