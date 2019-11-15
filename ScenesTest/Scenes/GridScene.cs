using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public class GridScene : Scene
    {
        public Grid GridScenePanel
        {
            get => (Grid)ScenePanel;
            set => ScenePanel = value;
        }

        public GridScene(MainWindow mainWindow, Grid scenePanel) : base(mainWindow, scenePanel)
        {
        }

        public override void Initialize()
        {
        }
    }
}
