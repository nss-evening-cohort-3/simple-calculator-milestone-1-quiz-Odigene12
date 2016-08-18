using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTest
    {
        //Can you make a new addition class
        [TestMethod]
        public void CanICreateAnAdditionClass()
        {
            Addition myaddition = new Addition();

            Assert.IsNotNull(myaddition);
        }

        //Create a test that tests the addition method
        [TestMethod]
        public void DoesAdditionWork()
        {
            Addition myaddition = new Addition();

            int firstnumber = 2;

            int secondnumber = 4;

            int solution = myaddition.Adding(firstnumber, secondnumber);

            Assert.AreEqual(6, solution);
        }
    }
}
