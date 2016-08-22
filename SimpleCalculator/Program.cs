using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluation newevaluation = new Evaluation();
            Expression newexpress = new Expression();
            Stack forresult = new Stack();
            Stack forexpress = new Stack();
            int savedresult = forresult.last;
            string savedexpress = forexpress.lastq;
            Counter counter = new Counter();
            int programcounter = counter.mycounter;
            string prompt = "[" + programcounter + "]> ";
            Console.Write(prompt);
            counter.CounterIncrease();
            Console.Read();
            string userinput = Console.ReadLine().ToLower();

            newexpress.MatchCheck(userinput);
            newexpress.Extracting(userinput);

            int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);

           
        }
    }
}
