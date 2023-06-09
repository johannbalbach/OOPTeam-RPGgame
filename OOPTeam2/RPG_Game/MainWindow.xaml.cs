﻿using OOPTeam2.RPG_Game;
using OOPTeam2.RPG_Game.Services;
using OOPTeam2.RPG_Game.View;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

using Color = SFML.Graphics.Color;

namespace OOPTeam2
{

    public partial class MainWindow : System.Windows.Window
    {
        static RenderWindow renderWindow;
        private readonly DispatcherTimer timer;
        private static Drawer drawer;
        private static Map map;
        Player player;
        GameCharacter playerGameCharacter;
        public MainWindow()
        {
            InitializeComponent();

            MainLogic mainLogic = new MainLogic();

            playerGameCharacter = new GameCharacter("Player", new Position(30, 0), 5, "male", "HumanCharacter", false, false);
            player = new Player(playerGameCharacter);
            map = new Map(playerGameCharacter);
            drawer = new Drawer(map);


            CreateRenderWindow();

            TimeSpan refreshRate = new TimeSpan(0, 0, 0, 0, 1000 / 60);
            timer = new DispatcherTimer { Interval = refreshRate };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            renderWindow.DispatchEvents();
            renderWindow.Clear(SFML.Graphics.Color.Black);

            if (SFML.Window.Keyboard.IsKeyPressed(SFML.Window.Keyboard.Key.D))
            {
                player.MoveRight();
            }

            map.Update(player);
            drawer.Draw();
            renderWindow.Display();
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
