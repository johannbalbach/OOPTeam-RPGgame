namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WandCharacter: GameCharacter {
        private const int BONUS_REGENERATION = 3;
        public override string Talk() {
            return "I harness the arcane forces to bend reality to my will. Magic flows through my veins like a river of power.";
        }
    }
}