namespace OOPTeam2.RPG_Game.Models {
    public class DefaultProtectiveSkin {
        public int GetValueProtection(ProtectiveSkin skin) {
            skin.Use();
            return skin.GetProtectionLevel();
        }
    }
}