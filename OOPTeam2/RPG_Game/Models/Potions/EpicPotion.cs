namespace OOPTeam2.RPG_Game.Models.Potions
{
    public class EpicPotion: Potion
    {
        public bool alert { set; get; }
        public int timeAction { set; get; }
        public int bonusPercent { set; get; }
        
        public EpicPotion(int volume, string description, bool isAvailable, bool alert, int timeAction, int bonusPercent)
        {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.alert = alert;
            this.timeAction = timeAction;
            this.bonusPercent = bonusPercent;
        }
        
        public override void Use()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Reduce()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Increase()
        {
            throw new System.NotImplementedException();
        }
    }
}