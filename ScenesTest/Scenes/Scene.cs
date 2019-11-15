using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public abstract class Scene : IScene
    { 
        protected MainWindow MainWindow;
        public Panel ScenePanel;

        public Scene(MainWindow mainWindow, Panel scenePanel)
        {
            MainWindow = mainWindow;
            ScenePanel = scenePanel;
            this.Initialize();
        }

        public abstract void Initialize();
    }
}
