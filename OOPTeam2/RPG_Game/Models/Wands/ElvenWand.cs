﻿namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        private const int WAND_COEFFICIENT = 10;
        private const int AVERAGE_POWER = 50;
        public int lifePercentage { set; get; }

        public ElvenWand(double powerCoefficient, string description, bool isAvailable, int lifePercentage) {
            this.powerCoefficient = powerCoefficient;
            this.description = description;
            this.isAvailable = isAvailable;
            this.lifePercentage = lifePercentage;
        }

        public override int Use() {
            if (isAvailable) {
                lifePercentage -= WAND_COEFFICIENT;
                return (int)powerCoefficient * lifePercentage / AVERAGE_POWER;
            }

            return (int)powerCoefficient;
        }

        public override void Drop() {
            lifePercentage = AVERAGE_POWER;
            isAvailable = false;
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