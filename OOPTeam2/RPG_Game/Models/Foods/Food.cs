using System;

namespace OOPTeam2.RPG_Game.Models.Foods
{
    public class Food 
    {
        public virtual void Eat() 
        {
            Console.WriteLine("You ate food");
        }
    }
}