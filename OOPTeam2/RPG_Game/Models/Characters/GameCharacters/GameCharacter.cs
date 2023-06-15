using System;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private const int TIME_SLEEP = 3000;
        public Direction moveDirection { get; set; }
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
            moveDirection = direction;
        }
        
        private void RestoreHealth() {
            lifePoint += healthRegeneration;
        }
        
        public void UseMedicine() {
            inventory.bags.medicalLeave.Use();
            RestoreHealth();
        }
        

        public override void Hit(Sword sword) {
            // меч способна отражать только кольчуга
            receivedDamage = CalculateReceivedDamage(sword);
            ApplyDamage(receivedDamage);
            NormalizeLifePoint();
           
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
            receivedDamage = CalculateReceivedDamage(wand);
            ApplyDamage(receivedDamage);
            NormalizeLifePoint();
        }
        
        private int CalculateReceivedDamage(Wand wand) {
            // палочку способна отражать только мантия 
            int damage = wand.GetHarm() - inventory.bags.defaultProtectiveSkin.GetValueProtection(inventory.bags.cloak);
            return Math.Max(0, damage);
        }
        
        private void ApplyDamage(int damage) {
            lifePoint -= damage;
        }
        
        private int CalculateReceivedDamage(Sword sword) {
            int damage = sword.GetDamage() - inventory.bags.defaultProtectiveSkin.GetValueProtection(inventory.bags.chainmail);
            return Math.Max(0, damage);
        }
        

        public void FetchHelpingAvatar() {
            if (inventory.bags.IsAvailableCallAvatar()) {
                lifePoint = INIT_HEALTH;
            }
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