using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class LevitanSword: Sword {
        public LevitanSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            Weight = weight;
            Agility = agility;
            Quality = quality;
            Attack = attack;
            IsAvailable = isAvailable;
            SkinId = LevithanSwordSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Gnome,
                CharacterRace.Human
            };
        }
        
        public LevitanSword() : this (LevithanSwordWeight, LevithanSwordAgility, 
                LevithanSwordQuality, LevithanSwordAttack, true) {
            
        }
        
        protected override int ToDamage(CharacterRace characterRace) {
            if (IsAvailable && PossibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return 0;
        }
        
        public override int CalculateDamage() {
            if (Weight >= LevithanSwordBonusWeight) {
                return Attack * LevithanSwordBonusCoefficient;
            }
            return Attack;
        }

        public override void Improve() {
            Quality += LevithanSwordBonusCoefficient;
            Weight -= LevithanSwordBonusWeight;
        }

        public override void Drop() {
            if (IsAvailable) {
                IsAvailable = false;
            }
        }
    }
}