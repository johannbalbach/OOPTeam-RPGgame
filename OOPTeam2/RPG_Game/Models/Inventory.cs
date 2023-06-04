using System.Collections.Generic;

namespace OOPTeam2.RPG_Game.Models {
    public class Inventory {
        public List<Bag> bags { set; get; }
        public List<WeaponMediator> weapons { set; get; }
        
        public Inventory() {
            bags = new List<Bag>();
            weapons = new List<WeaponMediator>();
        }
        
        public void AddBag(Bag bag) {
            bags.Add(bag);
        }
        
        public void AddWeapon(WeaponMediator weapon) {
            weapons.Add(weapon);
        }
        
        public void RemoveBag(Bag bag) {
            bags.Remove(bag);
        }
        
        public void RemoveWeapon(WeaponMediator weapon) {
            weapons.Remove(weapon);
        }
    }
}