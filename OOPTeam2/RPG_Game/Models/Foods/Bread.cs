namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Bread: Food {
        public int count { get; set; }

        public Bread(int count) {
            this.count = count;
        }
        
        public override void Eat() {
            if (count > 0) {
                count--;
            }
        }
    }
}