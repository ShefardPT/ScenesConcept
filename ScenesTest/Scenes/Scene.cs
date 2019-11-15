using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public abstract class Scene : Grid, IScene
    {
        protected MainWindow _mainWindow;

        public Scene(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            this.Initialize();
        }

        public abstract void Initialize();
    }
}
