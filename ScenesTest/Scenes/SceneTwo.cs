using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public partial class SceneTwo
    {
        public SceneTwo(MainWindow mainWindow, Grid scenePanel) : base(mainWindow, scenePanel)
        {
            this.BtnSceneTwo.Click += this.SwitchSceneToSceneOne;
        }

        private void SwitchSceneToSceneOne(object sender, RoutedEventArgs e)
        {   
            var sceneOne = new SceneOne(this.MainWindow, 
                new Grid() { Width = 500, Height = 200 });

            this.MainWindow.Dispatcher.Invoke(() => MainWindow.SetScene(sceneOne));
        }
    }
}
