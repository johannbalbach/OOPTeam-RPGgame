namespace OOPTeam2.RPG_Game.Models.Foods
{
    public class Butter: Food
    {
        public int volume { set; get; }
        public FoodMediator foodMediator { get; set; }
        
        public Butter(FoodMediator foodMediator, int volume) {
            this.foodMediator = foodMediator;
            this.volume = volume;
        }
        
        public override void Eat() {
            if (volume > 0) {
                volume--;    
            }
            else {
                throw new System.Exception("There is no butter left!");
            }
        }
    }
}