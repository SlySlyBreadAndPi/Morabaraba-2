using MorabarabaNS.Models;
using static MorabarabaNS.Models.Phases;
using MorabarabaNS.Helpers;
using System.Collections.Generic;
using MorabarabaNS.Interfaces;

namespace MorabarabaNS.Classes
{
    /// <summary>
    /// This class holds the current game session between two players
    /// </summary>

    public class Morabaraba: IMorabaraba
    {
        public IBoard CurrentBoard;
        private IPlayer p1;
        private IPlayer p2;
        private bool turn;
        private bool removing;
        PlayerCreator creator;
        GameBoardInitialisor init;
        ValidPositionVerifier verifier;
        private ICommand command;

        /// <summary>
        /// Constructor
        /// </summary>
        /// 
        public Morabaraba()
        {
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;
            
        }
        public Morabaraba(int unplaced)
        {
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark, unplaced);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;
        }
        public Morabaraba(int unplaced,int unplaced2)
        {
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark, unplaced,unplaced2);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;
        }

        public bool isKilling()
        {
            return removing;
        }

        public Morabaraba(ICommand command)
        {
            this.command = command;
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;

        }

        /// <summary>
        /// Sets a node at a given index to a Cow and then checks for a valid mill
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        
        /// <summary>
        /// Move takes in a index of an ellipse and then uses the game state variables it has within it to call various methods to facilitate appropriate actions.
        /// </summary>
        /// <param name="index"></param>
        public IBoard Move (int index)
        {
            verifier = new ValidPositionVerifier(CurrentBoard);
            if(command!=null)
            {
                command.Execute();
            }  
            if(removing)
            {
               
                if (verifier.VerifyCanShoot(index, Turn(!turn)))
                {
                    CurrentBoard.SetEmpty(index);
                    CowKilled();
                    removing = false;
                    NextTurn();
                    
                }

                
            }
            else
            {
                switch (Turn(turn).GetPhase())
                {
                    case (Phase.Moving):
                        if (CheckIfNoAvaliableMoves(verifier))
                        {
                            PlayerLost();
                        }
                        else if(verifier.VerifyMoving(index, Turn(turn)))
                        {
                            CurrentBoard.Moving(index);
                            SetTurnPhase(Phase.Moving2);                            
                        }
                        break;
                    case (Phase.Moving2):
                        if (verifier.VerifyMoving2(index))
                        {
                            removing=CurrentBoard.PlaceCow(index,Turn(turn));
                            SetTurnPhase(Phase.Moving);
                            if (!removing) NextTurn();
                        }
                        break;
                    case (Phase.Placing):
                        if (verifier.VerifyPlacing(index))
                        {
                            CowPlaced();
                            removing = CurrentBoard.PlaceCow(index, Turn(turn));
                            if (!removing) NextTurn();
                        }
                        break;
                    case (Phase.Flying):
                        if (verifier.VerifyFlying(index, Turn(turn)))
                        {
                            CurrentBoard.SetEmpty(index);
                            SetTurnPhase(Phase.Flying2);
                        }
                        break;
                    case (Phase.Flying2):
                        if (verifier.VerifyFlying2(index))
                        {
                            removing = CurrentBoard.PlaceCow(index, Turn(turn));
                            SetTurnPhase(Phase.Flying);
                            if (!removing) NextTurn();
                        }
                        break;
                }
            }

            return CurrentBoard;

        }
        public bool CheckIfNoAvaliableMoves(ValidPositionVerifier ver)
        {
            var cows = GetBoard();
            var cw = Turn(turn).GetCow().Get();
            int i = 0;
            foreach(Cow x in cows)
            {
                if (x.Get() == cw && ver.VerifyAdjacent(CurrentBoard.GetAdjacent(i))) return false;
                i++;
            }
            return true;
        }

        public IPlayer Turn(bool turn)
        {
            return turn? p1 : p2;
        }
        public void PlayerLost()
        {
            if (turn)
            {
                p1.SetHasLost();
            }
            else
            {
                p2.SetHasLost();
            }
        }
        public void CowPlaced()
        {
            if (turn) p1.PiecePlaced();
            else p2.PiecePlaced();
        }
        public void CowKilled()
        {
            if (!turn) p1.PieceKilled();
            else p2.PieceKilled();
        }
        public void NextTurn()
        {
            turn = !turn;
        }
        public void SetTurnPhase(Phase phase)
        {
            if (turn) p1.SetPhase(phase);
            else p2.SetPhase(phase);
        }
        public ICow TurnCow()
        {
            return turn ? p1.GetCow() : p2.GetCow();
        }
        public List<string> InfoToString()
        {
            List<string> info = new List<string>();
            info.Add(turn ? "Player One" : "Player Two");
            info.Add(Turn(turn).GetPhase().ToString());
            info.Add(instructions());


            return info;
        }
        public string instructions()
        {
            string inst="";
            if (removing) inst= "Choose A valid Position Containing one of your opponents cows to kill";
            else
            {
                switch(Turn(turn).GetPhase())
                {
                    case (Phase.Moving):
                        inst = "Choose a valid cow to move";
                        break;
                    case (Phase.Moving2):
                        inst = "Choose where to move your cow";
                        break;
                    case (Phase.Placing):
                        inst = "Choose one of your " + Turn(turn).GetUnplaced() + " remaining pieces to place";
                        break;
                    case (Phase.Flying):
                        inst = "Choose a valid cow to fly to a new position";
                        break;
                    case (Phase.Flying2):
                        inst = "Choose where to Fly your chosen cow";
                        break;

                }

            }


            return inst;
        }
        /// <summary>
        /// Returns true if one of the players has met the losing condition
        /// </summary>
        /// <returns>boolean</returns>
      public bool GetPlayerLostOrNot()
      {
            return p1.GetHasLost()||p2.GetHasLost();
      }
        /// <summary>
        /// returns the cow list that makes up board
        /// </summary>
        /// <returns>List<Cow></returns>
      public List<ICow> GetBoard()
        {
            return CurrentBoard.GetNodes();
        }
      public bool getTurn()
        {
            return turn;
        }

        
    }
}
