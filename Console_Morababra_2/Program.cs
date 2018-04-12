using System;
using Morabaraba_2;
using Morabaraba_2.Classes;
using Morabaraba_2.Helpers;
using NUnit;
using NUnit.Framework;

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
            bool check = currentGameSession.Turn().GetCow().Get() == Morabaraba_2.Models.ColorType.Colour.Dark;
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
    }
}
