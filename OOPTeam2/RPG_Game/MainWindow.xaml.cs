using OOPTeam2.RPG_Game;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.View;
using SFML.Graphics;
using SFML.Window;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Services.Map;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;
using OOPTeam2.RPG_Game.Models.Potions;

namespace OOPTeam2
{

    public partial class MainWindow : System.Windows.Window
    {
        private static RenderWindow renderWindow;
        private static Drawer drawer;
        private static Map map;
        private static InputDispatcher inputDispatcher;
        private static CharacterRace race;
        private static bool windowIsOpen = true;

        GameCharacterBuilder player = new GameCharacterBuilder()
            .WithPosition(new Position(100, 0))
            .WithName("player")
            .WithAge(0)
            .WithSkinId("HumanCharacter")
            .WithCharacterRace(CharacterRace.Human)
            .WithIsEnemy(false)
            .WithInventory(new RPG_Game.Models.Inventory())
            .WithWeapon(new LevithanSword())
            .WithLifePoint(1000);

        public MainWindow()
        {
            InitializeComponent();

            MainLogic mainLogic = new MainLogic();
            map = new Map(player.Build(), CharacterRace.Human);
            drawer = new Drawer(map);
            inputDispatcher = new InputDispatcher(map.player);

            CreateRenderWindow();
        }

        private void createMap()
        {
            map = new Map(player.Build(), race);
            drawer = new Drawer(map);
            inputDispatcher = new InputDispatcher(map.player);
            CreateRenderWindow();
            Task.Run(Loop);
        }

        private void Loop()
        {
            while (windowIsOpen)
            {
                Dispatcher.Invoke(() =>
                {
                    renderWindow.DispatchEvents();
                    renderWindow.Clear(SFML.Graphics.Color.Black);
                    inputDispatcher.DispathcInput();
                    map.Update();
                    drawer.Draw();
                    renderWindow.Display();
                });

                Thread.Sleep(16);
            }
        }

        private void CreateRenderWindow()
        {
            if (renderWindow != null)
            {
                renderWindow.SetActive(false);
                renderWindow.Dispose();
            }

            ContextSettings context = new ContextSettings { DepthBits = 24 };
            renderWindow = new RenderWindow(DrawSurface.Handle, context);
            renderWindow.SetActive(true);
            drawer.SetRenderWindow(renderWindow);
        }

        private void DrawSurface_SizeChanged(object sender, EventArgs e)
        {
            CreateRenderWindow();
        }

        private void chooseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (chooseComboBox.SelectedIndex)
            {
                case 0:
                    race = CharacterRace.Human;
                    player = player.WithSkinId("HumanCharacter")
                                   .WithCharacterRace(CharacterRace.Human)
                                   .WithWeapon(new LevithanSword());
                    break;
                case 1:
                    race = CharacterRace.Alien;
                    player = player.WithSkinId("AlienCharacter")
                                   .WithCharacterRace(CharacterRace.Alien)
                                   .WithWeapon(new AlienWand());
                    break;
                case 2:
                    race = CharacterRace.Elf;
                    player = player.WithSkinId("ElfCharacter")
                                   .WithCharacterRace(CharacterRace.Elf)
                                   .WithWeapon(new HealingPotion());
                    break;
                case 3:
                    race = CharacterRace.Gnome;
                    player = player.WithSkinId("GnomeCharacter")
                                   .WithCharacterRace(CharacterRace.Gnome)
                                   .WithWeapon(new EpicPotion());
                    break;
                case 4:
                    race = CharacterRace.Ork;
                    player = player.WithSkinId("OrkCharacter")
                                   .WithCharacterRace(CharacterRace.Ork)
                                   .WithWeapon(new MaceSword());
                    break;
                case 5:
                    race = CharacterRace.Wizard;
                    player = player.WithSkinId("WandCharacter")
                                   .WithCharacterRace(CharacterRace.Wizard)
                                   .WithWeapon(new WizardWand());
                    break;
                default:
                    break;
            }
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            createMap();
            createButton.IsEnabled = false;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            windowIsOpen = false;
        }
    }
}
