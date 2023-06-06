﻿using System;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class HealingPotion: Potion {
        private const int DOSE = 20;
        public int timeFromLastUsing { set; get; }
        public int timeHealing { set; get; }
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, bool isAvailable, int timeFromLastUsing, int timeHealing, int valueHealing, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.timeFromLastUsing = timeFromLastUsing;
            this.timeHealing = timeHealing;
            this.valueHealing = valueHealing;
            this.damage = damage;
        }

        public override bool Use() {
            try {
                Reduce();
                // здесь должна быть логика восстановления здоровья
                // нам передается игрок и мы увеличиваем его здоровье на DOSE
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public override void Reduce() {
            if (volume >= DOSE) {
                volume -= DOSE;
            } else {
                throw new Exception("Potion is over");
            }
        }
        
        public override void Increase() {
            volume += DOSE;
        }
    }
}