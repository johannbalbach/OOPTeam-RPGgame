using System;

namespace OOPTeam2.RPG_Game.Models {
    public class ChainMail: ProtectiveSkin {
        public int count { set; get; }
        public int countLayers { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }

        public ChainMail(int countLayers, int count, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.countLayers = countLayers;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
            this.count = count;
        }
        
        public ChainMail() {
            countLayers = 1;
        }
        
        public int Protect() {
            return countLayers;
        }
        
        public void Use() {
            count--;
        }

        public void AddChinmail() {
            count++;
        }
        
    }
}