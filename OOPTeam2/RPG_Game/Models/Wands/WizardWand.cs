using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class WizardWand : Wand {
        private SingletonRandomGenerator randomGenerator { set; get; }

        public WizardWand(int damage, double agility, string description, bool isAvailable) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.agility = agility;
            randomGenerator = SingletonRandomGenerator.GetInstance();
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Wizard
            };
        }
        
        public WizardWand() : this (WizardWandDamage, WizardWandAgility, WizardWandDescription, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return damage * damage;
            }
            return damage / randomGenerator.Next(1, 4);
        }

        public void IncreaseAgility() {
            agility += randomGenerator.Next(1, 10);
        }
        
        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
        
        public override void Improve() {
            damage += WizardWandBonusMagic;
        }
        
        public string getWandInfo() {
            return $"Power coefficient: {damage}\n" +
                   $"Description: {description}\n" +
                   $"Is available: {isAvailable}\n";
        }
    }
}