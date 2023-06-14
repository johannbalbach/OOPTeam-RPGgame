﻿using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    
    public class ToxicPotion: Potion {
        public ToxicPotion(int volume, string description, int damage) {
            this.volume = volume;
            this.description = description;
            this.damage = damage;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.ToxicPotion;
        }
        
        public ToxicPotion() : this (TOXIC_POTION_VOLUME, TOXIC_POTION_DESCRIPTION, TOXIC_POTION_DAMAGE) {
            
        }

        public override int ToDamage(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                Reduce();
                return damage;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return volume >= TOXIC_POTION_VOLUME;
        }
        
        public override void Drop() {
            volume = 0;
        }
        
        public override void Improve() {
            volume += TOXIC_POTION_DAMAGE_HEALTH;
        }

        public override void Reduce() {
            volume -= TOXIC_POTION_DAMAGE_HEALTH;
        }
    }
}