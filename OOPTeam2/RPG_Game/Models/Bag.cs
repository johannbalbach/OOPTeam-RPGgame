using System.Collections.Generic;
using SFML.Graphics;

namespace OOPTeam2.RPG_Game.Models
{
    public class Bag
    {
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
        
        public void CallAvatar() {
            throw new System.NotImplementedException();
        }
        
        private void ReactOnAvatar() {
            throw new System.NotImplementedException();
        }
    }
}