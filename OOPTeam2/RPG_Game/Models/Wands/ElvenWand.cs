using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public class ElvenWand : Wand {
        private int LifePercentage { set; get; }

        public ElvenWand(int damage, double agility, int lifePercentage, bool isAvailable) {
            Damage = damage;
            IsAvailable = isAvailable;
            Agility = agility;
            SkinId = ElvenWandSkinId;
            LifePercentage = lifePercentage;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Elf
            };
        }

        public ElvenWand() : this (ElvenWandDamage, ElvenWandAgility, 
            ElvenWandCapacity, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (IsAvailable && PossibleOwners.Contains(characterRace)) {
                LifePercentage -= ElvenWandCoefficient;
                return CalculateDamage();
            }
            return 0;
        }
        
        private int CalculateDamage() {
            int adjustedDamage = Damage * Damage;
            int adjustedLife = LifePercentage / ElvenWandCoefficient;
            return adjustedDamage / adjustedLife;
        }
        
        public override void Drop() {
            if (IsAvailable) {
                IsAvailable = false;    
            }
        }

        public override void Improve() {
            if (IsAvailable) {
                LifePercentage += ElvenWandCoefficient;
            }
        }

        public string GetWandInfo() {
            return $"Power coefficient: {Damage}\n" +
                   $"Is available: {IsAvailable}\n" +
                   $"Agility: {Agility}\n" +
                   $"Life percentage: {LifePercentage}\n";
        }
    }
}