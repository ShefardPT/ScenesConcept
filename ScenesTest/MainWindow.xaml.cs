using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScenesTest.Scenes;

namespace ScenesTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Panel MainScenePanel;

        public MainWindow()
        {
            InitializeComponent();

            var firstScene = new SceneOne(this,
                new Grid()
                {
                    Height = 300,
                    Width = 600,
                    Background = new SolidColorBrush(Colors.LightGray)
                });

            SetScene(firstScene);
        }

        public void SetScene(Scene scene)
        {
            this.MainGrid.Children.Clear();
            this.MainScenePanel = scene.ScenePanel;
            MainGrid.Children.Add(MainScenePanel);
        }
    }
}
