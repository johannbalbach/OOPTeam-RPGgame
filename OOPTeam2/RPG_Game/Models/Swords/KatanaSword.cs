namespace OOPTeam2.RPG_Game.Models.Swords {
    public class KatanaSword : Sword {
        private const int BONUS_COEFFICIENT = 4;
        private const double AVERAGE_AGILITY = 0.5;
        private const double AVERAGE_QUALITY = 0.65;
        private const int AVERAGE_WEIGHT = 5;
        
        public KatanaSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public override int Damage() {
            if (isAvailable && agility > AVERAGE_AGILITY && quality > AVERAGE_QUALITY && weight < AVERAGE_WEIGHT) {
                return attack * BONUS_COEFFICIENT;
            }
            return attack;
        }

        public override void Drop() {
            /* пояснение по игре: 
             * если выкенешь меч - ПОТЕРЯЕШЬ ЕГО НАВСЕГДА!
             * но если выкенешь снова - ТО ВОЗЬМЕШЬ ЕГО СНОВА!
             * P.S. магия игры, не вникать
            */
            isAvailable = !isAvailable;
        }
    }
}