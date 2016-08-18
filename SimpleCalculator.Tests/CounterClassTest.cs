using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CounterClassTest
    {
        //Create a Test that makes sure you can instantiate a new Counter class.
        [TestMethod]
        public void CanICreateANewCounterClass()
        {
            Counter newcounter = new Counter();

            Assert.IsNotNull(newcounter); 
        }

        //Create a test that makes sure your counter increases by 1 each time the corresponding method is called. 
        [TestMethod]
        public void DoesMyCounterIncreaseBy1EachTime()
        {
            Counter newcounter = new Counter();

            newcounter.CounterIncrease();
            newcounter.CounterIncrease();
            newcounter.CounterIncrease();

            Assert.AreEqual(3, newcounter.mycounter);
        }
    }
}
