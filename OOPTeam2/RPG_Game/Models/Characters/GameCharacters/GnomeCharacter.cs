using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GnomeCharacter: GameCharacter {
        
        public GnomeCharacter() {
            CharacterRace = CharacterRace.Gnome;
            Text = new CharacterReply(TextEnum.GnomesText);
        }
        
        public override string Talk() {
            return Text.GetText();
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(CharacterRace) && food.IsSufficientQuantity()) {
                food.Consume();
            }
        }
    }
}