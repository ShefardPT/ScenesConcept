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
        }
    }
}
