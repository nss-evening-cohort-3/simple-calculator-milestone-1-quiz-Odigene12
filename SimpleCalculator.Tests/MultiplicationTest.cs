using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplicationTest
    {
        //Make sure you can make a new Multiplication class
        [TestMethod]
        public void CanIMakeANewMultiplicationClass()
        {
            Multiplication mymultiply = new Multiplication();

            Assert.IsNotNull(mymultiply);
        }

        //Make sure I can multiply any positive integers
        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            Multiplication mymultiply = new Multiplication();

            int firstnumber = 7;

            int secondnumber = 10;

            int solution = mymultiply.Multiplying(firstnumber, secondnumber);

            Assert.AreEqual(70, solution);
        }

        //Make sure you can multiply a positive and negative number
        [TestMethod]
        public void MultiplyAPositiveAndNegative()
        {
            Multiplication mymultiply = new Multiplication();

            int firstnumber = 7;

            int secondnumber = -5;

            int solution = mymultiply.Multiplying(firstnumber, secondnumber);

            Assert.AreEqual(-35, solution);
        }

        //Make sure you can multiply two negative numbers (which equal a positive)
        [TestMethod]
        public void MultiplyTwoNegativeNumbers()
        {
            Multiplication mymultiply = new Multiplication();

            int firstnumber = -5;

            int secondnumber = -5;

            int solution = mymultiply.Multiplying(firstnumber, secondnumber);

            Assert.AreEqual(25, solution);
        }
    }
}
