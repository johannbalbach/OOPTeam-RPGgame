using System;

namespace OOPTeam2.RPG_Game.Models {
    public enum TreeLen {
        Small,
        Medium,
        Big
    }
    
    public class Tree {
        public TreeLen treeLen { get; set; }

        public Tree(TreeLen treeLen) {
            this.treeLen = treeLen;
        }
        
        public Tree() {
            
        }
        
        public string Use() {
            switch (treeLen) {
                case TreeLen.Small:
                    return "You take small tree";
                case TreeLen.Medium:
                    return "You take medium tree";
                case TreeLen.Big:
                    return "You take big tree";
                default:
                    return "You take undefined tree";
            }
        }
    }
}