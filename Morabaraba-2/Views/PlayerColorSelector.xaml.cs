using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
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
using System.Windows.Shapes;

namespace Morabaraba_2.Views
{
    /// <summary>
    /// Interaction logic for PlayerColorSelector.xaml
    /// </summary>
    public partial class PlayerColorSelector : Window
    {
        public PlayerColorSelector()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainMenu = new MainMenu();
            this.Hide();
            MainMenu.Show();
        }

        private void SelectedColor(object sender, RoutedEventArgs e)
        {
            var button = e.Source as Button;
            EllipseColorConverter converter = new EllipseColorConverter();
            SelectedColor color = new SelectedColor { PlayerOneColor = converter.GetColor(button.Background) };
            this.Hide();
            MainWindow morabaraba = new MainWindow(color);
            morabaraba.Show();
        }
    }
}
