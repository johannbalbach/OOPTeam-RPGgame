namespace OOPTeam2.RPG_Game.Models.Swords {
    public class LevithanSword: Sword {
        private const int BONUS_COEFFICIENT = 2;
        private const int BONUS_WEIGHT = 10;
        
        public LevithanSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public override int GetDamage() {
            if (isAvailable && weight >= BONUS_WEIGHT) {
                return attack * BONUS_COEFFICIENT;
            }
            return attack;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}