namespace OOPTeam2.RPG_Game.Models.Potions
{
    public class HealingPotion: Potion
    {
        public int timeFromLastUsing { set; get; }
        public int timeHealing { set; get; }
        public int valueHealing { set; get; }
        
        public HealingPotion(int volume, string description, bool isAvailable, int timeFromLastUsing, int timeHealing, int valueHealing)
        {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.timeFromLastUsing = timeFromLastUsing;
            this.timeHealing = timeHealing;
            this.valueHealing = valueHealing;
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