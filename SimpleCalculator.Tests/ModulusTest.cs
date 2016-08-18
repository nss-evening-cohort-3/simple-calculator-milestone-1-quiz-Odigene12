using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModulusTest
    {
        //Make sure you can make a Modulus class
        [TestMethod]
        public void MakeMeAModulus()
        {
            Modulus mymodulus = new Modulus();

            Assert.IsNotNull(mymodulus);
        }

        //Let's see if your modulus returns an integer for a remainder.
        [TestMethod]
        public void MakeSureRemainderIsReturned()
        {
            Modulus mymodulus = new Modulus();

            int firstnumber = 4;

            int secondnumber = 3;

            int solution = mymodulus.Modulo(firstnumber, secondnumber);

            Assert.AreEqual(1, solution);
        }

        //Test to make sure there is no remainder
        [TestMethod]
        public void MakeSureNoRemainder()
        {
            Modulus mymodulus = new Modulus();

            int firstnumber = 8;

            int secondnumber = 4;

            int solution = mymodulus.Modulo(firstnumber, secondnumber);

            Assert.AreEqual(0, solution);
        }
    }
}
