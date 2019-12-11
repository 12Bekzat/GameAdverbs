using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameAdverb
{
    /// <summary>
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        private int pageNum = 0;
        private Game Game;
        public ViewWindow(Game game)
        {
            InitializeComponent();
            gridBackGround.ImageSource = new BitmapImage(new Uri(game.Image));
            Game = game;
            page.Content = new MainPage(game);
        }

        private void PrevPage(object sender, RoutedEventArgs e)
        {
            if (pageNum > 0)
                pageNum--;
            switch (pageNum)
            {
                case 0:
                    page.Content = new MainPage(Game);
                    break;
                case 1:
                    page.Content = new SecondPage(Game);
                    break;
                case 2:
                    page.Content = new ThirdPage(Game); 
                    break;
            }
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            if (pageNum < 2)
                pageNum++;
            switch (pageNum)
            {
                case 0:
                    page.Content = new MainPage(Game);
                    break;
                case 1:
                    page.Content = new SecondPage(Game);
                    break;
                case 2:
                    page.Content = new ThirdPage(Game);
                    break;
            }
        }
    }
}
