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
    }
}
