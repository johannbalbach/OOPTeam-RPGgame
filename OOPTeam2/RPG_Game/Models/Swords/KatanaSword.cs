namespace OOPTeam2.RPG_Game.Models.Swords
{
    public class KatanaSword : Sword
    {
        public KatanaSword(double weight, double agility, double quality, int attack, bool isAvailable)
        {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
        }
        
        public override void Use()
        {
            throw new System.NotImplementedException();
        }

        public override void Drop()
        {
            throw new System.NotImplementedException();
        }
    }
}