using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class MaceSword : Sword {
        public MaceSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Ork,
            };
        }

        public MaceSword() : this (MaceSwordWeight, MaceSwordAgility, 
                MaceSwordQuality, MaceSwordAttack, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            // If the character’s ancestors (race) possess the sword technique, the damage is increased
            if (possibleOwners.Contains(characterRace) && isAvailable) {
                return CalculateDamage();
            }
            return 0;
        }

        public override int CalculateDamage() {
            if (quality > MaceSwordQuality) {
                return attack * MaceSwordBonusCoefficient;
            }
            return attack;
        }

        public override void Drop() {
            // If you forge a sword, you’ll lose it forever
            if (isAvailable) {
                isAvailable = false;
            }
        }

        public override void Improve() {
            attack += MaceSwordBonusCoefficient;
        }
    }
}