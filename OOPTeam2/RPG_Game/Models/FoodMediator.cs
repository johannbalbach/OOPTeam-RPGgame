using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models {
    public class FoodMediator {
        private const int INIT_FOOD_COUNT = 3;
        public Meat meat { get; set; }
        public Bread bread { get; set; }
        public Fruit fruit { get; set; }
        public Flower flower { get; set; }
        public Water water { get; set; }
        public Butter butter { get; set; }
        public Sausage sausage { get; set; }
        
        public FoodMediator() {
            meat = new Meat(INIT_FOOD_COUNT);
            bread = new Bread(INIT_FOOD_COUNT);
            fruit = new Fruit(INIT_FOOD_COUNT);
            flower = new Flower( INIT_FOOD_COUNT);
            water = new Water(INIT_FOOD_COUNT);
            butter = new Butter(INIT_FOOD_COUNT);
            sausage = new Sausage(INIT_FOOD_COUNT);
        }
        
        public void IncreaseFood() {
            meat.kilos++;
            bread.count++;
            fruit.count++;
            flower.beam++;
            water.volume++;
            butter.volume++;
            sausage.size++;
        }
    }
}