using System;

namespace OOPTeam2.RPG_Game.Models
{
    public class Chinmail: ProtectiveSkin
    {
        public int countLayers { set; get; }
        public DefaultProtectiveSkin defaultProtectiveSkin { set; get; }
        public Bag bag { set; get; }
        
        public Chinmail(int countLayers, DefaultProtectiveSkin defaultProtectiveSkin) {
            this.countLayers = countLayers;
            this.defaultProtectiveSkin = defaultProtectiveSkin;
        }
        
        public void Protect()
        {
            Console.WriteLine("Chinmail is protecting");
            throw new NotImplementedException();
        }
        
        public void Use()
        {
            Console.WriteLine("Chinmail is used");
            throw new NotImplementedException();
        }
        
    }
}