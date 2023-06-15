using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models {
    public class FoodMediator {
        private const int InitialFoodCount = 3;
        public Meat Meat { get; set; }
        public Bread Bread { get; set; }
        public Fruit Fruit { get; set; }
        public Flower Flower { get; set; }
        public Water Water { get; set; }
        public Butter Butter { get; set; }
        public Sausage Sausage { get; set; }
        
        public FoodMediator() {
            Meat = new Meat(InitialFoodCount);
            Bread = new Bread(InitialFoodCount);
            Fruit = new Fruit(InitialFoodCount);
            Flower = new Flower( InitialFoodCount);
            Water = new Water(InitialFoodCount);
            Butter = new Butter(InitialFoodCount);
            Sausage = new Sausage(InitialFoodCount);
        }
        
        public void IncreaseFood() {
            Meat.Kilos++;
            Bread.Count++;
            Fruit.Count++;
            Flower.Beam++;
            Water.Volume++;
            Butter.Volume++;
            Sausage.Size++;
        }
    }
}