namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Fruit {
        public int count { set; get; }
        public FoodMediator foodMediator { get; set; }
        
        public Fruit(FoodMediator foodMediator, int count) {
            this.count = count;
            this.foodMediator = foodMediator;
        }
        
        public void Eat() {
            if (count > 0) {
                count--;
            }
            else {
                throw new System.Exception("Fruit is over");
            }
        }
    }
}