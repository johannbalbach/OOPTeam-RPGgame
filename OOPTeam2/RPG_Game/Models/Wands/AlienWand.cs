namespace OOPTeam2.RPG_Game.Models.Wand
{
    public class AlienWand: Wand
    {
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(double powerCoefficient, double timeUsingFromNow, string description, bool isAvailable, bool isAvailableOnEarth)
        {
            this.powerCoefficient = powerCoefficient;
            this.timeUsingFromNow = timeUsingFromNow;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
        }
        
        public override void Use()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Drop()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Improve()
        {
            throw new System.NotImplementedException();
        }
    }
}