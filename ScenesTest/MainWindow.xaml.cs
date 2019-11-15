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
        private Panel MainScene;
        //private Button BtnMainWindow;

        public MainWindow()
        {
            InitializeComponent();

            MainGrid.Margin = new Thickness(0);
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            MainGrid.RowDefinitions.Add(new RowDefinition());

            //BtnMainWindow = new Button() { Width = 100, Height = 100, Background = new SolidColorBrush(Colors.Black), Margin = new Thickness(10)};
            //Grid.SetColumn(BtnMainWindow, 0);
            //Grid.SetRow(BtnMainWindow, 0);
            //MainGrid.Children.Add(BtnMainWindow);

            MainScene = new SceneOne(this){Height = 300, Width = 600, Background = new SolidColorBrush(Colors.LightGray)};
            MainGrid.Children.Add(MainScene);
        }

        public void SetScene(Panel scene)
        {
            this.MainScene = scene;
            this.SizeToContent = SizeToContent.WidthAndHeight;
        }
    }
}
