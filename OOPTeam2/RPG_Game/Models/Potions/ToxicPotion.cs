namespace OOPTeam2.RPG_Game.Models.Potions
{
    public class ToxicPotion: Potion
    {
        public int valueToxic { set; get; }
        public int coverageArea { set; get; }
        
        public ToxicPotion(int volume, string description, bool isAvailable, int valueToxic, int coverageArea)
        {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.valueToxic = valueToxic;
            this.coverageArea = coverageArea;
        }

        public override void Use()
        {
            throw new System.NotImplementedException();
        }
        
        public override void Increase()
        {
            throw new System.NotImplementedException();
        }

        public override void Reduce()
        {
            throw new System.NotImplementedException();
        }

        public int getLifeTime()
        {
            throw new System.NotImplementedException();
        }
    }
}