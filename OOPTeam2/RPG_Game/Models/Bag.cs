using System;
using System.Collections.Generic;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public FoodMediator foodMediator { set; get; }
        private SingletonRandomGenerator randomGenerator { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Cloak cloak { set; get; }
        public ChainMail chainmail { set; get; }
        public List<Tree> tree { set; get; }
        public MedicalLeaf medicalLeaf { set; get; }

        public Bag(Inventory inventory) {
            inventory.bags = this;
            foodMediator = new FoodMediator();
            cloak = new Cloak();
            chainmail = new ChainMail();
            tree = new List<Tree>();
            medicalLeaf = new MedicalLeaf();
            defaultProtectiveSkin = new DefaultProtectiveSkin();
            randomGenerator = SingletonRandomGenerator.GetInstance();
        }

        public bool IsAvailableCallAvatar() {
            int randomNumber = randomGenerator.Next(0, 3);
            return randomNumber == 3;
        }

        public bool UseMedicalLeaf() {
            if (medicalLeaf.IsAvailable()) {
                medicalLeaf.Use();
                return true;
            }

            return false;
        }
        
        public string UseTree() {
            if (tree.Count > 0) {
                Tree firstTree = tree[0];
                tree.RemoveAt(0);
                return firstTree.Use();
            }
            return "You don't have a tree";
        }
    }
}