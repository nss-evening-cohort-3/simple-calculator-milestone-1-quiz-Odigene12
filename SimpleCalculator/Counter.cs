using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Counter
    {
        //Create a counter that starts at zero.
        public int mycounter = 0;

        //Create a method that adds one to your counter whenever called.
        public int CounterIncrease()
        {
            return mycounter++;
        }
    }
}
