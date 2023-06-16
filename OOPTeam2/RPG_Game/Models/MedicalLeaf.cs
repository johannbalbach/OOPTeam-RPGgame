namespace OOPTeam2.RPG_Game.Models {
    public class MedicalLeaf {
        public int HealthPoints { set; get; }
        private int Count;

        public MedicalLeaf(int count, int healthPoints) {
            Count = count;
            HealthPoints = healthPoints;
        }
        
        public MedicalLeaf() {
            
        }
        
        public bool IsAvailable() {
            return Count > 0;
        }
        
        public void Use() {
            Count--;
        }

        public void PickUp(int count) {
            Count += count;
        }
    }
}
