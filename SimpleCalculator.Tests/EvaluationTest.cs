using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluationTest
    {
        //Make a test that makes sure you can do Addition
        [TestMethod]
        public void MakeSureICanAdd()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "1+2";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
            Assert.AreEqual(3, result);
        }

        //Make a Test that makes sure you can subtract
        [TestMethod]
        public void MakeSureICanSubtract()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "5 - 3";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
            Assert.AreEqual(2, result);
        }

        //Make a sure you can multiply
        [TestMethod]
        public void MakeSureYouCanMultiply()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "-3*7";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
            Assert.AreEqual(-21, result);
        }

        //Make Sure you can divide
        [TestMethod]
        public void MakeSureYouCanDivide()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "8/4";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
            Assert.AreEqual(2, result);
        }

        //Make sure you account for someone dividing by "0"
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MakeSureUndefinedExceptionThrows()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "7/0";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
           
        }

        [TestMethod]
        public void MakeSureYouCanModulo()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "7%3";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
            Assert.AreEqual(1, result);
        }

        //Make a Test that accounts for "%0"
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MakeSureModuloAccountsForException()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "8%0";

            newexpress.MatchCheck(expression);
            newexpress.Extracting(expression);


            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
       
        }

        //Test if some kind of symbol is placed instead of the operator
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestIfSomeKindOfSymbolIsPlaced()
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            string expression = "1#3";

            newexpress.MatchCheck(expression);

            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);
        }
    }
}
