using System;
using OOPTeam2.RPG_Game.Models;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Swords;

namespace OOPTeam2.RPG_Game {
    internal class MainLogic {
        public MainLogic() {
            GameCharacter gameCharacter = new GameCharacterBuilder()
                .WithPlayTime(100)
                .WithIsEnemy(false)
                .WithSpeed(1.5)
                .WithSkinId("player_skin")
                .WithHealthRegeneration(10)
                .WithAge(25)
                .WithName("John")
                .WithLifePoint(100)
                .WithText(new CharacterReply(TextEnum.ElvesText))
                .WithCharacterRace(CharacterRace.Elf)
                .WithInventory(new Inventory())
                .WithPosition(new Position(0, 0))
                .Build();
            
            GameCharacter test = new OrksCharacter();
            Console.WriteLine(gameCharacter.lifePoint);
            Weapon sword = new MaceSword();
            sword.Hit(gameCharacter, test.characterRace);
            Console.WriteLine(gameCharacter.lifePoint);
        }
    }
}
