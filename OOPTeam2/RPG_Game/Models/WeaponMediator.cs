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
            maceSword = new MaceSword();
            levithanSword = new LevithanSword();
            katanaSword = new KatanaSword();
            healingPotion = new HealingPotion();
            toxicPotion = new ToxicPotion();
            epicPotion = new EpicPotion();
            alienWand = new AlienWand();
            elvenWand = new ElvenWand(1,"Luminary", false,  0.45);
            wizardWand = new WizardWand(2, 0.6, "Celestial", false, 15);
            inventory.weapons = this;
        }
    }
}