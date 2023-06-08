namespace OOPTeam2.RPG_Game.Models {
    public class Cloak: ProtectiveSkin {
        public bool isProVersion { set; get; }
        public bool isAvailable { set; get; }
        public int count { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }

        public Cloak(bool isProVersion, bool isAvailable, int count, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.isProVersion = isProVersion;
            this.isAvailable = isAvailable;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
            this.count = count;
        }

        public Cloak() {
            
        }
        
        public void Use() {
            count--;
        }
        
        public void AddCloak() {
            count++;
        }
    }
}