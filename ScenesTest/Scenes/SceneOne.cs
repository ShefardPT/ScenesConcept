using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ScenesTest.Scenes
{
    public partial class SceneOne
    {
        public SceneOne(MainWindow mainWindow) : base(mainWindow)
        {
            this.BtnSceneOne.Click += this.SwitchSceneToSceneTwo;
        }

        private void SwitchSceneToSceneTwo(object sender, RoutedEventArgs e)
        {
            var sceneTwo = new SceneTwo(this._mainWindow) { Width = 200, Height = 500};

            this._mainWindow.Dispatcher.Invoke(() => _mainWindow.SetScene(sceneTwo));
        }
    }
}
