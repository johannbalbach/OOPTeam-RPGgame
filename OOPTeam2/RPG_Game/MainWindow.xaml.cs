using OOPTeam2.RPG_Game;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Services;
using OOPTeam2.RPG_Game.View;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using OOPTeam2.RPG_Game.Services.Map;
using OOPTeam2.RPG_Game.Models.Swords;

namespace OOPTeam2
{

    public partial class MainWindow : System.Windows.Window
    {
        private static RenderWindow renderWindow;
        private static Drawer drawer;
        private static Map map;
        private static InputDispatcher inputDispatcher;
        private static Race race;

        GameCharacterBuilder player = new GameCharacterBuilder()
            .WithPosition(new Position(100, 0))
            .WithName("player")
            .WithAge(0)
            .WithSkinId("HumanCharacter")
            .WithIsEnemy(false)
            .WithInventory(new RPG_Game.Models.Inventory())
            .WithWeapon(new LevithanSword())
            .WithLifePoint(1000);

        public MainWindow()
        {
            InitializeComponent();

            MainLogic mainLogic = new MainLogic();
            map = new Map(player.Build(), Race.HumanCharacter);
            drawer = new Drawer(map);
            inputDispatcher = new InputDispatcher(map, drawer);

            CreateRenderWindow();
        }

        private void createMap()
        {
            map = new Map(player.Build(), race);
            drawer = new Drawer(map);
            inputDispatcher = new InputDispatcher(map, drawer);
            CreateRenderWindow();
            Task.Run(Loop);
        }

        private void Loop()
        {
            while (true)
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
            renderWindow.MouseButtonPressed += RenderWindow_MouseButtonPressed;
            renderWindow.SetActive(true);
            drawer.SetRenderWindow(renderWindow);
        }

        private void RenderWindow_MouseButtonPressed(object sender, SFML.Window.MouseButtonEventArgs e)
        {

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
                    race = Race.HumanCharacter;
                    player = player.WithSkinId("HumanCharacter");
                    break;
                case 1:
                    race = Race.AlienCharacter;
                    player = player.WithSkinId("AlienCharacter");
                    break;
                case 2:
                    race = Race.ElvesCharacter;
                    player = player.WithSkinId("ElfCharacter");
                    break;
                case 3:
                    race = Race.GnomeCharacter;
                    player = player.WithSkinId("GnomeCharacter");
                    break;
                case 4:
                    race = Race.OrksCharacter;
                    player = player.WithSkinId("OrkCharacter");
                    break;
                case 5:
                    race = Race.WandCharacter;
                    player = player.WithSkinId("WandCharacter");
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
    }
}
