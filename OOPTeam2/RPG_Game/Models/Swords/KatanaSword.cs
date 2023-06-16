using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class KatanaSword : Sword {
        public KatanaSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            Weight = weight;
            Agility = agility;
            Quality = quality;
            Attack = attack;
            IsAvailable = isAvailable;
            SkinId = KatanaSwordSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Elf,
                CharacterRace.Human
            };
        }
        public KatanaSword() : this (KatanaSwordWeight, KatanaSwordAgility, 
                KatanaSwordQuality, KatanaSwordAttack, true) {
            
        }

        public override int CalculateDamage() {
            if (Agility > KatanaSwordAverageAgility && Quality > KatanaSwordAverageQuality) {
                return Attack * KatanaSwordBonusCoefficient;
            }
            return Attack;
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (IsAvailable && PossibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return 0;
        }

        public override void Improve() {
            Agility += KatanaSwordAverageAgility;
            Quality += KatanaSwordAverageQuality;
        }

        public override void Drop() {
            if (IsAvailable) {
                IsAvailable = false;
            }
        }
    }
}