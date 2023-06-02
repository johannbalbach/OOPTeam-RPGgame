namespace OOPTeam2.RPG_Game.Models.Wand
{
    public class WizardWand : Wand
    {
        public double waitingTimeUsing { set; get; }
        
        public WizardWand(double powerCoefficient, double timeUsingFromNow, string description, bool isAvailable, double waitingTimeUsing)
        {
            this.powerCoefficient = powerCoefficient;
            this.timeUsingFromNow = timeUsingFromNow;
            this.description = description;
            this.isAvailable = isAvailable;
            this.waitingTimeUsing = waitingTimeUsing;
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