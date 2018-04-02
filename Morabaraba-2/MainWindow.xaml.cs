using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using Morabaraba_2.Classes;
using static Morabaraba_2.Models.ColorType;
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
using Morabaraba_2.Views;
namespace Morabaraba_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Morabaraba CurrentSession;

        bool RemovingCow = false;//used for detecting if the player is currently removing a cow or not
        public MainWindow(Colour color)
        {
            InitializeComponent();
            CurrentSession = new Morabaraba(PiecesParent,color);

        }
        /// <summary>
        /// Allows the Player to make a move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move(object sender, MouseButtonEventArgs e)
        {
            var test = PiecesParent.Children;
            EllipseConverter Converter = new EllipseConverter();
            int index;
    
           
            bool tried = false;
            while (tried == false)
            {
                try {
                    var ellipseClicked = (e.Source as Ellipse);
                    index = Converter.ConvertNameToIndex(ellipseClicked.Name);
                    
                }
                catch { }
            }
                
            
            
        }
        /// <summary>
        /// Used for returning to the main menu incase a player gets bored
        /// or something like that 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMainMenu(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Show();

        }
    }
}
