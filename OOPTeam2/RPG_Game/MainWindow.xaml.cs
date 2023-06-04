﻿using OOPTeam2.RPG_Game;
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
        static PictureProvider pictureProvider = new PictureProvider();

        public MainWindow()
        {
            InitializeComponent();

            MainLogic mainLogic = new MainLogic();


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
            renderWindow.Draw(pictureProvider.humanSprite);
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
