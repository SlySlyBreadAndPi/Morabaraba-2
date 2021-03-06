using NUnit.Framework;
using System;
using MorabarabaNS;
using MorabarabaNS.Classes;
using MorabarabaNS.Interfaces;
using NSubstitute;

namespace MorabarabaNS.Test
{
    public class Class1
    {


        [Test]
        public static void BoardEmpty()
        {
            Morabaraba currentGameSession = new Morabaraba();
            bool check = currentGameSession.GetBoard().Contains(new Cow(MorabarabaNS.Models.ColorType.Colour.Dark)) || currentGameSession.GetBoard().Contains(new Cow(MorabarabaNS.Models.ColorType.Colour.Light));
            Assert.That(!check);
        }
        [Test]
        public static void P1Dark()
        {
            Morabaraba currentGameSession = new Morabaraba();
            bool check = currentGameSession.Turn(true).GetCow().Get() == MorabarabaNS.Models.ColorType.Colour.Dark;
            Assert.That(check);
        }

        [Test]

        public static void FailOnOwnPlace()
        {
            Morabaraba tester = new Morabaraba();
            tester.Move(0);
            tester.Move(1);
            bool turn = tester.getTurn();
            tester.Move(0);
            Assert.That(turn == tester.getTurn());
        }
        [Test]
        public static void FailOnOpponentPlace()
        {
            Morabaraba tester = new Morabaraba();
            tester.Move(0);
            tester.Move(1);
            bool turn = tester.getTurn();
            tester.Move(1);
            Assert.That(turn == tester.getTurn());
        }
        [Test]
        public static void PassOnEmptyPlace()
        {
            Morabaraba tester = new Morabaraba();
            tester.Move(0);
            tester.Move(1);
            bool turn = tester.getTurn();
            tester.Move(2);
            Assert.That(turn != tester.getTurn());
        }
        [Test]
        public static void MaxofTwelveCows()
        {
            Morabaraba tester = new Morabaraba();
            for (int i = 0; i < 24; i++)
            {
                tester.Move(i);
            }
            var p1 = tester.Turn(true);
            var p2 = tester.Turn(false);
            Assert.That(p1.GetUnplaced() == 0 && p2.GetUnplaced() == 0);
        }
        [Test]
        public static void NoMoveOnPlace()
        {

            var command = Substitute.For<ICommand>();
            Morabaraba tester = new Morabaraba(command);
            var repeater = tester.Move(1);
            command.Received(1).Execute();
        }
        [Test]
        public static void MoveIncreasedDecreasedCowsOnBoard()
        {
            Morabaraba morabaraba = new Morabaraba(5);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            morabaraba.Move(0);
            morabaraba.Move(1);
            Assert.That(morabaraba.CurrentBoard.CowsOnBoard() == 1);

        }


