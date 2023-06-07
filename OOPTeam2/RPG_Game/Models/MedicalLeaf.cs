using System;

namespace OOPTeam2.RPG_Game.Models {
    public class MedicalLeaf {
        public int count { set; get; }
        public int healthPoints { set; get; }

        public MedicalLeaf(int count, int healthPoints) {
            this.count = count;
            this.healthPoints = healthPoints;
        }
        
        public string Use() {
            if (count > 0) {
                count--;
                return "You used medical leaf. Remain: " + count;
            }
            return "There is no medical leaf left!";
        }
        
        public string PickUp() {
            count++;
            return "You picked up medical leaf. Count: " + count;
        }
    }
}