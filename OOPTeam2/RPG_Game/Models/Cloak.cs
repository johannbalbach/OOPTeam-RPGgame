namespace OOPTeam2.RPG_Game.Models {
    public class Cloak: ProtectiveSkin {
        private const int BaseProtectionLevel = 1;
        private const int ProProtectionLevel = 2;
        private bool IsProVersion { set; get; }
        public bool IsAvailable { set; get; }
        private int Count { set; get; }
        public DefaultProtectiveSkin DefaultProtectiveSkin { set; get; }

        public Cloak(bool isProVersion, bool isAvailable, int count, DefaultProtectiveSkin defaultProtectiveSkin) {
            IsProVersion = isProVersion;
            IsAvailable = isAvailable;
            DefaultProtectiveSkin = defaultProtectiveSkin;
            Count = count;
        }

        public Cloak() {
            
        }
        
        public int GetProtectionLevel() {
            if (IsProVersion) {
                return ProProtectionLevel;
            }
            return BaseProtectionLevel;
        }
        
        public void Use() {
            Count--;
        }
        
        public void AddCloak() {
            Count++;
        }
    }
}