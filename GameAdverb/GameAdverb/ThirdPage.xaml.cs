﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameAdverb
{
    /// <summary>
    /// Interaction logic for ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        public ThirdPage(Game game)
        {
            InitializeComponent();
            genre.Text = game.Genre;
            creator.Text = game.Creator;
            modeGame.Text = game.ModeGame;
            lastVersion.Text = game.LastVersion;
        }
    }
}
