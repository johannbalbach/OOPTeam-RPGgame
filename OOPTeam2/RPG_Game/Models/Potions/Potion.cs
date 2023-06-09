namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion {
        public int volume { set; get; }
        
        public int damage { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        
        public abstract int GetHurt();
        public abstract void Increase();
        public abstract void Reduce();
    }
}