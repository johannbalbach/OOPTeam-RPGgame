using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class EpicPotion: Potion {
        public int bonusPercent { set; get; }
        
        public EpicPotion(int volume, string description, bool isAvailable, int bonusPercent, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.bonusPercent = bonusPercent;
            this.damage = damage;
        }
        
        public EpicPotion() {
            volume = EPIC_POTION_VOLUME;
            description = EPIC_POTION_DESCRIPTION;
            bonusPercent = EPIC_POTION_BONUS_PERCENT;
            damage = EPIC_POTION_DAMAGE;
        }
        
        public override int GetHurt() {
            Reduce();
            return damage * bonusPercent;
        }
        
        public override void Reduce() {
            if (volume >= EPIC_POTION_VOLUME) {
                volume -= EPIC_POTION_VOLUME;
            }
        }
        
        public override void Increase() {
            bonusPercent += EPIC_POTION_IMPROVING;
        }
    }
}
