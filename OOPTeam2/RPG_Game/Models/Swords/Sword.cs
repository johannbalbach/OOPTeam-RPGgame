namespace OOPTeam2.RPG_Game.Models.Swords {
    public abstract class Sword {
        public double weight { set; get; }
        public double agility { set; get; }
        public double quality { set; get; }
        public int attack { set; get; }
        public bool isAvailable { set; get; }

        public abstract int Damage();
        public abstract void Drop();
    }
}