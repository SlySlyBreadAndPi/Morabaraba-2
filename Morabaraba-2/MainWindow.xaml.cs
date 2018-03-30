using Morabaraba_2.Helpers;
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
        SelectedColor Color;
        bool RemovingCow = false;//used for detecting if the player is currently removing a cow or not
        public MainWindow(SelectedColor color)
        {
            InitializeComponent();
            Color = color;
            CurrentSession = new Morabaraba(color);
            CurrentSession.Init(PiecesParent);
            currentTurn = WhosTurn.Turn.Player1;//Always player 1s turn
        }
        /// <summary>
        /// Allows the Player to make a move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move(object sender, MouseButtonEventArgs e)
        {
            var test = PiecesParent.Children;
            EllipseNameToIndexConverter Converter = new EllipseNameToIndexConverter();
            EllipseColorChanger changer = new EllipseColorChanger();
            EllipseColorConverter converter = new EllipseColorConverter();
            TupleExtractor tupleExtractor;
            var ellipseClicked = (e.Source as Ellipse);
            if (!RemovingCow)
            {
                ValidPositionVerifier verify = new ValidPositionVerifier();
                bool valid = verify.Verify(PiecesParent, ellipseClicked, CurrentSession.GetPlayer(currentTurn));
                if (valid)
                {
                    var indexofCowOnBoard = Converter.ConvertNameToIndex(ellipseClicked.Name);
                    var unused = Color.PlayerOneColor == ColorType.Color.Dark ? ColorType.Color.Light : ColorType.Color.Dark;
                    var newTurn = CurrentSession.Play(new Cow { IndexonBoard = indexofCowOnBoard, CowType = currentTurn==WhosTurn.Turn.Player1?Color.PlayerOneColor:unused }, currentTurn);
                    changer.ChangeColor(ref ellipseClicked, currentTurn == WhosTurn.Turn.Player1 ?Color.PlayerOneColor : unused);
                    tupleExtractor = new TupleExtractor(newTurn);
                    var foundMill = tupleExtractor.GetMillFoundType3Tuple();
                    if (foundMill)
                    {
                        RemovingCow = true;
                        CowHighLighter highlightotherPlayersCow = new CowHighLighter(CurrentSession.GetBoard());
                        var currentPlayer = CurrentSession.GetPlayer(currentTurn);
                        var tempBoard = highlightotherPlayersCow.HighLightCows(currentPlayer, ref PiecesParent);
                        changer.ChangeColor(ref PiecesParent, tempBoard);
                    }
                    currentTurn = tupleExtractor.GetWhosTurnType3Tuple();
                }
                else
                {
                    //alert user about incorrect position being played
                }

            } else
            {
                CurrentSession.RemoveOpponentsPlacedCows(ellipseClicked, ref PiecesParent,CurrentSession.GetPlayer(currentTurn==WhosTurn.Turn.Player1?WhosTurn.Turn.Player2:WhosTurn.Turn.Player1));
                RemovingCow = false;


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
