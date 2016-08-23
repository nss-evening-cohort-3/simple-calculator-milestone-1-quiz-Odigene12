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

        public void StoreConstantsAndValue()
        {
            userconstants.Add(forstorage.constant, forstorage.constantvalue);
        }

        public int GetsConstantsAndValue(string input)
        {
            if (userconstants.ContainsKey(input.ToLower()))
            {
                int returnedkey = userconstants[input.ToLower()];

                return returnedkey;
            }
            else return 0;
            
        }
       
    }
}
