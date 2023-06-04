using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class GameCharacter: Character
    {
        protected int playTime;
        protected Inventory inventory;
        protected bool isEnemy;
        protected double speed;
        protected bool wasDied;

        public GameCharacter()
        {

        }
        public GameCharacter(Inventory inventory, bool wasDied = false, bool isEnemy = true, int playTime = 0, double speed = 3.0f)
        {
            this.playTime = playTime;
            this.inventory = inventory;
            this.isEnemy = isEnemy;
            this.speed = speed;
            this.wasDied = wasDied;
        }
        public override void talk()
        {
            Console.WriteLine("I'm coming for you!");
        }
        public override void move(string direction) {
            this.position.Step(direction);
        }

        public override void sleep() { }

        public override void eat() { }

        public override void changeWeapon() { }

        public override void hit(){ }

        public override void appearance(){ }
    }

}