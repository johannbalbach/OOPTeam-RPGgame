using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class KatanaSword : Sword {
        public KatanaSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Elf,
                CharacterRace.Human
            };
        }

        public KatanaSword() : this (KatanaSwordWeight, KatanaSwordAgility, 
                KatanaSwordQuality, KatanaSwordAttack, true) {
            
        }
        
        /*public override void Hit(GameCharacter gameCharacter) {
            // меч способна отражать только кольчуга
            damage = ToDamage(gameCharacter.characterRace) - gameCharacter.inventory.GetChainmailDefenseBonus();
            gameCharacter.handleDamage(damage);
        }*/

        public override int CalculateDamage() {
            if (agility > KatanaSwordAverageAgility && quality > KatanaSwordAverageQuality) {
                return attack * KatanaSwordBonusCoefficient;
            }
            return attack;
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return 0;
        }

        public override void Improve() {
            agility += KatanaSwordAverageAgility;
            quality += KatanaSwordAverageQuality;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}