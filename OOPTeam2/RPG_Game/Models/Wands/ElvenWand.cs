namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        private const int WAND_COEFFICIENT = 10;
        private const int AVERAGE_POWER = 50;
        public int lifePercentage { set; get; }

        public ElvenWand(int powerCoefficient, string description, bool isAvailable, int lifePercentage, double agility) {
            this.powerCoefficient = powerCoefficient;
            this.description = description;
            this.isAvailable = isAvailable;
            this.lifePercentage = lifePercentage;
            this.agility = agility;
        }

        public override int GetHarm() {
            if (isAvailable) {
                lifePercentage -= WAND_COEFFICIENT;
                return powerCoefficient * lifePercentage / AVERAGE_POWER;
            }

            return powerCoefficient;
        }

        public override void Drop() {
            if (isAvailable) {
                lifePercentage = AVERAGE_POWER;
                isAvailable = false;    
            }
        }

        public override void Improve() {
            if (isAvailable) {
                lifePercentage += WAND_COEFFICIENT;
            }
        }

        public string getWandInfo() {
            return $"Power coefficient: {powerCoefficient}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n" +
                   $"Life percentage: {lifePercentage}\n";
        }
    }
}