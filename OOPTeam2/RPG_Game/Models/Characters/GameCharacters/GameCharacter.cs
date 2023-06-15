using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private const int TIME_SLEEP = 3000;
        public int healthRegeneration { get; set; }
        public int receivedDamage { get; set; }
        public int playTime { get; set; }
        public Inventory inventory { get; set; }
        public bool isEnemy { get; set; }
        public double speed { get; set; }
        public string skinId { get; set; }
        public CharacterRace characterRace { get; set; }

        public GameCharacter() {
            inventory = new Inventory();
            lifePoint = INIT_HEALTH;
            characterRace = CharacterRace.UnknownCharacter;
            text = new CharacterReply();
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
                characterRace = target.characterRace;
                lifePoint = target.lifePoint;
                receivedDamage = target.receivedDamage;
            }
        }

        public override Character Clone() {
            return new GameCharacter(this);
        }
        
        public override void Move(Position position, Direction direction) {
            Step(position, direction);
        }
        
        private void RestoreHealth() {
            lifePoint += healthRegeneration;
        }
        
        public void UseMedicine() {
            if (inventory.bags.medicalLeave.IsAvailable()) {
                inventory.bags.medicalLeave.Use();
                RestoreHealth();   
                NormalizeLifePoint();
            }
        }
        
        public void HandleDamage(int damage) {
            ApplyDamage(damage);
            NormalizeLifePoint();
        }

        private void ApplyDamage(int damage) {
            if (damage > 0) {
                lifePoint -= damage;    
            }
        }

        public void FetchHelpingAvatar() {
            if (inventory.bags.IsAvailableCallAvatar()) {
                lifePoint = INIT_HEALTH;
            }
        }

        public override string Talk() {
            return text.GetText();
        }

        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

        public override void Eat(Food food) {
            if (food.IsSufficientQuantity()) {
                food.Eat();
                lifePoint += (healthRegeneration * food.power);
            }
        }
    }
}
