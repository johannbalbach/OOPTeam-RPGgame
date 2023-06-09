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
            maceSword = new MaceSword(6.3, 0.3, 0.5, 3, false);
            levithanSword = new LevithanSword(3.2, 0.37, 0.5, 2, false);
            katanaSword = new KatanaSword(2.5, 0.4, 0.5, 2, false);
            healingPotion = new HealingPotion(10, "Cure Elixir", false, 2);
            toxicPotion = new ToxicPotion(5, "Laxative", false, 15);
            epicPotion = new EpicPotion(6, "Mystic Elixir", false, 2, 10);
            alienWand = new AlienWand(3, "Arcane", false, false, 0.55);
            elvenWand = new ElvenWand(1,"Luminary", false, 12, 0.45);
            wizardWand = new WizardWand(2, 0.6, "Celestial", false, 15);
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