﻿using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion: Weapon {
        public int volume { set; get; }
        public int damage { set; get; }
        public int receivedDamage { set; get; }
        public string description { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }
        
        public abstract void Reduce();
        public abstract bool IsEnoughVolume();

        public override void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter) {
            receivedDamage = ToDamage(raceAttackingCharacter);
            targetCharacter.HandleDamage(receivedDamage);
        }
    }
}