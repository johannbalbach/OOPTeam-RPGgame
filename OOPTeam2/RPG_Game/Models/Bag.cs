using System;
using System.Collections.Generic;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public Inventory inventory { set; get; }
        public FoodMediator foodMediator { set; get; }
        public List<Cloak> cloaks { set; get; }
        public List<Chinmail> chinmails { set; get; }
        public List<Tree> trees { set; get; }
        public List<MedicalLeaf> medicalLeaves { set; get; }
        
        public Bag(Inventory inventory, FoodMediator foodMediator, List<Cloak> cloaks, 
                List<Chinmail> chinmails, List<Tree> trees, List<MedicalLeaf> medicalLeaves) {
            this.inventory = inventory;
            this.foodMediator = foodMediator;
            this.cloaks = cloaks;
            this.chinmails = chinmails;
            this.trees = trees;
            this.medicalLeaves = medicalLeaves;
        }
        
        public bool CallAvatar() {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber % 3 == 0) {
                ReactOnAvatar();
                return true;
            }

            return false;
        }
        
        private void ReactOnAvatar() {
            // сюда в аргументы будет передаваться текущий персонаж и у него будет увеличиваться здоровье
            throw new System.NotImplementedException();
        }
    }
}