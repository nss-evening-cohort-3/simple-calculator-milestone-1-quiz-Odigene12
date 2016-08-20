using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        //Make sure you can instantiate a new Expression class
        [TestMethod]
        public void MakeANewExpressionClass()
        {
            Expression newexpress = new Expression();

            Assert.IsNotNull(newexpress);
        }

        //This test should assess whether I have successfully extracted the operator in the expression.
        [TestMethod]
        public void DoesTheUserInputMatchExpression()
        {
            Expression newexpress = new Expression();
            string userinput = "1 + 2";
            bool matching = newexpress.MatchCheck(userinput);
            
            Assert.IsTrue(matching);
        }

        //Make sure you can match the expression without spaces
        [TestMethod]
        public void DoestTheUserInputMatchWithoutSpaces()
        {
            Expression newexpress = new Expression();
            string userinput = "1+2";
            bool matching = newexpress.MatchCheck(userinput);

            Assert.IsTrue(matching);
        }

        //Make sure that the expression evaluates to false if the user inputs something wrong
        [TestMethod]
        public void TestingIfUserInputDoesNOTMatch()
        {
            Expression newexpress = new Expression();
            string userinput = "1";
            bool matching = newexpress.MatchCheck(userinput);

            Assert.IsFalse(matching);
        }

        //Assess false even if for some reason the user puts just the operator
        [TestMethod]
        public void TestingIfItIsJustNumberAndOperator()
        {
            Expression newexpress = new Expression();
            string userinput = "+";
            bool matching = newexpress.MatchCheck(userinput);

            Assert.IsFalse(matching);
        }

        //This test should assess whether I have a Bad Input.
        [TestMethod]
        public void SuccessfulExtraction()
        {
            Expression newexpress = new Expression();
            string userinput = "1+2";
            bool matching = newexpress.MatchCheck(userinput);
             newexpress.Extracting(userinput);

            Assert.AreEqual(1, newexpress.firstnumber);
            Assert.AreEqual(2, newexpress.secondnumber);
            Assert.AreEqual("+", newexpress.theOperator);
        }

        //Make Sure your exception throws for a bad input
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void UnsuccessfulExtractionToThrowException()
        {
            Expression newexpress = new Expression();
            string userinput = "1+";
            bool matching = newexpress.MatchCheck(userinput);
            newexpress.Extracting(userinput);

            
        }

    }
}
