using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public abstract class Character
    {
        protected string name;
        protected Position position;
        protected int age;
        protected string gender;
        protected int lifePoint;
        protected string skin;
        protected double damage;
        protected double protectionBonus;
        protected int size;
        
        public Character()
        {

        }

        public Character(string name, Position position, int size, string skin, int lifePoint = 100, double damage = 10.0, double protectionBonus = 7.0, int age = 0, string gender = "male")
        {
            this.name = name;
            this.position = position;
            this.age = age;
            this.gender = gender;
            this.lifePoint = lifePoint;
            this.skin = skin;
            this.damage = damage;
            this.protectionBonus = protectionBonus;
            this.size = size;
        }
        
        public abstract void talk() { }

        public abstract void move() { }

        public abstract void sleep() { }

        public abstract void eat() { }

        public abstract void changeWeapon() { }

        public abstract void hit() { }
    }
}