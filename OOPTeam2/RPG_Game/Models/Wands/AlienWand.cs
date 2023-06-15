using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Wands {

    public class AlienWand: Wand {
        public bool isAvailableOnEarth { set; get; }
        
        public AlienWand(int damage, string description, double agility, bool isAvailable, bool isAvailableOnEarth) {
            this.damage = damage;
            this.description = description;
            this.isAvailable = isAvailable;
            this.isAvailableOnEarth = isAvailableOnEarth;
            this.agility = agility;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.AlienCharacter
            };
        }
        
        public AlienWand() : this (ALIEN_WAND_DAMAGE, ALIEN_WAND_DESCRIPTION, ALIEN_WAND_AGILITY, 
            true, true) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return damage;
        }

        private int CalculateDamage() {
            if (isAvailableOnEarth) {
                return damage * damage;
            }
            return damage;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
            // при этом на Земле палочка продолжает работать
        }
        
        public override void Improve() {
            if (isAvailableOnEarth) {
                damage += ALIEN_WAND_IMPROVE_POWER;
            }
        }
        
        // почему отсутствует getWandInfo()?
        // по задумке в игре язык инопланетян неизвестен для остальных рас и игрока
    }
}