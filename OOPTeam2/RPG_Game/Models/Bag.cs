using System;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public FoodMediator foodMediator { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Cloak cloak { set; get; }
        public ChainMail chainmail { set; get; }
        public Tree tree { set; get; }
        public MedicalLeaf medicalLeave { set; get; }

        public Bag(Inventory inventory) {
            inventory.bags = this;
            foodMediator = new FoodMediator();
            cloak = new Cloak();
            chainmail = new ChainMail();
            tree = new Tree();
            medicalLeave = new MedicalLeaf();
            defaultProtectiveSkin = new DefaultProtectiveSkin();
        }
        
        public bool IsAvailableCallAvatar() {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber % 3 == 0;
        }

    }
}