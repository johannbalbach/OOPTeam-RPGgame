namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand {
        public int powerCoefficient { set; get; }
        public double agility { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        
        public abstract int GetHarm();
        public abstract void Drop();
        public abstract void Improve();
    }
}