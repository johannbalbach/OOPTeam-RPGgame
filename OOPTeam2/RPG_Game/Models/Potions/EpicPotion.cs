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
        
        public override bool Use() {
            try {
                // здесь должна быть логика восстановления здоровья
                // нам передается игрок и мы увеличиваем его здоровье на DOSE
                Reduce();
                return true;    
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }
        
        public override void Reduce() {
            if (volume >= BONUS) {
                volume -= BONUS;
            } else {
                throw new Exception("Potion is over");
            }
        }
        
        public override void Increase() {
            bonusPercent += BONUS;
        }
    }
}
