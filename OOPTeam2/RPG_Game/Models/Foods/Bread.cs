namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Bread {
        public int count { get; set; }
        public FoodMediator foodMediator { get; set; }
        
        public Bread(FoodMediator foodMediator, int count) {
            this.count = count;
            this.foodMediator = foodMediator;
        }
        
        public void Eat() {
            if (count > 0) {
                count--;
            }
            else {
                throw new System.Exception("Bread is over");
            }
        }
    }
}