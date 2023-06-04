using System;

namespace OOPTeam2.RPG_Game.Models {
    public class MedicalLeaf {
        public int count { set; get; }
        public int healthPoints { set; get; }
        public Bag bag { set; get; }
        
        public MedicalLeaf(int count, int healthPoints) {
            this.count = count;
            this.healthPoints = healthPoints;
        }
        
        public void Use() {
            if (count > 0) {
                count--;
                Console.WriteLine("You used medical leaf. Remain: " + count);
            }
            else {
                throw new Exception("There is no medical leaf left!");
            }
        }
        
        public void PickUp() {
            count++;
            Console.WriteLine("You picked up medical leaf. Count: " + count);
        }
    }
}