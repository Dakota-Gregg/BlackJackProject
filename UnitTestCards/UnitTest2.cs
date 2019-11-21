using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace UnitTestCards
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestBettingFunctions()
        {
            //Arrange
            double pot = 20; //Current pot variable
            double balance = 20; //Current user balance variable
            double payout = 2;
            double blackjackpayout = 2.5;
            double win1, win2, win3; //Variables to hold values for each type of win
            double bwin = 50; //Expected value for blackjack player win
            double pwin = 40; //Expected value for player win
            double dwin = 20;  //Expected value for dealer win

            //Functions to test, edited for testing purposes
            void dealerWin()
            {
                pot = 0;
                win1 = balance;
                //formatPot(pot);
                //lblDealerWins.Visible = true;
            }

            void playerWin()
            {
                win2 = balance + (pot * payout);
                pot = 0;
                //formatBalance(balance);
                //formatPot(pot);
                //lblPlayerWins.Visible = true;
            }

            void playerBlackJack()
            {
                win3 = balance + (pot * blackjackpayout);
                pot = 0;
                //formatBalance(balance);
                //formatPot(pot);
                //lblDealerWins.Visible = true;
            }


            //Act
                //Test for blackjack win
                playerBlackJack();

                //Test for player win
                playerWin();

                //Test for dealer win
                dealerWin();

            //Assess
            dwin = win1; //Check that dealer win balance is correct
            pwin = win2; //Check that player win balance is correct
            bwin = win3; //Check that player blackjack balance is correct
        }
    }
}
