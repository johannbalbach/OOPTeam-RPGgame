using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {

    public class AlienWand: Wand {
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, string description, bool isAvailable, bool isAvailableOnEarth, double agility) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
            this.agility = agility;
        }
        
        public AlienWand() {
            damage = ALIEN_WAND_DAMAGE;
            description = ALIEN_WAND_DESCRIPTION;
            agility = ALIEN_WAND_AGILITY;
        }
        
        public override int GetHarm() {
            // при использовании палочки заклинание должно вызывать задержку 
            if (isAvailable && isAvailableOnEarth) {
                return damage * damage;
            }
            return damage;
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
            // при этом на Земле палочка продолжает работать
        }
        
        public override void Improve() {
            if (isAvailableOnEarth) {
                damage += ALIEN_WAND_IMPROVE_POWER;
            }
        }
        
        // почему отсутствует getWandInfo()?
        // по задумке в игре язык инопланетян неизвестен для остальных рас и игрока
    }
}