        [Test]
        public static void OnlyShootOnce()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(23);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.Move(23);
            Assert.That(!morabaraba.isKilling());
        }
        [Test]
        public static void CantshootOwn()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(23);
            morabaraba.NextTurn();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.Move(23);
            Assert.That(morabaraba.isKilling());
        }
        [Test]
        public static void CantshootEmpty()
        {
            Morabaraba morabaraba = new Morabaraba();

            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.Move(23);
            Assert.That(morabaraba.isKilling());
        }
        [Test]
        public static void ShotCowRemoved()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(23);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.Move(23);
            Assert.That(morabaraba.GetBoard()[23].Get() == MorabarabaNS.Models.ColorType.Colour.Empty);
        }
        
        [TestCase(1, 2, 0)]
        [TestCase(3, 6, 0)]
        [TestCase(9, 21, 0)]
        [TestCase(0, 2, 1)]
        [TestCase(4, 7, 1)]
        [TestCase(1, 0, 2)]
        [TestCase(5, 8, 2)]
        [TestCase(14, 23, 2)]
        [TestCase(0, 6, 3)]
        [TestCase(4, 5, 3)]
        [TestCase(1, 7, 4)]
        [TestCase(3, 5, 4)]
        [TestCase(2, 8, 5)]
        [TestCase(4, 3, 5)]
        [TestCase(13, 20, 5)]
        [TestCase(7, 8, 6)]
        [TestCase(3, 0, 6)]
        [TestCase(11, 15, 6)]
        [TestCase(6, 8, 7)]
        [TestCase(4, 1, 7)]
        [TestCase(12, 17, 8)]
        [TestCase(5, 2, 8)]
        [TestCase(6, 7, 8)]
        [TestCase(10, 11, 9)]
        [TestCase(0, 21, 9)]
        [TestCase(11, 9, 10)]
        [TestCase(3, 18, 10)]
        [TestCase(9, 10, 11)]
        [TestCase(6, 15, 11)]
        [TestCase(8, 17, 12)]
        [TestCase(13, 14, 12)]
        [TestCase(12, 14, 13)]
        [TestCase(5, 20, 13)]
        [TestCase(12, 13, 14)]
        [TestCase(2, 23, 14)]
        [TestCase(17, 16, 15)]
        [TestCase(11, 6, 15)]
        [TestCase(18, 21, 15)]
        [TestCase(15, 17, 16)]
        [TestCase(19, 22, 16)]
        [TestCase(15, 16, 17)]
        [TestCase(12, 8, 17)]
        [TestCase(20, 23, 17)]
        [TestCase(19, 20, 18)]
        [TestCase(3, 10, 18)]
        [TestCase(15, 21, 18)]
        [TestCase(16, 22, 19)]
        [TestCase(20, 18, 19)]
        [TestCase(19, 18, 20)]
        [TestCase(23, 17, 20)]
        [TestCase(13, 5, 20)]
        [TestCase(22, 23, 21)]
        [TestCase(9, 0, 21)]
        [TestCase(18, 10, 3)]
        [TestCase(18, 15, 21)]
        [TestCase(21, 23, 22)]
        [TestCase(19, 16, 22)]
        [TestCase(21, 22, 23)]
        [TestCase(20, 17, 23)]
        [TestCase(14, 2, 23)]
        public static void CheckMillSameColour(int val1, int val2, int val3) //testing for every case
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);
            morabaraba.NextTurn();
            morabaraba.Move(val2);
            morabaraba.NextTurn();
            morabaraba.Move(val3);
            morabaraba.NextTurn();
            Assert.That(morabaraba.isKilling());
        }
        [TestCase(1, 2, 0)]
        [TestCase(3, 6, 0)]
        [TestCase(9, 21, 0)]
        [TestCase(0, 2, 1)]
        [TestCase(4, 7, 1)]
        [TestCase(1, 0, 2)]
        [TestCase(5, 8, 2)]
        [TestCase(14, 23, 2)]
        [TestCase(0, 6, 3)]
        [TestCase(4, 5, 3)]
        [TestCase(1, 7, 4)]
        [TestCase(3, 5, 4)]
        [TestCase(2, 8, 5)]
        [TestCase(4, 3, 5)]
        [TestCase(13, 20, 5)]
        [TestCase(7, 8, 6)]
        [TestCase(3, 0, 6)]
        [TestCase(11, 15, 6)]
        [TestCase(6, 8, 7)]
        [TestCase(4, 1, 7)]
        [TestCase(12, 17, 8)]
        [TestCase(5, 2, 8)]
        [TestCase(6, 7, 8)]
        [TestCase(10, 11, 9)]
        [TestCase(0, 21, 9)]
        [TestCase(11, 9, 10)]
        [TestCase(3, 18, 10)]
        [TestCase(9, 10, 11)]
        [TestCase(6, 15, 11)]
        [TestCase(8, 17, 12)]
        [TestCase(13, 14, 12)]
        [TestCase(12, 14, 13)]
        [TestCase(5, 20, 13)]
        [TestCase(12, 13, 14)]
        [TestCase(2, 23, 14)]
        [TestCase(17, 16, 15)]
        [TestCase(11, 6, 15)]
        [TestCase(18, 21, 15)]
        [TestCase(15, 17, 16)]
        [TestCase(19, 22, 16)]
        [TestCase(15, 16, 17)]
        [TestCase(12, 8, 17)]
        [TestCase(20, 23, 17)]
        [TestCase(19, 20, 18)]
        [TestCase(3, 10, 18)]
        [TestCase(15, 21, 18)]
        [TestCase(16, 22, 19)]
        [TestCase(20, 18, 19)]
        [TestCase(19, 18, 20)]
        [TestCase(23, 17, 20)]
        [TestCase(13, 5, 20)]
        [TestCase(22, 23, 21)]
        [TestCase(9, 0, 21)]
        [TestCase(18, 10, 3)]
        [TestCase(18, 15, 21)]
        [TestCase(21, 23, 22)]
        [TestCase(19, 16, 22)]
        [TestCase(21, 22, 23)]
        [TestCase(20, 17, 23)]
        [TestCase(14, 2, 23)]
        public static void CheckMillDiffColour(int val1, int val2, int val3) //Testing for every case
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);
            morabaraba.Move(val2);
            morabaraba.Move(val3);
            Assert.That(!morabaraba.isKilling());
        }

        [TestCase(1, 2, 4)]
        [TestCase(1, 2, 5)]
        [TestCase(1, 2, 14)]
        [TestCase(0, 1, 3)]
        [TestCase(0, 1, 4)]
        [TestCase(0, 1, 9)]
        [TestCase(0, 3, 9)]
        [TestCase(0, 10, 9)]
        [TestCase(0, 3, 4)]
        [TestCase(0, 3, 10)]
        [TestCase(1, 4, 5)]
        [TestCase(1, 4, 3)]
        [TestCase(2, 5, 4)]
        [TestCase(2, 5, 13)]
        [TestCase(2, 14, 13)]
        [TestCase(2, 14, 5)]
        [TestCase(2, 14, 13)]
        [TestCase(3, 6, 10)]
        [TestCase(3, 6, 11)]
        [TestCase(3, 6, 7)]
        [TestCase(3, 6, 4)]
        [TestCase(3, 4, 7)]
        [TestCase(3, 4, 0)]
        [TestCase(3, 4, 10)]
        [TestCase(5, 4, 7)]
        [TestCase(5, 4, 8)]
        [TestCase(5, 4, 13)]
        [TestCase(5, 13, 12)]
        [TestCase(5, 13, 14)]
        [TestCase(5, 13, 8)]
        [TestCase(5, 8, 0)]
        [TestCase(5, 8, 7)]
        [TestCase(5, 8, 12)]
        [TestCase(5, 8, 0)]
        [TestCase(6, 7, 11)]
        [TestCase(6, 7, 4)]
        [TestCase(8, 7, 4)]
        [TestCase(8, 7, 12)]
        [TestCase(3, 10, 9)]
        [TestCase(3, 10, 11)]
        [TestCase(9, 10, 18)]
        [TestCase(9, 10, 21)]
        [TestCase(5, 13, 12)]
        [TestCase(5, 13, 14)]
        [TestCase(14, 13, 20)]
        [TestCase(13, 12, 17)]
        [TestCase(13, 12, 20)]
        [TestCase(8, 12, 13)]
        [TestCase(6, 11, 10)]
        [TestCase(13, 12, 17)]
        [TestCase(12, 17, 20)]
        [TestCase(12, 17, 16)]
        [TestCase(13, 20, 17)]
        [TestCase(13, 20, 23)]
        [TestCase(13, 20, 19)]
        [TestCase(6, 11, 3)]
        [TestCase(6, 11, 10)]
        [TestCase(11, 15, 18)]
        [TestCase(11, 15, 16)]
        [TestCase(9, 10, 18)]
        [TestCase(9, 21, 18)]
        [TestCase(9, 21, 10)]
        [TestCase(9, 21, 22)]
        [TestCase(21, 18, 19)]
        [TestCase(21, 18, 10)]
        [TestCase(21, 18, 22)]
        [TestCase(21, 22, 19)]
        [TestCase(21, 22, 9)]
        [TestCase(21, 22, 18)]
        [TestCase(18, 19, 15)]
        [TestCase(18, 19, 16)]
        [TestCase(18, 19, 22)]
        [TestCase(15, 16, 19)]
        [TestCase(16, 19, 18)]
        [TestCase(16, 19, 20)]
        [TestCase(16, 17, 12)]
        [TestCase(16, 17, 19)]
        [TestCase(22, 19, 20)]
        [TestCase(22, 19, 23)]
        [TestCase(22, 19, 18)]
        [TestCase(19, 20, 23)]
        [TestCase(19, 20, 17)]
        [TestCase(17, 20, 22)]
        [TestCase(17, 20, 16)]
        [TestCase(14, 23, 20)]
        [TestCase(14, 23, 22)]
        [TestCase(14, 23, 13)]
        [TestCase(20, 23, 22)]
        [TestCase(20, 23, 14)]
        public static void CheckMillNotLine(int val1, int val2, int val3) //Tests for all cases
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);
            morabaraba.NextTurn();
            morabaraba.Move(val2);
            morabaraba.NextTurn();
            morabaraba.Move(val3);
            Assert.That(!morabaraba.isKilling());
        }

        #region

        [TestCase(1, 2, 0, 5)]
        [TestCase(3, 6, 0, 6)]
        [TestCase(9, 21, 0, 7)]
        [TestCase(0, 2, 1, 8)]
        [TestCase(4, 7, 1, 12)]
        [TestCase(1, 0, 2, 4)]
        [TestCase(5, 8, 2, 4)]
        [TestCase(14, 23, 2, 4)]
        [TestCase(0, 6, 3, 4)]
        [TestCase(4, 5, 3, 8)]
        [TestCase(1, 7, 4, 9)]
        [TestCase(3, 5, 4, 8)]
        [TestCase(2, 8, 5, 4)]
        [TestCase(4, 3, 5, 12)]
        [TestCase(13, 20, 5, 4)]
        [TestCase(7, 8, 6, 4)]
        [TestCase(3, 0, 6, 4)]
        [TestCase(11, 15, 6, 4)]
        [TestCase(6, 8, 7, 4)]
        [TestCase(4, 1, 7, 15)]
        [TestCase(12, 17, 8, 4)]
        [TestCase(5, 2, 8, 4)]
        [TestCase(6, 7, 8, 4)]
        [TestCase(10, 11, 9, 4)]
        [TestCase(0, 21, 9, 4)]
        [TestCase(11,9, 10, 4)]
        [TestCase(3,18, 10, 4)]
        [TestCase(9,10, 11, 4)]
        [TestCase(6,15, 11, 4)]
        [TestCase(8,17, 12, 4)]
        [TestCase(13,14,12, 4)]
        [TestCase(12,14,13, 4)]
        [TestCase(5,20, 13, 4)]
        [TestCase(12,13,14, 4)]
        [TestCase(2,23, 14, 4)]
        [TestCase(17,16,15, 4)]
        [TestCase(11,6, 15, 4)]
        [TestCase(18,21,15, 4)]
        [TestCase(15,17,16, 4)]
        [TestCase(19,22,16, 4)]
        [TestCase(15,16,17, 4)]
        [TestCase(12,8, 17, 4)]
        [TestCase(20,23,17, 4)]
        [TestCase(19,20,18, 4)]
        [TestCase(3,10, 18, 4)]
        [TestCase(15,21,18, 4)]
        [TestCase(16,22,19, 4)]
        [TestCase(20,18,19, 4)]
        [TestCase(19,18,20, 4)]
        [TestCase(23,17,20, 4)]
        [TestCase(13,5, 20, 4)]
        [TestCase(22,23,21, 4)]
        [TestCase(9, 0, 21, 4)]
        [TestCase(18, 10,3, 4)]
        [TestCase(18,15,21, 4)]
        [TestCase(21,23,22, 4)]
        [TestCase(19,16,22, 4)]
        [TestCase(21,22,23, 4)]
        [TestCase(20,17,23, 4)]
        [TestCase(14, 2, 23, 4)]
        #endregion
        public static void CheckShootCowInMillA(int val1, int val2, int val3, int randoval)  //tests for all cases
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(randoval);
            morabaraba.Move(val1);
            morabaraba.NextTurn();
            morabaraba.Move(val2);
            morabaraba.NextTurn();
            morabaraba.Move(val3);
            morabaraba.NextTurn();
            Helpers.IValidPositionVerifier verifier = new Helpers.ValidPositionVerifier(morabaraba.CurrentBoard);

            Assert.That(verifier.VerifyCanShoot(randoval, morabaraba.Turn()));

        }


        #region

        [TestCase(1, 2, 0)]
        [TestCase(3, 6, 0)]
        [TestCase(9, 21, 0)]
        [TestCase(0, 2, 1)]
        [TestCase(4, 7, 1)]
        [TestCase(1, 0, 2)]
        [TestCase(5, 8, 2)]
        [TestCase(14, 23, 2)]
        [TestCase(0, 6, 3)]
        [TestCase(4, 5, 3)]
        [TestCase(1, 7, 4)]
        [TestCase(3, 5, 4)]
        [TestCase(2, 8, 5)]
        [TestCase(4, 3, 5)]
        [TestCase(13, 20, 5)]
        [TestCase(7, 8, 6)]
        [TestCase(3, 0, 6)]
        [TestCase(11, 15, 6)]
        [TestCase(6, 8, 7)]
        [TestCase(4, 1, 7)]
        [TestCase(12, 17, 8)]
        [TestCase(5, 2, 8)]
        [TestCase(6, 7, 8)]
        [TestCase(10, 11, 9)]
        [TestCase(0, 21, 9)]
        [TestCase(11, 9, 10)]
        [TestCase(3, 18, 10)]
        [TestCase(9, 10, 11)]
        [TestCase(6, 15, 11)]
        [TestCase(8, 17, 12)]
        [TestCase(13, 14, 12)]
        [TestCase(12, 14, 13)]
        [TestCase(5, 20, 13)]
        [TestCase(12, 13, 14)]
        [TestCase(2, 23, 14)]
        [TestCase(17, 16, 15)]
        [TestCase(11, 6, 15)]
        [TestCase(18, 21, 15)]
        [TestCase(15, 17, 16)]
        [TestCase(19, 22, 16)]
        [TestCase(15, 16, 17)]
        [TestCase(12, 8, 17)]
        [TestCase(20, 23, 17)]
        [TestCase(19, 20, 18)]
        [TestCase(3, 10, 18)]
        [TestCase(15, 21, 18)]
        [TestCase(16, 22, 19)]
        [TestCase(20, 18, 19)]
        [TestCase(19, 18, 20)]
        [TestCase(23, 17, 20)]
        [TestCase(13, 5, 20)]
        [TestCase(22, 23, 21)]
        [TestCase(9, 0, 21)]
        [TestCase(18, 10, 3)]
        [TestCase(18, 15, 21)]
        [TestCase(21, 23, 22)]
        [TestCase(19, 16, 22)]
        [TestCase(21, 22, 23)]
        [TestCase(20, 17, 23)]
        [TestCase(14, 2, 23)]
        #endregion
        public static void CheckShootCowInMillB(int val1, int val2, int val3)  //tests for all cases
            //this checks that a cow can be shoot when there are only mills on the board
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);//p1
            morabaraba.NextTurn();
            morabaraba.Move(val2);//p1
            morabaraba.NextTurn();
            morabaraba.Move(val3);//p1
            morabaraba.Changeremoving();
            Helpers.IValidPositionVerifier verifier = new Helpers.ValidPositionVerifier(morabaraba.CurrentBoard);

            Assert.That(verifier.VerifyCanShoot(val1, morabaraba.Turn()));

        }

        #region
        [TestCase(0, 21)]
        [TestCase(1, 21)]   
        [TestCase(2, 6)]
        [TestCase(3, 17)]
        [TestCase(4, 22)]
        [TestCase(5, 22)]
        [TestCase(6, 22)]
        [TestCase(7, 2)]
        [TestCase(8, 2)]
        [TestCase(9, 2)]
        [TestCase(10, 2)]
        [TestCase(11, 2)]
        [TestCase(13, 2)]
        [TestCase(12, 2)]
        [TestCase(14,6)]
        [TestCase(11,23)]
        [TestCase(16, 6)]
        [TestCase(18,6)]
        [TestCase(15,6)]
        [TestCase(19,6)]
        [TestCase(17,6)]
        [TestCase(20,6)]
        [TestCase(21,6)]
        [TestCase(22, 6)]
        [TestCase(23,6)]
        #endregion
        public static void CheckCantMovetoNotAdjacent(int val1, int val2)  //tests for all cases
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            morabaraba.Move(val1);
            Helpers.IValidPositionVerifier verifier = new Helpers.ValidPositionVerifier(morabaraba.CurrentBoard);
            Assert.That(!verifier.VerifyMoving2(val2));
        }

        #region
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        [TestCase(5, 4)]
        [TestCase(6, 3)]
        [TestCase(7, 6)]
        [TestCase(8, 7)]
        [TestCase(9, 0)]
        [TestCase(10, 9)]
        [TestCase(11, 10)]
        [TestCase(12, 13)]
        [TestCase(13, 12)]
        [TestCase(14, 13)]
        [TestCase(15, 11)]
        [TestCase(16, 15)]
        [TestCase(17, 20)]
        [TestCase(18, 10)]
        [TestCase(19, 18)]
        [TestCase(20, 17)]
        [TestCase(21, 22)]
        [TestCase(22, 21)]
        [TestCase(23, 22)]
        #endregion
        public static void CheckBoardAfterMove(int startval, int endval)  //tests thoroughly that the move happens as it should AND that the number of cows stays the same after a shift
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(startval);
            morabaraba.NextTurn();
            var cowcount = morabaraba.CurrentBoard.CowsOnBoard();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            var temp = morabaraba.GetBoard()[startval].Get();
            morabaraba.Move(startval);
            morabaraba.Move(endval);
            Assert.That(morabaraba.GetBoard()[endval].Get() == temp && morabaraba.GetBoard()[startval].Get() == Models.ColorType.Colour.Empty && morabaraba.CurrentBoard.CowsOnBoard() == cowcount);
        }

        #region
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 1)]
        [TestCase(3, 0)]
        [TestCase(4, 3)]
        [TestCase(5, 4)]
        [TestCase(6, 3)]
        [TestCase(7, 6)]
        [TestCase(8, 7)]
        [TestCase(9, 0)]
        [TestCase(10, 9)]
        [TestCase(11, 10)]
        [TestCase(12, 13)]
        [TestCase(13, 12)]
        [TestCase(14, 13)]
        [TestCase(15, 11)]
        [TestCase(16, 15)]
        [TestCase(17, 20)]
        [TestCase(18, 10)]
        [TestCase(19, 18)]
        [TestCase(20, 17)]
        [TestCase(21, 22)]
        [TestCase(22, 21)]
        [TestCase(23, 22)]
        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 14)]
        [TestCase(3, 4)]
        [TestCase(4, 1)]
        [TestCase(5, 4)]
        [TestCase(6, 3)]
        [TestCase(7, 4)]
        [TestCase(8, 5)]
        [TestCase(9, 10)]
        [TestCase(10, 3)]
        [TestCase(11, 6)]
        [TestCase(12, 8)]
        [TestCase(13, 20)]
        [TestCase(14, 2)]
        [TestCase(15, 18)]
        [TestCase(16, 17)]
        [TestCase(17, 12)]
        [TestCase(18, 15)]
        [TestCase(19, 16)]
        [TestCase(20, 13)]
        [TestCase(21, 9)]
        [TestCase(22, 19)]
        [TestCase(23, 20)]
        [TestCase(0, 9)]
        [TestCase(1, 4)]
        [TestCase(2, 14)]
        [TestCase(3, 10)]
        [TestCase(4, 7)]
        [TestCase(5, 8)]
        [TestCase(6, 11)]
        [TestCase(7, 8)]
        [TestCase(8, 12)]
        [TestCase(9, 21)]
        [TestCase(10, 18)]
        [TestCase(11, 15)]
        [TestCase(12, 17)]
        [TestCase(13, 5)]
        [TestCase(14, 23)]
        [TestCase(15, 11)]
        [TestCase(16, 19)]
        [TestCase(17, 20)]
        [TestCase(18, 15)]
        [TestCase(19, 20)]
        [TestCase(20, 23)]
        [TestCase(21, 18)]
        [TestCase(22, 19)]
        [TestCase(23, 14)]
        #endregion
        public static void CheckMovetoEmpty(int val1, int val2)
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(val1);
            morabaraba.Move(val2);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            morabaraba.Move(val2);
            Helpers.IValidPositionVerifier verifier = new Helpers.ValidPositionVerifier(morabaraba.CurrentBoard);
            Assert.That(!verifier.VerifyMoving2(val1));
        }
        [Test]
        public static void checkWinA()
        {
            Morabaraba morabaraba = new Morabaraba(3);
            morabaraba.Move(0);//p1 placed 1 unplaced 2
            morabaraba.Move(23);//p2 placed 1 unplaced 2
            morabaraba.Move(1);//p1 placed 2 unplaced 1
            morabaraba.Move(22);//p2 placed 2 unplaced 1
            morabaraba.Move(2);//p1 placed 3 unplaced 0
            morabaraba.Move(22);//p2 placed 1 unplaced 1
            morabaraba.Move(16);//p2 placed 2 unplaced 0
            Assert.That(morabaraba.GetPlayerLostOrNot());
        }
        [Test]
        public static void checkWinB()
        {
            Morabaraba morabaraba = new Morabaraba(4, 6);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(3);
            morabaraba.NextTurn();
            morabaraba.Move(4);
            //p2 now
            morabaraba.Move(2);
            morabaraba.NextTurn();
            morabaraba.Move(5);
            morabaraba.NextTurn();
            morabaraba.Move(6);
            morabaraba.NextTurn();
            morabaraba.Move(7);
            morabaraba.NextTurn();
            morabaraba.Move(9);
            morabaraba.NextTurn();
            morabaraba.Move(10);
            //p2 final move
            morabaraba.Move(1);

            Assert.That(morabaraba.GetPlayerLostOrNot());
        }



    }
}
