using System;
using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models;

namespace OOPTeam2.RPG_Game {
    internal class MainLogic {
        public MainLogic() {
            Inventory inventory = new Inventory();
            List<FoodMediator> foodMediator = new List<FoodMediator>(); 
            
            foodMediator.Add(new FoodMediator());
            List<Cloak> cloaks = new List<Cloak>();
            List<Chinmail> chinmails = new List<Chinmail>();
            
            
            List<Tree> trees = new List<Tree>();
            List<MedicalLeaf> medicalLeaves = new List<MedicalLeaf>();
            Bag bag = new Bag(foodMediator, cloaks, chinmails, trees, medicalLeaves);
            inventory.SetBags(bag);
            inventory.SetWeapons(new WeaponMediator(inventory));
            
            
            Console.WriteLine("Inventory: ");
            Console.WriteLine("Bags: " + inventory.bags[0].foodMediator[0].bread.count);
            Console.WriteLine("Weapons: " + inventory.weapons[0].katanaSword.attack);
            
            DefaultProtectiveSkin defaultProtectiveSkin = new DefaultProtectiveSkin();

            Cloak cloak = new Cloak(true, true, 10, defaultProtectiveSkin);
            defaultProtectiveSkin.ApplyProtection(cloak);
                
            Chinmail chinmail = new Chinmail(2, 5, defaultProtectiveSkin);
            Console.WriteLine(chinmail.count);
            defaultProtectiveSkin.ApplyProtection(chinmail);
            Console.WriteLine(chinmail.count);
        }
    }
}
