namespace OOPTeam2.RPG_Game.Models.Swords {
    public class MaceSword : Sword {
        private const int BONUS_COEFFICIENT = 3;
        private const double AVERAGE_QUALITY = 0.7;
        
        public MaceSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public override int Damage() {
            // пояснение по игре: если предки персонажа (его раса) владели техникой меча, то урон увеличивается
            if (isAvailable && quality > AVERAGE_QUALITY) {
                return attack * BONUS_COEFFICIENT;
            }
            return attack;
        }
        
        public override void Drop() {
            // пояснение по игре: если выкенешь меч - ПОТЕРЯЕШЬ ЕГО НАВСЕГДА!
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}