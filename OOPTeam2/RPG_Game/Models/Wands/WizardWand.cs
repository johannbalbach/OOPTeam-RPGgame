using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class WizardWand : Wand {
        private SingletonRand random { set; get; }
        public double waitingTimeUsing { set; get; }
        
        public WizardWand(int damage, double agility, string description, bool isAvailable, double waitingTimeUsing) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.waitingTimeUsing = waitingTimeUsing;
            this.agility = agility;
            random = SingletonRand.GetInstance();
        }

        public override int GetHarm() {
            if (isAvailable) {
                return damage * damage;
            }
            return damage / random.Next(1, 4);
        }
        
        public void IncreaseAgility() {
            agility += random.Next(1, 10);
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
        
        public override void Improve() {
            damage += WIZARD_WAND_BONUS_MAGIC;
        }
        
        public string getWandInfo() {
            return $"Power coefficient: {damage}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n" +
                   $"Waiting time using: {waitingTimeUsing}\n";
        }
    }
}