using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class ToxicPotion: Potion {
        public ToxicPotion(int volume, string description, bool isAvailable, int damage) {
            this.volume = volume;
            this.description = description;
            this.isAvailable = isAvailable;
            this.damage = damage;
        }
        
        public ToxicPotion() {
            volume = TOXIC_POTION_VOLUME;
            description = TOXIC_POTION_DESCRIPTION;
            damage = TOXIC_POTION_DAMAGE;
        }

        public override int GetHurt() {
            Reduce();
            return damage;
        }
        
        public override void Increase() {
            volume += TOXIC_POTION_DAMAGE_HEALTH;
        }

        public override void Reduce() {
            if (volume >= TOXIC_POTION_DAMAGE_HEALTH) {
                volume -= TOXIC_POTION_DAMAGE_HEALTH;
            }
        }
    }
}