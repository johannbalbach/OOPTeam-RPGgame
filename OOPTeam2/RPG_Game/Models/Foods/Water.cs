using System;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Water: Food {
        public int volume { get; set; }

        public Water(int volume) {
            this.volume = volume;
        }
        
        public override void Eat() {
            if (volume > 0) {
                volume--;
            }
        }
    }
}