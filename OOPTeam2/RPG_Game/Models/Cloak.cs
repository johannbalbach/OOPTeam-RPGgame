namespace OOPTeam2.RPG_Game.Models
{
    public class Cloak: ProtectiveSkin
    {
        public bool isProVersion { set; get; }
        public bool isAvailable { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Bag bag { set; get; }
        
        public Cloak(bool isProVersion, bool isAvailable, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.isProVersion = isProVersion;
            this.isAvailable = isAvailable;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
        }
        
        public void Protect()
        {
            throw new System.NotImplementedException();
        }
        
        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }
}