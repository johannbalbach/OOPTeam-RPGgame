namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand {
        public double powerCoefficient { set; get; }
        public int agility { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        
        public abstract int Use();
        public abstract void Drop();
        public abstract void Improve();
    }
}