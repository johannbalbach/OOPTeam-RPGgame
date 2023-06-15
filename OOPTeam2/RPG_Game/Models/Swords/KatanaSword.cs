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
                CharacterRace.ElvesCharacter,
                CharacterRace.HumanCharacter
            };
        }

        public KatanaSword() : this (KATANA_SWORD_WEIGHT, KATANA_SWORD_AGILITY, 
                KATANA_SWORD_QUALITY, KATANA_SWORD_ATTACK, true) {
            
        }
        
        /*public override void Hit(GameCharacter gameCharacter) {
            // меч способна отражать только кольчуга
            damage = ToDamage(gameCharacter.characterRace) - gameCharacter.inventory.GetChainmailDefenseBonus();
            gameCharacter.handleDamage(damage);
        }*/

        public override int CalculateDamage() {
            if (agility > KATANA_SWORD_AVERAGE_AGILITY && quality > KATANA_SWORD_AVERAGE_QUALITY) {
                return attack * KATANA_SWORD_BONUS_COEFFICIENT;
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
            agility += KATANA_SWORD_AVERAGE_AGILITY;
            quality += KATANA_SWORD_AVERAGE_QUALITY;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}