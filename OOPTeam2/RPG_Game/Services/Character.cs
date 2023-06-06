using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPTeam2.RPG_Game.Services
{
    public abstract class Character
    {
        public string name { get; set; }
        public Position position { get; set; }
        protected int age;
        protected string gender;
        protected int lifePoint;
        protected UInt32 skin;
        protected double damage;
        protected double protectionBonus;
        protected int size;
        
        public Character(int age = 0, string gender = "male", UInt32 skin = 0, int size = 10,  int lifePoint = 100, double damage = 10.0, double protectionBonus = 7.0)
        {
            this.age = age;
            this.gender = gender;
            this.lifePoint = lifePoint;
            this.skin = skin;
            this.damage = damage;
            this.protectionBonus = protectionBonus;
            this.size = size;
        }

        public abstract void talk();

        public abstract void move(string direction);

        public abstract void sleep();

        public abstract void eat();

        public abstract void changeWeapon();

        public abstract void hit();
    }
}