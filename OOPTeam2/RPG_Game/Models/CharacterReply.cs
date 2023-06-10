namespace OOPTeam2.RPG_Game.Models {
    
    public enum TextEnum {
        ElvesText,
        OrksText,
        WizardsText,
        HumansText,
        GnomesText,
        AliensText,
    }
    
    public class CharacterReply {
        private TextEnum key;
    
        public CharacterReply(TextEnum key) {
            this.key = key;
        }
    
        public string GetText() {
            switch (key) {
                case TextEnum.ElvesText:
                    return "Our connection with nature runs deep. We are guardians of the forests, preserving the beauty and harmony of the natural world.";
                case TextEnum.OrksText:
                    return "Me crush puny humans! Orcs strong! Orcs conquer all!";
                case TextEnum.WizardsText:
                    return "I harness the arcane forces to bend reality to my will. Magic flows through my veins like a river of power.";
                case TextEnum.AliensText:
                    return "We are the aliens. We come from distant galaxies, exploring the unknown and seeking new experiences.";
                case TextEnum.GnomesText:
                    return "We are the gnomes. We are masters of invention and craftsmanship. Our creations are renowned throughout the realms.";
                case TextEnum.HumansText:
                    return "We are the humans. We possess great diversity and adaptability. Our ambition and resilience drive us forward.";
                default:
                    return "I'm a unknown character. Fear me!";
            }
        }
    }
}