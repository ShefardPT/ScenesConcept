using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ScenesTest.Scenes
{
    public partial class SceneTwo
    {
        public SceneTwo(MainWindow mainWindow): base(mainWindow)
        {
            this.BtnSceneTwo.Click += this.SwitchSceneToSceneOne;
        }

        private void SwitchSceneToSceneOne(object sender, RoutedEventArgs e)
        {

        }
    }
}
