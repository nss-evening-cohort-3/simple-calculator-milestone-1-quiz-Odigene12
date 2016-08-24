using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
   public class Constant
    {
        Expression forstorage = new Expression();
        Dictionary<string, int> userconstants = new Dictionary<string, int>();

        public void StoreConstantsAndValue(string constant, int value)
        {
            userconstants.Add(constant.ToLower(), value);
           
        }

        public int GetsConstantsAndValue(string input)
        {
            if (userconstants.ContainsKey(input.ToLower()))
            {
                int returnedkey = userconstants[input.ToLower()];

                return returnedkey;
            }
            else throw new MissingMemberException("Can't find the int");
            
            
        }
       
    }
}
