using System;
using Morabaraba_2;
using Morabaraba_2.Classes;
using Morabaraba_2.Helpers;
using NUnit;
using NUnit.Framework;
using NSubstitute;
using Morabaraba_2.Interfaces;

namespace Console_Morababra_2
{
    class Program
    {
        [Test]
        public static void BoardEmpty()
        {
            Morabaraba currentGameSession = new Morabaraba();
            bool check = currentGameSession.GetBoard().Contains(new Cow(Morabaraba_2.Models.ColorType.Colour.Dark)) || currentGameSession.GetBoard().Contains(new Cow(Morabaraba_2.Models.ColorType.Colour.Light));
            Assert.That(!check);
        }
        [Test]
        public static void P1Dark()
        {
            Morabaraba currentGameSession = new Morabaraba();
            bool check = currentGameSession.Turn(true).GetCow().Get() == Morabaraba_2.Models.ColorType.Colour.Dark;
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
            for(int i=0; i < 24; i++)
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
            
            var command = Substitute.For<IMorabaraba>();
            Morabaraba tester = new Morabaraba();
            var repeater = tester.Move(0);
            command.DidNotReceive().Move(0);
          


        }
    }
}
