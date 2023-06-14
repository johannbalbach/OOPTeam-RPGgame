using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
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
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.WizardCharacter
            };
        }
        
        public WizardWand() {
            damage = WIZARD_WAND_DAMAGE;
            description = WIZARD_WAND_DESCRIPTION;
            agility = WIZARD_WAND_AGILITY;
            random = SingletonRand.GetInstance();
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.WizardCharacter
            };
        }

        public override int GetHarm(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
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
                   $"Is available: {isAvailable}\n";
        }
    }
}