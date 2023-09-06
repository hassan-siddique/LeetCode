using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
  
    public class _504_Base_7
    {
        const int Base = 7;
        public string ConvertToBase7(int num)
        {
            string sign = "";
            string result = "";
            if (num < 0)
            {
                sign = "-";
                num = -1 * num;
            }
            while (num>= Base)
            { 
                int rem = num % Base;
                
                num = (num - rem) / Base;

                result = Convert.ToChar(rem) + result;
            }

            result = sign + Convert.ToChar(num) + result;
            return result;

        }
    }
}
