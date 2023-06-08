using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models {
    public class WeaponMediator {
        public MaceSword maceSword { set; get; }
        public LevithanSword levithanSword { set; get; }
        public KatanaSword katanaSword { set; get; }
        public HealingPotion healingPotion { set; get; }
        public EpicPotion epicPotion { set; get; }
        public ToxicPotion toxicPotion { set; get; }
        public AlienWand alienWand { set; get; }
        public ElvenWand elvenWand { set; get; }
        public WizardWand wizardWand { set; get; }

        public WeaponMediator(Inventory inventory) {
            // /#1#/ подумай какие значения в качестве инициализации будут логичными
            maceSword = new MaceSword(0.5, 0.5, 0.2, 2, false);
            levithanSword = new LevithanSword(0.8, 0.8, 0.5, 5, false);
            katanaSword = new KatanaSword(0.7, 0.7, 0.4, 4, false);
            healingPotion = new HealingPotion(5, "Hello healing potion", false, 2, 2, 15, 10);
            toxicPotion = new ToxicPotion(5, "Hello toxic potion", false, 2, 2, 10);
            epicPotion = new EpicPotion(5, "Hello epic potion", false, true, 2, 15, 22);
            alienWand = new AlienWand(0.5, "Hello world alien", false, true);
            elvenWand = new ElvenWand(0.7, "Hello elven wand", false, 12);
            wizardWand = new WizardWand(0.8, 10, "Hello wizard wand", false, 15);
            inventory.weapons = this;
        }

        public int UseSword(Sword sword) {
            return sword.GetDamage();
        }
        
        public int UsePotion(Potion potion) { 
            return potion.GetHurt();
        }
        
        public int UseWand(Wand wand) {
            return wand.GetHarm();
        }
        
        public void DropSword(Sword sword) {
            sword.Drop();
        }
        
        public void ReducePotion(Potion potion) {
            potion.Reduce();
        }
        
        public void IncreasePotion(Potion potion) {
            potion.Increase();
        }
        
        public void DropWand(Wand wand) {
            wand.Drop();
        }
        
        public void ImpoveWand(Wand wand) {
            wand.Improve();
        }
        
        
    }
}