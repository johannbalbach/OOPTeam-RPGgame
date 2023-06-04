using System;
using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models;


namespace OOPTeam2.RPG_Game {
    internal class MainLogic {
        public MainLogic() {
            Inventory inventory = new Inventory();
            FoodMediator foodMediator = new FoodMediator();
            List<Cloak> cloaks = new List<Cloak>();
            List<Chinmail> chinmails = new List<Chinmail>();
            List<Tree> trees = new List<Tree>();
            List<MedicalLeaf> medicalLeaves = new List<MedicalLeaf>();
            Bag bag = new Bag(inventory, foodMediator, cloaks, chinmails, trees, medicalLeaves);
            inventory.AddBag(bag);
            inventory.AddWeapon(new WeaponMediator(inventory));

            Console.WriteLine("Inventory: ");
            Console.WriteLine("Bags: " + inventory.bags[0].foodMediator.water.volume);
            Console.WriteLine("Weapons: " + inventory.weapons[0].alienWand.isAvailableOnEarth);
        }
    }
}
