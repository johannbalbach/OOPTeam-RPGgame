using System;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public FoodMediator foodMediator { set; get; }
        public Cloak cloaks { set; get; }
        public Chinmail chinmails { set; get; }
        public Tree trees { set; get; }
        public MedicalLeaf medicalLeaves { set; get; }

        public Bag(Inventory inventory) {
            inventory.bags = this;
            foodMediator = new FoodMediator();
            cloaks = new Cloak();
            chinmails = new Chinmail();
            trees = new Tree();
            medicalLeaves = new MedicalLeaf();
        }
        
        public bool IsAvailableCallAvatar() {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber % 3 == 0;
        }

    }
}