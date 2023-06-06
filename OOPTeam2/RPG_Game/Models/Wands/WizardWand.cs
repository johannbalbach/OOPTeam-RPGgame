﻿using System;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class WizardWand : Wand {
        private int BONUS_MAGIC = 10;
        private Random random;
        public double waitingTimeUsing { set; get; }
        
        public WizardWand(double powerCoefficient, int agility, string description, bool isAvailable, double waitingTimeUsing) {
            this.powerCoefficient = powerCoefficient;
            this.description = description;
            this.isAvailable = isAvailable;
            this.waitingTimeUsing = waitingTimeUsing;
            this.agility = agility;
            random = new Random();
        }

        public override int Use() {
            if (isAvailable) {
                return (int)(powerCoefficient * powerCoefficient);
            }
            return (int)(powerCoefficient / random.Next(1, 4));
        }
        
        public void IncreaseAgility() {
            agility += random.Next(1, 10);
        }
        
        public override void Drop() {
            // пояснение по игре: если волшебная палочка были выброшена, магия персонажа изменяется от воли судьбы 
            if (isAvailable) {
                int randomValue = random.Next(0, 100);
                BONUS_MAGIC = randomValue;
            }
        }
        
        public override void Improve() {
            powerCoefficient += BONUS_MAGIC;
        }
        
        public string getWandInfo() {
            return $"Power coefficient: {powerCoefficient}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n" +
                   $"Waiting time using: {waitingTimeUsing}\n";
        }
    }
}