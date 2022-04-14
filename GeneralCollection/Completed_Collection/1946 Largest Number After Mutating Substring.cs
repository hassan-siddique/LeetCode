using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection
{
    internal class _1946_Largest_Number_After_Mutating_Substring
    {
        
        
        public string MaximumNumber(string num, int[] change)
        {
            char []char_arr = num.ToCharArray();
            StringBuilder result = new StringBuilder(num);
            bool oneReplaced= false;
            
            for(int i =0; i < char_arr.Length ;i++ )
            {

                if(char_arr[i]-'0' < change[char_arr[i] - '0'])
                {
                    result.Replace(char_arr[i].ToString(), change[char_arr[i] - '0'].ToString(), i, 1);
                    oneReplaced = true;
                }
                else if (char_arr[i] - '0' == change[char_arr[i] - '0']&& oneReplaced)
                {
                    result.Replace(char_arr[i].ToString(), change[char_arr[i] - '0'].ToString(), i, 1);
                    oneReplaced = true;
                }
                else if(oneReplaced)
                {
                    break;
                }

            }
             
            return result.ToString();

        }
    }
}
