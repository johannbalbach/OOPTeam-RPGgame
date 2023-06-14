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
                CharacterRace.OrksCharacter,
            };
        }

        public MaceSword() : this (MACE_SWORD_WEIGHT, MACE_SWORD_AGILITY, 
                MACE_SWORD_QUALITY, MACE_SWORD_ATTACK, true) {
            
        }
        
        public override int ToDamage(CharacterRace characterRace) {
            // если предки персонажа (его раса) владели техникой меча, то урон увеличивается
            if (possibleOwners.Contains(characterRace) && isAvailable) {
                return CalculateDamage();
            }
            return 0;
        }

        public override int CalculateDamage() {
            if (quality > MACE_SWORD_QUALITY) {
                return attack * MACE_SWORD_BONUS_COEFFICIENT;
            }
            return attack;
        }

        public override void Drop() {
            // если выкенешь меч, то потеряешь его навсегда
            if (isAvailable) {
                isAvailable = false;
            }
        }

        public override void Improve() {
            attack += MACE_SWORD_BONUS_COEFFICIENT;
        }
    }
}