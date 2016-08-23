﻿using System;
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
            Stack storage = new Stack();
            int counter = 0;

            while (true)
            {
                string prompt = "[" + counter + "]> ";

                Console.Write(prompt);
                string userinput = Console.ReadLine().ToLower();

                
                

                newexpress.MatchCheck(userinput);
                newexpress.Extracting(userinput);
               

                int result = newevaluation.Evaluate(newexpress.firstnumber, newexpress.secondnumber, newexpress.theOperator);

                if (userinput == "last")
                {
                    Console.WriteLine(storage.last);
                }
                else if (userinput == "lastq")
                {
                    Console.WriteLine(storage.lastq);
                }

                storage.last = result;
                storage.lastq = userinput;

               

                Console.WriteLine(result);           
                counter++;

                


            }
           

           
        }
    }
}
