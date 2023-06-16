using System.Collections.Generic;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public FoodMediator FoodMediator { set; get; }
        private SingletonRand RandomGenerator { set; get; }
        public DefaultProtectiveSkin DefaultProtectiveSkin { set; get; }
        public Cloak Cloak { set; get; }
        public ChainMail Hauberk { set; get; }
        public List<Tree> Trees { set; get; }
        public MedicalLeaf MedicalLeaf { set; get; }

        public Bag(Inventory inventory) {
            inventory.Bags = this;
            FoodMediator = new FoodMediator();
            Cloak = new Cloak();
            Hauberk = new ChainMail();
            Trees = new List<Tree>();
            MedicalLeaf = new MedicalLeaf();
            DefaultProtectiveSkin = new DefaultProtectiveSkin();
            RandomGenerator = SingletonRand.GetInstance();
        }

        public bool IsAvailableCallAvatar() {
            return RandomGenerator.Next(0, 3) == 3;
        }

        public bool UseMedicalLeaf() {
            if (MedicalLeaf.IsAvailable()) {
                MedicalLeaf.Use();
                return true;
            }
            return false;
        }
        
        public string UseTree() {
            if (Trees.Count == 0) {
                return "You don't have a tree";
            }
            var firstTree = Trees[0];
            Trees.RemoveAt(0);
            return firstTree.Use();
            
        }
        
        public void AddTree(Tree tree) {
            Trees.Add(tree);
        }
    }
}