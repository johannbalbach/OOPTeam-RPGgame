namespace OOPTeam2.RPG_Game.Models.Wand
{
    public class ElvenWand: Wand
    {
        public int lifePercentage { set; get; }

        public ElvenWand(double powerCoefficient, double timeUsingFromNow, string description, bool isAvailable, int lifePercentage)
        {
            this.powerCoefficient = powerCoefficient;
            this.timeUsingFromNow = timeUsingFromNow;
            this.description = description;
            this.isAvailable = isAvailable;
            this.lifePercentage = lifePercentage;
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