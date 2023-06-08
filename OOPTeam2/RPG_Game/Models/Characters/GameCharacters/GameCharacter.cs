using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private const int TIME_SLEEP = 3000;
        public int receivedDamage { get; set; }
        public int playTime { get; set; }
        public Inventory inventory { get; set; }
        public bool isEnemy { get; set; }
        public double speed { get; set; }
        public string skinId { get; set; }

        public GameCharacter() {
            inventory = new Inventory();
        }

        public GameCharacter(GameCharacter target) {
            if (target != null) {
                playTime = target.playTime;
                inventory = target.inventory;
                isEnemy = target.isEnemy;
                isAlive = target.isAlive;
                speed = target.speed;
                skinId = target.skinId;
                healthRegeneration = target.healthRegeneration;
                age = target.age;
                name = target.name;
                position = target.position;
            }
        }

        public override Character Clone() {
            return new GameCharacter(this);
        }
        
        
        public override void Move(Position position, Direction direction) {
            Step(position, direction);
        }
        

        public override void Hit(Sword sword) {
            receivedDamage = inventory.weapons.UseSword(sword);
            lifePoint -= receivedDamage;
        }
        
        public override void Hit(Potion potion) {
            receivedDamage = inventory.weapons.UsePotion(potion);
            lifePoint -= receivedDamage;
        }
        
        public override void Hit(Wand wand) {
            receivedDamage = inventory.weapons.UseWand(wand);
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
            lifePoint += healthRegeneration;
        }

        public void Step(Position position, Direction direction){
            switch(direction){
                case Direction.Left:
                    position.x -= 1;
                    break;
                case Direction.Right:
                    position.x += 1;
                    break;
                case Direction.Top:
                    position.y += 1;
                    break;
                case Direction.Down:
                    position.y -= 1;
                    break;
            }
        }


    }
}