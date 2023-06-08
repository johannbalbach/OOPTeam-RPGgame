namespace OOPTeam2.RPG_Game.Models {
    public class Inventory {
        public Bag bags { set; get; }
        public WeaponMediator weapons { set; get; }
        
        public Inventory() {
            bags = new Bag(this);
            weapons = new WeaponMediator(this);
        }
    }
}