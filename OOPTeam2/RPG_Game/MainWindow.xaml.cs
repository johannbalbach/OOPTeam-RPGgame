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

using Color = SFML.Graphics.Color;

namespace OOPTeam2
{

    public partial class MainWindow : System.Windows.Window
    {
        private static RenderWindow renderWindow;
        private static DispatcherTimer timer;
        private static Drawer drawer;
        private static Map map;
        private static InputDispatcher inputDispatcher;
        Clock cl;
        Thread gameThread;
        public MainWindow()
        {
            InitializeComponent();

            MainLogic mainLogic = new MainLogic();
            ///
            GameCharacterBuilder enemy = new GameCharacterBuilder();
            enemy.WithPosition(new Position(100, 100));
            enemy.WithName("player");
            enemy.WithAge(0);
            enemy.WithSkinId("HumanCharacter");
            enemy.WithIsEnemy(false);
            ///
            map = new Map(enemy.Build(), Race.HumanCharacter);
            drawer = new Drawer(map);
            inputDispatcher = new InputDispatcher(map.player);

            CreateRenderWindow();

            TimeSpan refreshRate = new TimeSpan(0, 0, 0, 0, 16);
            timer = new DispatcherTimer { Interval = refreshRate };
            timer.Tick += new EventHandler(Timer_Tick);
            cl = new Clock();
            timer.Start();

            //CompositionTarget.Rendering += Loop;

            //gameThread = new Thread(Loop);
            //gameThread.Start();
            
        }

        private void Loop()
        {
            //while (true)
            {
                renderWindow.DispatchEvents();
                renderWindow.Clear(SFML.Graphics.Color.Black);
                inputDispatcher.DispathcInput();
                map.Update();
                drawer.Draw();
                renderWindow.Display();
                Console.WriteLine(cl.ElapsedTime.AsMilliseconds());
                cl.Restart();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            renderWindow.DispatchEvents();
            renderWindow.Clear(SFML.Graphics.Color.Black);
            inputDispatcher.DispathcInput();
            map.Update();
            drawer.Draw();
            renderWindow.Display();

            CommandManager.InvalidateRequerySuggested();
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

        private void DrawSurface_SizeChanged(object sender, EventArgs e)
        {
            CreateRenderWindow();
        }

        private void RenderWindow_MouseButtonPressed(object sender, SFML.Window.MouseButtonEventArgs e)
        {

        }


    }
}
