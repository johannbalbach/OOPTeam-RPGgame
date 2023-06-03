using System;

namespace OOPTeam2.RPG_Game.Models
{
    public enum TreeLen {
        Small,
        Medium,
        Big
    }
    
    public class Tree {
        public TreeLen treeLen { get; set; }
        public Bag bag { get; set; }
        
        
        public Tree(TreeLen treeLen) {
            this.treeLen = treeLen;
        }
        
        public void Use() {
            if (treeLen == TreeLen.Small) {
                Console.WriteLine("You cut small tree");
            } else if (treeLen == TreeLen.Medium) {
                Console.WriteLine("You cut medium tree");
            } else if (treeLen == TreeLen.Big) {
                Console.WriteLine("You cut big tree");
            }
        }
    }
}