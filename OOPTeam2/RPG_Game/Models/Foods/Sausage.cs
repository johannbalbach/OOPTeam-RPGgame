namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Sausage: Food {
        public double size { set; get; }

        public Sausage(double size) {
            this.size = size;
        }

        public override void Eat() {
            if (size > 0.1) {
                size -= 0.1;
            }
        }
    }
}