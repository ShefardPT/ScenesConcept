using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScenesTest.Scenes
{
    partial class SceneTwo: GridScene
    {
        public Button BtnSceneTwo;
        public GridSplitter SplitterSceneTwo;
        public TextBlock TextBlockBtnSceneTwo;

        public override void Initialize()
        {
            this.GridScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.GridScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.GridScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            TextBlockBtnSceneTwo = new TextBlock() { Text = "Switch to the scene 1.", TextWrapping = TextWrapping.Wrap };

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

            this.GridScenePanel.Children.Add(BtnSceneTwo);
            this.GridScenePanel.Children.Add(SplitterSceneTwo);

            Grid.SetColumn(BtnSceneTwo, 2);
            Grid.SetColumn(SplitterSceneTwo, 1);
        }

    }
}
