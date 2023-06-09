using System.Threading;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class AlienWand: Wand {
        private const int DELAY_TIME = 3000;
        private const int IMPROVE_POWER = 10;
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, string description, bool isAvailable, bool isAvailableOnEarth, double agility) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
            this.agility = agility;
        }
        
        public override int GetHarm() {
            // при использовании палочки заклинание должно вызывать задержку 
            Thread.Sleep(DELAY_TIME);
            if (isAvailable && isAvailableOnEarth) {
                return damage * damage;
            }
            return damage;
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
            // при этом на Земле палочка продолжает работать
        }
        
        public override void Improve() {
            if (isAvailableOnEarth) {
                damage += IMPROVE_POWER;
            }
        }
        
        // почему отсутствует getWandInfo()?
        // по задумке в игре язык инопланетян неизвестен для остальных рас и игрока
    }
}