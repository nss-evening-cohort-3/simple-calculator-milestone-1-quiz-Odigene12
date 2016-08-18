using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionTest
    {
        //Make sure I can make a new Subtraction class
        [TestMethod]
        public void CanIMakeANewSubtractionClass()
        {
            Subtraction mysubtraction = new Subtraction();

            Assert.IsNotNull(mysubtraction);
        }

        //Test that I can subtract 2 numbers wihout getting a negative number
        [TestMethod]
        public void DoesMySubtractionMethodWorkWithoutNegative()
        {
            Subtraction mysubtraction = new Subtraction();

            int firstnumber = 6;

            int secondnumber = 4;

          int solution =  mysubtraction.Subtracting(firstnumber, secondnumber);

            Assert.AreEqual(2, solution);
        }


        [TestMethod]
        public void DoesMySubtractionMethodWorkWithNegative()
        {
            Subtraction mysubtraction = new Subtraction();

            int firstnumber = 8;

            int secondnumber = 10;

            int solution = mysubtraction.Subtracting(firstnumber, secondnumber);

            Assert.AreEqual(-2, solution);
        }
    }
}
