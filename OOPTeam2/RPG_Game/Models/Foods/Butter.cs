namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Butter: Food {
        public int volume { set; get; }

        public Butter(int volume) {
            this.volume = volume;
        }
        
        public override void Eat() {
            if (volume > 0) {
                volume--;    
            }
        }
        
    }
}