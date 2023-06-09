using System;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private const int TIME_SLEEP = 3000;
        private const int TIME_FREEZING = 1000;
        
        public int healthRegeneration { get; set; }
        public int receivedDamage { get; set; }
        public int playTime { get; set; }
        public Inventory inventory { get; set; }
        public bool isEnemy { get; set; }
        public double speed { get; set; }
        public string skinId { get; set; }

        public GameCharacter() {
            inventory = new Inventory();
            lifePoint = INIT_HEALTH;
        }

        public GameCharacter(int age, string name) {
            this.age = age;
            this.name = name;
            inventory = new Inventory();
            lifePoint = INIT_HEALTH;
        }

        public GameCharacter(GameCharacter target) {
            if (target != null) {
                playTime = target.playTime;
                inventory = target.inventory;
                isEnemy = target.isEnemy;
                speed = target.speed;
                skinId = target.skinId;
                age = target.age;
                name = target.name;
                position = target.position;
                healthRegeneration = target.healthRegeneration;
            }
        }

        public override Character Clone() {
            return new GameCharacter(this);
        }
        
        
        public override void Move(Position position, Direction direction) {
            Step(position, direction);
        }
        
        public virtual void RestoreHealth() {
            lifePoint += healthRegeneration;
        }
        

        public override async void Hit(Sword sword) {
            receivedDamage = sword.GetDamage();
            lifePoint -= receivedDamage;
            await Task.Delay(TIME_FREEZING);
        }
        
        public override void Hit(Potion potion) {
            if (potion is HealingPotion) {
                lifePoint += ((HealingPotion) potion).valueHealing;
            }
            else {
                receivedDamage = potion.GetHurt();
                lifePoint -= receivedDamage;    
            }
            
        }
        
        public override void Hit(Wand wand) {
            receivedDamage = wand.GetHarm();
            lifePoint -= receivedDamage;
        }

        public override string Talk() {
            return "Hello, I am a game character!";
        }

        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

        public override void Eat(Food food) {
            food.Eat();
            lifePoint += (healthRegeneration * food.power);
        }
    }
}