using System;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using OOPTeam2.RPG_Game.Models;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;
using OOPTeam2.RPG_Game.Models.Potions;

namespace OOPTeam2.RPG_Game.Services
{
    public class Generator
    {
        public GameCharacter nonSpawnCharacter;//??
        public Generator() { }//?? nonSpawn

        private const int enemySpawnChance = 1;
        private const int npcSpawnChance = 1;
        private const int randomMax = 100;

        public GameCharacter SpawnEnemyExcept(Position position, Race race)
        {
            SingletonRand rnd = SingletonRand.GetInstance();
            if (rnd.Next(randomMax) <= enemySpawnChance)
            {
                int age = rnd.Next(0, 100);
                string name ="", skinIndex = "";
                Position spawnPosition = SpawnPlace(position);
                CharacterRace characterRace = CharacterRace.Unknown;
                TextEnum characterReply = TextEnum.UnknownText;
                Weapon currentWeapon =  new KatanaSword();

                int enemyType = rnd.Next(0, 5);
                while (enemyType == (int)race)
                {
                    enemyType = rnd.Next(0, 5);
                }
                switch (enemyType)
                {
                    case 0:
                        name = "WandEnemy";
                        skinIndex = "WandCharacter";
                        characterRace = CharacterRace.Wizard;
                        characterReply = TextEnum.WizardsText;
                        currentWeapon = new WizardWand();
                        break;
                    case 1:
                        name = "AlienEnemy";
                        skinIndex = "AlienCharacter";
                        characterRace = CharacterRace.Alien;
                        characterReply = TextEnum.AliensText;
                        currentWeapon = new AlienWand();
                        break;
                    case 2:
                        name = "HumanEnemy";
                        skinIndex = "HumanCharacter";
                        characterRace = CharacterRace.Human;
                        characterReply = TextEnum.HumansText;
                        currentWeapon = new LevithanSword();
                        break;
                    case 3:
                        name = "OrkEnemy";
                        skinIndex = "OrkCharacter";
                        characterRace = CharacterRace.Ork;
                        characterReply = TextEnum.OrksText;
                        currentWeapon = new MaceSword();
                        break;
                    case 4:
                        name = "ElvEnemy";
                        skinIndex = "ElfCharacter";
                        characterRace = CharacterRace.Elf;
                        characterReply = TextEnum.ElvesText;
                        currentWeapon = new HealingPotion();
                        break;
                    case 5:
                        name = "GnomeEnemy";
                        skinIndex = "GnomeCharacter";
                        characterRace = CharacterRace.Gnome;
                        characterReply = TextEnum.GnomesText;
                        currentWeapon = new EpicPotion();
                        break;
                }
                GameCharacter enemy = new GameCharacter(CreateEnemy(name, spawnPosition, age, skinIndex, characterRace, characterReply, currentWeapon));
                
                return enemy;
            }
            else
                return null;
        }
        private Position SpawnPlace(Position exception)
        {
            int x, y;
            y = exception.Y;
            SingletonRand rnd = SingletonRand.GetInstance();

            x = rnd.Next(1, 2000);//границы поля
            while (config.InDistance(exception, x))
            {
                x = rnd.Next(1, 2000);//границы поля
            }
            Position position = new Position(x, y);

            return position;
        }
        private GameCharacter CreateEnemy(string name, Position spawnPosition, int age, string skinIndex, CharacterRace race, TextEnum raceReply, Weapon currentWeapon)
        {
            GameCharacterBuilder enemy = new GameCharacterBuilder();
            enemy.WithPosition(spawnPosition)
                .WithName(name)
                .WithAge(age)
                .WithSkinId(skinIndex)
                .WithText(new CharacterReply(raceReply))
                .WithCharacterRace(race)
                .WithInventory(new Inventory())
                .WithWeapon(currentWeapon)
                .WithLifePoint(10);

            return enemy.Build();
        }
    }
}
