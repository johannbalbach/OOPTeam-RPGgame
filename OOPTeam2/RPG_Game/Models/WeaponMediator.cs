using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models {
    public class WeaponMediator {
        public MaceSword MaceSword { set; get; }
        public Weapon CurrentWeapon { set; get; }
        public LevitanSword LevitanSword { set; get; }
        public KatanaSword KatanaSword { set; get; }
        public HealingPotion HealingPotion { set; get; }
        public EpicPotion EpicPotion { set; get; }
        public ToxicPotion ToxicPotion { set; get; }
        public AlienWand AlienWand { set; get; }
        public ElvenWand ElvenWand { set; get; }
        public WizardWand WizardWand { set; get; }

        public WeaponMediator(Inventory inventory) {
            MaceSword = new MaceSword();
            LevitanSword = new LevitanSword();
            KatanaSword = new KatanaSword();
            HealingPotion = new HealingPotion();
            ToxicPotion = new ToxicPotion();
            EpicPotion = new EpicPotion();
            AlienWand = new AlienWand();
            ElvenWand = new ElvenWand();
            WizardWand = new WizardWand();
            inventory.Weapons = this;
        }
    }
}