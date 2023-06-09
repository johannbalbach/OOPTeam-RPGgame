namespace OOPTeam2.RPG_Game.Models {
    public class MedicalLeaf {
        public int count { set; get; }
        public int healthPoints { set; get; }

        public MedicalLeaf(int count, int healthPoints) {
            this.count = count;
            this.healthPoints = healthPoints;
        }
        
        public MedicalLeaf() {
            
        }
        
        public void Use() {
            if (count > 0) {
                count--;
            }
        }

        public void PickUp(int count) {
            this.count += count;
        }
    }
}
