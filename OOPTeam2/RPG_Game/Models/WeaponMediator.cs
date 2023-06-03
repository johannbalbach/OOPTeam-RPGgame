using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wand;

namespace OOPTeam2.RPG_Game.Models
{
    public class WeaponMediator {
        public Inventory inventory { set; get; }
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
            this.inventory = inventory;
            maceSword = new MaceSword(0.5, 0.5, 0.2, 2, false);
            levithanSword = new LevithanSword(0.8, 0.8, 0.5, 5, false);
            katanaSword = new KatanaSword(0.7, 0.7, 0.4, 4, false);
            healingPotion = new HealingPotion(5, "Hello healing potion", false, 2, 2, 15);
            toxicPotion = new ToxicPotion(5, "Hello toxic potion", false, 2, 2);
            epicPotion = new EpicPotion(5, "Hello epic potion", false, true, 2, 15);
            alienWand = new AlienWand(0.5, 0.5, "Hello alienWand", false, false);
            elvenWand = new ElvenWand(0.8, 0.8, "Hello elven wand", false, 13);
            wizardWand = new WizardWand(0.7, 0.7, "Hello wizard wand", false, 15);
        }
        
        
        public void takeWeapon()
        {
            throw new System.NotImplementedException();
        }
    }
}