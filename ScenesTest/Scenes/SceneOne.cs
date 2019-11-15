using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public partial class SceneOne
    {
        public SceneOne(MainWindow mainWindow, Grid scenePanel) : base(mainWindow, scenePanel)
        {
            this.BtnSceneOne.Click += this.SwitchSceneToSceneTwo;
        }

        private void SwitchSceneToSceneTwo(object sender, RoutedEventArgs e)
        {
            var sceneTwo = new SceneTwo(this.MainWindow,
                new Grid() { Width = 200, Height = 500 }) ;

            this.MainWindow.Dispatcher.Invoke(() => MainWindow.SetScene(sceneTwo));
        }
    }
}
