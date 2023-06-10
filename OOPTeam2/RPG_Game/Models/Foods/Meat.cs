namespace OOPTeam2.RPG_Game.Models.Foods {
public class Meat: Food {
        public double kilos { get; set; }

        public Meat(double kilos) {
            this.kilos = kilos;
        }
        
        public override void Eat() {
            if (kilos >= 0.1) {
                kilos -= 0.1;
            }
        }
}
}