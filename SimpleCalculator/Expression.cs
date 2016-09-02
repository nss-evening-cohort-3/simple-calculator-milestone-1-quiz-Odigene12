using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        
       

        //Check to make sure the user is inputing the expression correctly
        public bool MatchCheck(string input)
        {
            //Create the pattern that the user must follow when entering his or her expression
            string pattern = @"^(\-*\d\s*[+\-\*\/\%]\s*\d+)$";
            Match thismatch = Regex.Match(input, pattern);

            if (thismatch.Success)
            {
                return true;
            }
            
            else
            {
                return false;
                throw new InvalidOperationException("This Is Not an Operator");
            }
            
        }

        public bool KeyWordCheck(string input)
        {
            //Create the pattern that the user must follow when entering his or her expression
            string wordpattern = @"^(\s*\w+\s*)$";
            Match wordmatch = Regex.Match(input, wordpattern);

            if (wordmatch.Success)
            {
                return true;
            }
            else
            {
                return false;
                throw new MissingFieldException("Please enter correct Command");
            }

        }

        //If the user made valid expression, extract the operator inside of the expression
        public void Extracting(string input)
        {
            if (MatchCheck(input) == true)
            {
                string thispattern = @"^(?<firstnumber>\-*\d+)\s*(?<operator>[\+\-\*\/\%])\s*(?<secondnumber>\d+)$";
                Match thismatch = Regex.Match(input, thispattern);
                firstnumber = Convert.ToInt32(thismatch.Groups["firstnumber"].Value);
                secondnumber = Convert.ToInt32(thismatch.Groups["secondnumber"].Value);
                theOperator = thismatch.Groups["operator"].Value;
            }

            
        }

        public void MatchKeyWords(string input)
        {
            if (KeyWordCheck(input) == true)
            {
                string keywordpattern = @"^(\s*(last)|\s*(lastq))$";
                Match wordmatch = Regex.Match(input, keywordpattern);

            }
            else throw new FormatException("Please enter the correct word format");
        }

        public bool ConstantCheck(string input)
        {
            //Create the pattern that the user must follow when entering his or her expression
            string constantpattern = @"^([\w+]\s*[=]\s*[\d+])$";
            Match constantmatch = Regex.Match(input, constantpattern);

            if (constantmatch.Success)
            {
                return true;
            }
            else
            {
                return false;
                throw new MissingFieldException("Please enter correct Command");
            }

        }

        public void MatchConstantExpression(string input)
        {
            if (ConstantCheck(input) == true)
            {
                string constantExpressionPattern = @"^(?<constant>[\w+])\s*(?<operator>[=])\s*(?<constvalue>\-*[\d+])$";
                Match matchconstant = Regex.Match(input, constantExpressionPattern);
                constant = matchconstant.Groups["constant"].Value;
                theOperator = matchconstant.Groups["operator"].Value;
                constantvalue = Convert.ToInt32(matchconstant.Groups["constvalue"].Value);
            }
            
        }

        public int firstnumber { get; set; }

        public int secondnumber { get; set; }

        public string theOperator { get; set; }


        //public variables to use to save constants and their values
        public string constant { get; set; }

        public int constantvalue { get; set; }

    }
}
