using System;
using System.Collections.Generic;

namespace OOPTeam2.RPG_Game.Models {
    public class Bag {
        public List<FoodMediator> foodMediator;
        public List<Cloak> cloaks;
        public List<Chinmail> chinmails;
        public List<Tree> trees;
        public List<MedicalLeaf> medicalLeaves;
        
        public Bag(List<FoodMediator> foodMediator, List<Cloak> cloaks, 
                List<Chinmail> chinmails, List<Tree> trees, List<MedicalLeaf> medicalLeaves) {
            this.foodMediator = foodMediator;
            this.cloaks = cloaks;
            this.chinmails = chinmails;
            this.trees = trees;
            this.medicalLeaves = medicalLeaves;
        }
        
        public bool CallAvatar() {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber % 3 == 0;
        }
        
        public void SetChinmails(Chinmail chinmail) {
            chinmails.Add(chinmail);
        }
        
        public List<Chinmail> GetChinmails() {
            return chinmails;
        }
        
        public void DeleteChinmails(Chinmail chinmail) {
            chinmails.Remove(chinmail);
        }
        
        
        public void SetCloaks(Cloak cloak) {
            cloaks.Add(cloak);
        }
        
        public List<Cloak> GetCloaks() {
            return cloaks;
        }
        
        public void DeleteCloaks(Cloak cloak) {
            cloaks.Remove(cloak);
        }
        
        public List<FoodMediator> GetFoodMediator() {
            return foodMediator;
        }
        
        public void SetFoodMediator(FoodMediator foodMediator) {
            this.foodMediator.Add(foodMediator);
        }
        
        public void DeleteFoodMediator(FoodMediator foodMediator) {
            this.foodMediator.Remove(foodMediator);
        }
        
        public List<Tree> GetTrees() {
            return trees;
        }
        
        public void SetTrees(Tree tree) {
            trees.Add(tree);
        }
        
        public void DeleteTrees(Tree tree) {
            trees.Remove(tree);
        }
        
        public List<MedicalLeaf> GetMedicalLeaves() {
            return medicalLeaves;
        }
        
        public void SetMedicalLeaves(MedicalLeaf medicalLeaf) {
            medicalLeaves.Add(medicalLeaf);
        }
        
        public void DeleteMedicalLeaves(MedicalLeaf medicalLeaf) {
            medicalLeaves.Remove(medicalLeaf);
        }
        

    }
}