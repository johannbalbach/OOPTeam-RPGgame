namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Flower {
        public int beam { set; get; }
        public FoodMediator foodMediator { get; set; }
        
        public Flower(FoodMediator foodMediator, int beam) {
            this.foodMediator = foodMediator;
            this.beam = beam;
        }
        
        public void Smell() {
            if (beam > 0) {
                beam--;
            }
            else {
                throw new System.Exception("Flower is over");
            }
        }
    }
}