﻿using System;
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
using System.Windows.Shapes;

namespace Morabaraba_2.Views
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            var Game = new PlayerColorSelector();
            this.Hide();
            Game.Show();
        }

        private void CloseGame(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
