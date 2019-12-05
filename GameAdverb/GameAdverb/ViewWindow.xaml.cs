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
        public ViewWindow(Game game)
        {
            InitializeComponent();
            page.Content = new MainPage(game);
        }

        private void PrevPage(object sender, RoutedEventArgs e)
        {

        }

        private void NextPage(object sender, RoutedEventArgs e)
        {

        }
    }
}
