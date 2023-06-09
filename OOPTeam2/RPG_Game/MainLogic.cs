using System;
using OOPTeam2.RPG_Game.Models;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game {
    internal class MainLogic {
        public MainLogic() {
            DefaultProtectiveSkin defaultProtectiveSkin = new DefaultProtectiveSkin();

            Cloak cloak = new Cloak(true, true, 10, defaultProtectiveSkin);
            defaultProtectiveSkin.GetValueProtection(cloak);

            GameCharacter gameCharacter = new GameCharacterBuilder()
                .WithPlayTime(100)
                .WithIsEnemy(false)
                .WithSpeed(1.5)
                .WithSkinId("player_skin")
                .WithHealthRegeneration(10)
                .WithAge(25)
                .WithName("John")
                .WithLifePoint(100)
                .WithInventory(new Inventory())
                .WithPosition(new Position(0, 0))
                .Build();

            gameCharacter.inventory.bags.chainmail.count = 10;
            /*Console.WriteLine(gameCharacter.inventory.bags.foodMediator.bread.count);
            gameCharacter.Sleep();
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.Hit(gameCharacter.inventory.weapons.katanaSword); 
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.Hit(gameCharacter.inventory.weapons.katanaSword);
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.UseMedicine();
            Console.WriteLine(gameCharacter.lifePoint);*/
            gameCharacter.inventory.weapons.alienWand.isAvailableOnEarth = true;
            gameCharacter.inventory.weapons.alienWand.isAvailable = true;
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.inventory.weapons.alienWand.Improve();
            gameCharacter.Hit(gameCharacter.inventory.weapons.alienWand);
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.UseMedicine();
            Console.WriteLine(gameCharacter.lifePoint);
            gameCharacter.inventory.bags.chainmail.AddChinmail();
            gameCharacter.inventory.weapons.elvenWand.Improve();
        }
    }
}
