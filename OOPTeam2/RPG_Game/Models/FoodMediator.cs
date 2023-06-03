using System;
using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models
{
    public class FoodMediator
    {
        private const int INIT_FOOD_COUNT = 3;
        public Meat meat { get; set; }
        public Bread bread { get; set; }
        public Fruit fruit { get; set; }
        public Flower flower { get; set; }
        public Water water { get; set; }
        public Butter butter { get; set; }
        public Sausage sausage { get; set; }
        
        public FoodMediator() {
            meat = new Meat(this, INIT_FOOD_COUNT);
            bread = new Bread(this, INIT_FOOD_COUNT);
            fruit = new Fruit(this, INIT_FOOD_COUNT);
            flower = new Flower(this, INIT_FOOD_COUNT);
            water = new Water(this, INIT_FOOD_COUNT);
            butter = new Butter(this,INIT_FOOD_COUNT);
            sausage = new Sausage(this, INIT_FOOD_COUNT);
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

        public void ReactOnEating(Food food) {
            try {
                food.Eat();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        
        
        
        
    }
}