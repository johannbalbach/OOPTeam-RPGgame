using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Services;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class WizardWand : Wand {
        private SingletonRand RandomGenerator { set; get; }

        public WizardWand(int damage, double agility, bool isAvailable) {
            Damage = damage;
            IsAvailable = isAvailable;
            Agility = agility;
            RandomGenerator = SingletonRand.GetInstance();
            SkinId = WizardWandSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Wizard
            };
        }
        
        public WizardWand() : this (WizardWandDamage, WizardWandAgility, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (IsAvailable && PossibleOwners.Contains(characterRace)) {
                return Damage * Damage;
            }
            return Damage / RandomGenerator.Next(1, 4);
        }

        public void IncreaseAgility() {
            Agility += RandomGenerator.Next(1, 10);
        }
        
        public override void Drop() {
            if (IsAvailable) {
                IsAvailable = false;
            }
        }
        
        public override void Improve() {
            Damage += WizardWandBonusMagic;
        }
        
        public string GetWandInfo() {
            return $"Power coefficient: {Damage}\n" +
                   $"Is available: {IsAvailable}\n";
        }
    }
}