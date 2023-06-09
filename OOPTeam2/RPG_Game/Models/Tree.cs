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
                    return "You cut small tree";
                case TreeLen.Medium:
                    return "You cut medium tree";
                case TreeLen.Big:
                    return "You cut big tree";
                default:
                    return "";
            }
        }
    }
}