using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class LevithanSword: Sword {
        public LevithanSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Gnome,
                CharacterRace.Human
            };
        }
        
        public LevithanSword() : this (LevithanSwordWeight, LevithanSwordAgility, 
                LevithanSwordQuality, LevithanSwordAttack, true) {
            
        }
        
        /*public override void Hit(GameCharacter gameCharacter) {
            // меч способна отражать только кольчуга
            damage = ToDamage(gameCharacter.characterRace) - gameCharacter.inventory.GetChainmailDefenseBonus();
            gameCharacter.handleDamage(damage);
        }*/
        
        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return 0;
        }
        
        public override int CalculateDamage() {
            if (weight >= LevithanSwordBonusWeight) {
                return attack * LevithanSwordBonusCoefficient;
            }
            return attack;
        }

        public override void Improve() {
            quality += LevithanSwordBonusCoefficient;
            weight -= LevithanSwordBonusWeight;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}