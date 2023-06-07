using System;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GameCharacter: Character {
        private int TIME_SLEEP = 3000;
        public int playTime { get; set; }
        public Inventory inventory { get; set; }
        public bool isEnemy { get; set; }
        public bool isAlive { get; set; }
        public double speed { get; set; }
        public string drawId { get; set; }
        
        public GameCharacter(int playTime, Inventory inventory, bool isEnemy, bool isAlive, double speed, string drawId) {
            this.playTime = playTime;
            this.inventory = inventory;
            this.isEnemy = isEnemy;
            this.isAlive = isAlive;
            this.speed = speed;
            this.drawId = drawId;
        }
        
        public GameCharacter() {
            
        }
        
        public override void Move(Position position, string direction) {
            Step(position, direction);
        }

        public override void Hit() {
            throw new System.NotImplementedException();
        }

        public override string Talk() {
            return "Hello, I am a game character!";
        }

        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

        public override void Eat(Food food) {
            throw new System.NotImplementedException();
        }

        public virtual void GetApperance() {
            throw new System.NotImplementedException();
        }
        
        public void Step(Position position, string direction){
            switch(direction){
                case "left":
                    position.x -= 1;
                    break;
                case "right":
                    position.x += 1;
                    break;
                case "top":
                    position.y += 1;
                    break;
                case "down":
                    position.y -= 1;
                    break;
            }
        }

    }
}