using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models;


namespace OOPTeam2.RPG_Game
{
    internal class MainLogic
    {
        public MainLogic() 
        {
            FoodMediator foodMediator = new FoodMediator();
            foodMediator.IncreaseFood();
            foodMediator.ReactOnEating(foodMediator.water);
            foodMediator.ReactOnEating(foodMediator.water);
            foodMediator.ReactOnEating(foodMediator.water);
            foodMediator.ReactOnEating(foodMediator.water);
            foodMediator.ReactOnEating(foodMediator.water);
            
            DefaultProtectiveSkin defaultProtectiveSkin = new DefaultProtectiveSkin();
            Cloak cloak = new Cloak(true, true, defaultProtectiveSkin);
            Chinmail chinmail = new Chinmail(3, defaultProtectiveSkin);
            
            defaultProtectiveSkin.ApplyProtection(chinmail);
            defaultProtectiveSkin.ApplyProtection(cloak); // где вывод
            
            
        }
    }
}
