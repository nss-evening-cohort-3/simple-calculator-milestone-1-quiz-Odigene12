using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTest
    {

        //Make sure you can create a Division class
        [TestMethod]
        public void CreateADivisionClass()
        {
            Division mydivision = new Division();

            Assert.IsNotNull(mydivision);
        }

        //Make sure you can divide two integers
        [TestMethod]
        public void DividingTwoIntegers()
        {
            Division mydivision = new Division();

            int firstnumber = 4;

            int secondnumber = 2;

            int solution = mydivision.Dividing(firstnumber, secondnumber);

            Assert.AreEqual(2, solution);
        }

        //Make sure you can divide two integers even with a remainder to get integer
        [TestMethod]
        public void DividingWithARemainderToGetInteger()
        {
            Division mydivision = new Division();

            int firstnumber = 4;

            int secondnumber = 3;

            int solution = mydivision.Dividing(firstnumber, secondnumber);

            Assert.AreEqual(1, solution);
        }

        //Make sure you can divide a negative and positive number
        [TestMethod]
        public void DivideByNegativeNumber()
        {
            Division mydivision = new Division();

            int firstnumber = -8;

            int secondnumber = 2;

            int solution = mydivision.Dividing(firstnumber, secondnumber);

            Assert.AreEqual(-4, solution);
        }

        //Make sure you get an interger (NO DECIMALS)
        [TestMethod]
        public void DivisionWithNoDecimals()
        {
            Division mydivision = new Division();

            int firstnumber = 11;

            int secondnumber = 5;

            int solution = mydivision.Dividing(firstnumber, secondnumber);

            Assert.AreEqual(2, solution);
        }

        //Make sure you get an interger even if negative (NO DECIMALS)
        [TestMethod]
        public void DivisionOfNegativeWithNoDecimals()
        {
            Division mydivision = new Division();

            int firstnumber = -8;

            int secondnumber = 3;

            int solution = mydivision.Dividing(firstnumber, secondnumber);

            Assert.AreEqual(-2, solution);
        }
    }
}
