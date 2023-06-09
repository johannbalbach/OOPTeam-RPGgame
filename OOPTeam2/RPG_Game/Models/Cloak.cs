namespace OOPTeam2.RPG_Game.Models {
    public class Cloak: ProtectiveSkin {
        private const int BASE_PROTECTION = 1;
        private const int PRO_PROTECTION = 2;
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
        
        public int Protect() {
            if (isProVersion) {
                return PRO_PROTECTION;
            }
            return BASE_PROTECTION;
        }
        
        public void Use() {
            count--;
        }
        
        public void AddCloak() {
            count++;
        }
    }
}