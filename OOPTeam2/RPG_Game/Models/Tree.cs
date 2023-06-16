namespace OOPTeam2.RPG_Game.Models {
    public enum TreeLen {
        Small,
        Medium,
        Big
    }
    
    public class Tree {
        public TreeLen TreeLen { get; set; }

        public Tree(TreeLen treeLen) {
            TreeLen = treeLen;
        }
        
        public Tree() {
            
        }
        
        public string Use() {
            switch (TreeLen) {
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