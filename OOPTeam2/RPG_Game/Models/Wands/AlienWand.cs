namespace OOPTeam2.RPG_Game.Models.Wands {
    public class AlienWand: Wand {
        private const int WEAK_POWER = 2;
        private const int IMPROVE_POWER = 10;
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(double powerCoefficient, string description, bool isAvailable, bool isAvailableOnEarth) {
            this.powerCoefficient = powerCoefficient;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
        }
        
        public override int Use() {
            if (isAvailable && isAvailableOnEarth) {
                return (int)(powerCoefficient * powerCoefficient);
            }
            return (int)(powerCoefficient / WEAK_POWER);
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
            // пояснение по игре: при этом на Земле палочка продолжает работать
        }
        
        public override void Improve() {
            if (isAvailableOnEarth) {
                powerCoefficient += IMPROVE_POWER;
            }
        }
        
        // почему отсутствует getWandInfo()?
        // по задумке в игре язык инопланетян неизвестен для остальных рас и игрока
    }
}