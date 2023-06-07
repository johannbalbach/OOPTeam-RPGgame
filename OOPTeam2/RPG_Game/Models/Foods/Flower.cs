namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Flower: Food {
        public int beam { set; get; }

        public Flower(int beam) {
            this.beam = beam;
        }
        
        public override void Eat() {
            if (beam > 0) {
                beam--;
            }
        }
    }
}