using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScenesTest.Scenes
{
    partial class SceneTwo: Scene
    {
        public Grid ScenePanel;
        public Button BtnSceneTwo;
        public GridSplitter SplitterSceneTwo;
        public TextBlock TextBlockBtnSceneTwo;

        public override void Initialize()
        {
            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            TextBlockBtnSceneTwo = new TextBlock() { Text = "Switch to the scene 2.", TextWrapping = TextWrapping.Wrap };

            BtnSceneTwo = new Button()
            {
                Content = TextBlockBtnSceneTwo,
                Width = 80,
                Height = 80,
                Margin = new Thickness(10)
            };

            SplitterSceneTwo = new GridSplitter()
            {
                Width = 5,
                Background = new SolidColorBrush(Colors.Black)
            };

            this.ScenePanel.Children.Add(BtnSceneTwo);
            this.ScenePanel.Children.Add(SplitterSceneTwo);

            Grid.SetColumn(BtnSceneTwo, 2);
            Grid.SetColumn(SplitterSceneTwo, 1);
        }

    }
}
