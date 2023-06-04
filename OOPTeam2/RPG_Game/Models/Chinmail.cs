using System;

namespace OOPTeam2.RPG_Game.Models {
    public class Chinmail: ProtectiveSkin {
        public int count { set; get; }
        public int countLayers { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Bag bag { set; get; }
        
        public Chinmail(int countLayers, int count, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.countLayers = countLayers;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
            this.count = count;
        }
        
        public void Protect() {
            Use();
            count--;
        }
        
        public void Use() {
            if (count <= 0) {
                throw new Exception("Chinmail is over");
            }
        }
        
        public void AddChinmail() {
            count++;
        }
        
    }
}