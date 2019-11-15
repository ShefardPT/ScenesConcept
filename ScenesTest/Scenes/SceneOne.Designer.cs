using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScenesTest.Scenes
{
    partial class SceneOne :  Scene
    {
        public Grid ScenePanel;
        public Button BtnSceneOne;
        public GridSplitter SplitterSceneOne;
        public TextBlock TextBlockBtnSceneOne;

        public override void Initialize()
        {
            ScenePanel = new Grid(){Background = new SolidColorBrush(Colors.Aquamarine)};

            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ScenePanel.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            TextBlockBtnSceneOne = new TextBlock(){Text = "Switch to the scene 2." , TextWrapping = TextWrapping.Wrap};

            BtnSceneOne = new Button()
            {
                Content = TextBlockBtnSceneOne,
                Width = 80,
                Height = 80,
                Margin = new Thickness(10)
            };

            SplitterSceneOne = new GridSplitter()
            {
                Width = 5,
                Background = new SolidColorBrush(Colors.Black)
            };

            this.ScenePanel.Children.Add(BtnSceneOne);
            this.ScenePanel.Children.Add(SplitterSceneOne);

            Grid.SetColumn(BtnSceneOne, 0);
            Grid.SetColumn(SplitterSceneOne, 1);

            this.Children.Add(ScenePanel);
        }

    }
}
