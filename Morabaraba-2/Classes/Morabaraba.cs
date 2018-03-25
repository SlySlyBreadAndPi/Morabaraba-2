using Morabaraba_2.Classes;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Morabaraba_2.Classes
{

    public class Morabaraba
    {
        Game currentGameState;
        MakeMove movemaker;
        public Morabaraba()
        {
            movemaker = new MakeMove();
            PlayerCreator creator = new PlayerCreator();
            GameBoardInitialisor init = new GameBoardInitialisor();
            currentGameState = new Game { p1 = creator.CreatePlayerOne(), p2 = creator.CreatePlayerTwo(), CurrentBoard = init.InitializeBoard() };
        }
        public WhosTurn.Turn  Play(Cow pos,WhosTurn.Turn turn)
        {
            if(turn == WhosTurn.Turn.Player1)
            {
               var updatedPlayerBoard= movemaker.Move(currentGameState.p1, currentGameState.CurrentBoard, pos);
               var newPlayer = updatedPlayerBoard.Item1;//get the updatedPlayer from the tuple
               var newBoard = updatedPlayerBoard.Item2;//Get the board from the tupple
               currentGameState.CurrentBoard = newBoard;
               currentGameState.p1 = newPlayer;
                turn = WhosTurn.Turn.Player2;
            }
            else
            {
                var updatedPlayerBoard = movemaker.Move(currentGameState.p2, currentGameState.CurrentBoard, pos);
                var newPlayer = updatedPlayerBoard.Item1;//get the updatedPlayer from the tuple
                var newBoard = updatedPlayerBoard.Item2;//Get the board from the tupple
                currentGameState.CurrentBoard = newBoard;
                currentGameState.p2 = newPlayer;
                turn = WhosTurn.Turn.Player1;
            }
            return turn;
        }

    }
}
