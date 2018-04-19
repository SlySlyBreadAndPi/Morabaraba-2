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
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            var nodes = morabaraba.GetBoard();
            Assert.That(nodes.Count == 24);
        }
        [Test]
        public static void CheckMillSameColour()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.NextTurn();
            Assert.That(morabaraba.isKilling());
        }
        [Test]
        public static void CheckMillDiffColour()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.Move(1);
            morabaraba.Move(2);
            Assert.That(!morabaraba.isKilling());
        }
        [Test]
        public static void CheckMillNotLine()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(4);
            Assert.That(!morabaraba.isKilling());
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
        [Test]
        public static void CheckShootCowInMillA()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(19);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.Move(1);
            morabaraba.NextTurn();
            morabaraba.Move(2);
            morabaraba.Move(19);
            morabaraba.NextTurn();
            morabaraba.Move(19);
            morabaraba.Move(21);
            morabaraba.NextTurn();
            morabaraba.Move(22);
            morabaraba.NextTurn();
            morabaraba.Move(23);
            morabaraba.Move(0);
            Assert.That(morabaraba.isKilling());
        }
        [Test]
        public static void CheckShootCowInMillB()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(19);//p1
            morabaraba.Move(0);//p2
            morabaraba.NextTurn();
            morabaraba.Move(1);//p2
            morabaraba.NextTurn();
            morabaraba.Move(2);//p2
            morabaraba.Move(19);//p2
            morabaraba.Move(21);//p1
            morabaraba.NextTurn();
            morabaraba.Move(22);//p1
            morabaraba.NextTurn();
            morabaraba.Move(23);//p1
            morabaraba.Move(0);
            Assert.That(!morabaraba.isKilling());
        }
        [Test]
        public static void CheckMovetoAdjacent()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            morabaraba.Move(0);
            morabaraba.Move(23);
            Assert.That(morabaraba.GetBoard()[23].Get() == MorabarabaNS.Models.ColorType.Colour.Empty);
        }
        [Test]
        public static void CheckMovetoEmpty()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(1);
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            morabaraba.Move(0);
            var temp = morabaraba.GetBoard()[1].Get();
            morabaraba.Move(1);
            Assert.That(temp == morabaraba.GetBoard()[1].Get());
        }
        [Test]
        public static void CheckBoardAfterMove()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            var temp = morabaraba.GetBoard()[0].Get();
            morabaraba.Move(0);
            morabaraba.Move(1);
            Assert.That(morabaraba.GetBoard()[1].Get() == temp);
        }
        [Test]
        public static void CheckBoardAfterMoveB()
        {
            Morabaraba morabaraba = new Morabaraba();
            morabaraba.Move(0);
            morabaraba.NextTurn();
            morabaraba.SetTurnPhase(Models.Phases.Phase.Moving);
            var temp = morabaraba.CowsOnBoard();
            morabaraba.Move(0);
            morabaraba.Move(1);
            Assert.That(morabaraba.CowsOnBoard() == temp);
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
            Morabaraba morabaraba = new Morabaraba(4,6);
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
