namespace OOPTeam2.RPG_Game.Models {
    public class Inventory {
        public Bag Bags { set; get; }
        public WeaponMediator Weapons { set; get; }
        
        public Inventory() {
            Bags = new Bag(this);
            Weapons = new WeaponMediator(this);
        }

        public int GetCloakDefenseBonus() {
            return Bags.DefaultProtectiveSkin.GetValueProtection(Bags.Cloak);
        }
        
        public int GetChainMailDefenseBonus() {
            return Bags.DefaultProtectiveSkin.GetValueProtection(Bags.Hauberk);
        }
    }
}