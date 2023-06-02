namespace OOPTeam2.RPG_Game.Models.Wand
{
    public abstract class Wand
    {
        public double powerCoefficient { set; get; }
        public double timeUsingFromNow { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        
        public abstract void Use();
        public abstract void Drop();
        public abstract void Improve();
    }
}