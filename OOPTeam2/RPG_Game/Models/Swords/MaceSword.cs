using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class MaceSword : Sword {
        public MaceSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            Weight = weight;
            Agility = agility;
            Quality = quality;
            Attack = attack;
            IsAvailable = isAvailable;
            SkinId = MaceSwordSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Ork,
            };
        }

        public MaceSword() : this (MaceSwordWeight, MaceSwordAgility, 
                MaceSwordQuality, MaceSwordAttack, true) {
            
        }

        protected override int ToDamage(CharacterRace characterRace) {
            // If the character’s ancestors (race) possess the sword technique, the damage is increased
            if (PossibleOwners.Contains(characterRace) && IsAvailable) {
                return CalculateDamage();
            }
            return 0;
        }

        public override int CalculateDamage() {
            if (Quality > MaceSwordQuality) {
                return Attack * MaceSwordBonusCoefficient;
            }
            return Attack;
        }

        public override void Drop() {
            // If you forge a sword, you’ll lose it forever
            if (IsAvailable) {
                IsAvailable = false;
            }
        }

        public override void Improve() {
            Attack += MaceSwordBonusCoefficient;
        }
    }
}