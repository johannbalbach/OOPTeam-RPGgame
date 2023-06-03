namespace OOPTeam2.RPG_Game.Models.Foods
{
    public class Sausage: Food
    {
        public double size { set; get; }
        public FoodMediator foodMediator { get; set; }
        
        public Sausage(FoodMediator foodMediator, double size) {
            this.size = size;
            this.foodMediator = foodMediator;
        }

        public override void Eat() {
            if (size > 0) {
                size -= 0.1;
            }
            else {
                System.Console.WriteLine("Sausage is over");
            }
        }
    }
}