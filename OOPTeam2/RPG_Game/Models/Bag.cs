using System;
using System.Collections.Generic;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public FoodMediator foodMediator { set; get; }
        private SingletonRand random { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Cloak cloak { set; get; }
        public ChainMail chainmail { set; get; }
        public List<Tree> tree { set; get; }
        public MedicalLeaf medicalLeave { set; get; }

        public Bag(Inventory inventory) {
            inventory.bags = this;
            foodMediator = new FoodMediator();
            cloak = new Cloak();
            chainmail = new ChainMail();
            tree = new List<Tree>();
            medicalLeave = new MedicalLeaf();
            defaultProtectiveSkin = new DefaultProtectiveSkin();
            random = SingletonRand.GetInstance();
        }
        
        public bool IsAvailableCallAvatar() {
            int randomNumber = random.Next(0, 100);
            return randomNumber % 3 == 0;
        }

    }
}