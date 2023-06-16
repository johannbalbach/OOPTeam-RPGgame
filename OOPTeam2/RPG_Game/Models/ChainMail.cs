namespace OOPTeam2.RPG_Game.Models {
    public class ChainMail: ProtectiveSkin {
        private const int InitialCountLayers = 1;
        public int CountChainMail { set; get; }
        public int CountLayers { set; get; }
        public DefaultProtectiveSkin DefaultProtectiveSkin { set; get; }

        public ChainMail(int countLayers, int countChainMail, DefaultProtectiveSkin defaultProtectiveSkin) {
            CountLayers = countLayers;
            DefaultProtectiveSkin = defaultProtectiveSkin;
            CountChainMail = countChainMail;
        }
        
        public ChainMail() {
            CountLayers = InitialCountLayers;
        }
        
        public int GetProtectionLevel() {
            return CountLayers;
        }
        
        public void Use() {
            CountChainMail--;
        }

        public void AddChainMail() {
            CountChainMail++;
        }
    }
}