using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsBlackJack;

namespace UnitTestCards
{
    [TestClass]
    public class UnitTestCardsClass
    {
        [TestMethod]
        public void TestMethodCardRandomizer()
        {
            //Arrange
            Card card = new Card();

            //Act
            //Tuple<int, int, int> cardvalues = card.Calculate();

            //Assess
            //Console.WriteLine(cardvalues);
        }
    }
}
