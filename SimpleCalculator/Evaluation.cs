using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
   public class Evaluation
    {
        //Use the addition class to evaluate an expression
        Expression forevaluation = new Expression();
        Addition foraddition = new Addition();
        Subtraction forsubtraction = new Subtraction();
        Multiplication formultiply = new Multiplication();
        Division fordivision = new Division();
        Modulus formodulus = new Modulus();


        public int Evaluate(int firstnumber, int secondnumber, string theOperator)
        {
            if (theOperator == "+")
            {
                int additionresult = foraddition.Adding(firstnumber, secondnumber);
                    return additionresult;
            }
            //Use the subtraction class to evaluate an expression
            else if (theOperator == "-")
            {
                int subtractionresult = forsubtraction.Subtracting(firstnumber, secondnumber);
                return subtractionresult;
            }
            else if (theOperator == "/")
            {
                //Use the division class to evaluate an expression (make sure to account for dividing by "0")
                if (secondnumber == 0)
                {
                    throw new DivideByZeroException("Undefined");
                }
                else {
                    int divisionresult = fordivision.Dividing(firstnumber, secondnumber);
                    return divisionresult; 
                      }
            }
            //Use the multiplication class to evaluate an expression
            else if (theOperator == "*")
            {
                int multiplyresult = formultiply.Multiplying(firstnumber, secondnumber);
                return multiplyresult;
            }
            else if (theOperator == "%")
            {
                //make sure to account for dividing by "0"
                if (secondnumber == 0)
                {
                    throw new DivideByZeroException("Undefined");
                }
                else
                {
                    int modulusresult = formodulus.Modulo(firstnumber, secondnumber);
                    return modulusresult;
                }
            }
            else throw new InvalidOperationException("That is not an Operator");

        }


       

        

      

        //Use the modulus class to evaluate an expression
    }
}
