using System;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Water {
        public int volume { get; set; }
        public FoodMediator foodMediator { get; set; }
        
        public Water(FoodMediator foodMediator, int volume) {
            this.volume = volume;
            this.foodMediator = foodMediator;
        }
        
        public void Drink() {
            if (volume > 0) {
                volume--;    
                Console.WriteLine("You drank water." + "Remain: " + volume);
            }
            else {
                throw new Exception("There is no water left!");
            }
        }
    }
}