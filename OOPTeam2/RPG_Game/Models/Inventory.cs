using System.Collections.Generic;

namespace OOPTeam2.RPG_Game.Models {
    public class Inventory
    {
        public List<Bag> bags;
        public List<WeaponMediator> weapons;
        
        public Inventory() {
            bags = new List<Bag>();
            weapons = new List<WeaponMediator>();
        }
        
        public void SetBags(Bag bag) {
            bags.Add(bag);
        }
        
        public List<Bag> GetBags() {
            return bags;
        }
        
        public void DeleteBags(Bag bag) {
            bags.Remove(bag);
        }
        
        public void SetWeapons(WeaponMediator weapon) {
            weapons.Add(weapon);
        }
        
        public List<WeaponMediator> GetWeapons() {
            return weapons;
        }
        
        public void DeleteWeapons(WeaponMediator weapon) {
            weapons.Remove(weapon);
        }
    }
}