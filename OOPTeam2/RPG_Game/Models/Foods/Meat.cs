namespace OOPTeam2.RPG_Game.Models.Foods {
public class Meat {
        public double kilos { get; set; }
        public FoodMediator foodMediator { get; set; }
        
        public Meat(FoodMediator foodMediator, double kilos) {
            this.kilos = kilos;
            this.foodMediator = foodMediator;
        }
        
        public void Feed() {
            if (kilos > 0) {
                kilos -= 0.1;
            }
            else {
                System.Console.WriteLine("Meat is over");
            }
        }
    }
}