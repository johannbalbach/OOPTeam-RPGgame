using System;

namespace OOPTeam2.RPG_Game.Models {
    public class Chinmail: ProtectiveSkin {
        public int count { set; get; }
        public int countLayers { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }

        public Chinmail(int countLayers, int count, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.countLayers = countLayers;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
            this.count = count;
        }
        
        public void Use() {
            count--;
        }

        public void AddChinmail() {
            count++;
        }
        
    }
}