using Morabaraba_2.Classes;
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
        WhosTurn.Turn currentTurn;
        public MainWindow()
        {
            InitializeComponent();
            CurrentSession = new Morabaraba();
            currentTurn = WhosTurn.Turn.Player1;//Always player 1s turn
        }
        /// <summary>
        /// Allows the Player to make a move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move(object sender, MouseButtonEventArgs e)
        {
            EllipseNameToIndexConverter Converter = new EllipseNameToIndexConverter();
            var ellipseClicked = (e.Source as Ellipse);
            var indexofCowOnBoard =Converter.ConvertNameToIndex(ellipseClicked.Name);
            var CowColor = ellipseClicked.Fill;
            var converter = new EllipseColorConverter();
            EllipseColorChanger changer = new EllipseColorChanger();
            var newTurn = CurrentSession.Play(new Cow { IndexonBoard = indexofCowOnBoard, CowType = converter.GetGameColor(CowColor) },currentTurn);
            changer.ChangeColor(ref ellipseClicked, currentTurn == WhosTurn.Turn.Player1 ? ColorType.Color.Light : ColorType.Color.Dark);
            currentTurn = newTurn;
        }

        private void ToMainMenu(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var MainMenu = new MainMenu();
            MainMenu.Show();

        }
    }
}
