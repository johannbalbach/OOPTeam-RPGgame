namespace OOPTeam2.RPG_Game.Models {
    public class ChainMail: ProtectiveSkin {
        private const int InitialCountLayers = 1;
        private int CountChainMail { set; get; }
        private int CountLayers { set; get; }
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