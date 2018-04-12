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



        public MainWindow()
        {
            InitializeComponent();
            CurrentSession = new Morabaraba();
            SetInformation(CurrentSession.InfoToString());


        }
        /// <summary>
        /// Allows the Player to make a move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move(object sender, MouseButtonEventArgs e)
        {
            var test = PiecesParent.Children;
            EllipseColorChanger changer = new EllipseColorChanger();
            EllipseConverter Converter = new EllipseConverter();
            int index;


            

                var ellipseClicked = (e.Source as Ellipse);
                index = Converter.ConvertNameToIndex(ellipseClicked.Name);
                changer.ChangeColor(ref PiecesParent, CurrentSession.Move(index));
                SetInformation(CurrentSession.InfoToString());

            if (CurrentSession.GetPlayerLostOrNot())
            {
                MessageBox.Show(Turn.Text + "Has Won the match");
                BackToMainMenu();
            }




        }

        public void SetInformation(List<string> information)
        {
            Turn.Text = information.ElementAt(0);
            Phase.Text = information.ElementAt(1);
            Action.Text = information.ElementAt(2);
        }

        /// <summary>
        /// Used for returning to the main menu incase a player gets bored
        /// or something like that 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMainMenu(object sender, MouseButtonEventArgs e)
        {
            

        }
        private void BackToMainMenu()
        {
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Show();

        }

        private void GoToMainMenu_MouseDown(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Show();
        }
    }
}
