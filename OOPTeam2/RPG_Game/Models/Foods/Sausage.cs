namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Sausage {
        public double size { set; get; }
        public FoodMediator foodMediator { get; set; }
        
        public Sausage(FoodMediator foodMediator, double size) {
            this.size = size;
            this.foodMediator = foodMediator;
        }

        public void Feed() {
            if (size > 0) {
                size -= 0.1;
            }
            else {
                System.Console.WriteLine("Sausage is over");
            }
        }
    }
}