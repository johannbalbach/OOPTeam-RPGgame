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
        
        /*public override void Hit(GameCharacter gameCharacter) {
            // меч способна отражать только кольчуга
            damage = ToDamage(gameCharacter.characterRace) - gameCharacter.inventory.GetChainmailDefenseBonus();
            gameCharacter.handleDamage(damage);
        }*/
        
        public override int ToDamage(CharacterRace characterRace) {
            // если предки персонажа (его раса) владели техникой меча, то урон увеличивается
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
            // если выкенешь меч, то потеряешь его навсегда
            if (isAvailable) {
                isAvailable = false;
            }
        }

        public override void Improve() {
            attack += MaceSwordBonusCoefficient;
        }
    }
}