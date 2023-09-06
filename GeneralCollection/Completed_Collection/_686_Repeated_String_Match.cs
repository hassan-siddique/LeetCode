using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.StillInProgress
{
    public class _686_Repeated_String_Match
    {
        public static void EntryPoint()
        {
            Console.WriteLine("abab >>>  "+ RepeatedStringMatch("abcd","cdabcdab").ToString() );
        }

        public static int RepeatedStringMatch(string a, string b) {
            int rem =  b.Length%a.Length ;
            int repeat = b.Length/a.Length ;
            if (rem>1)
                repeat++;


            string repString = string.Concat(Enumerable.Repeat(a,repeat));
            string rep1String = string.Concat(Enumerable.Repeat(a,repeat+1));


            if(repString.Contains(b))
            {
                return repeat;
            }   
            else if(rep1String.Contains(b))
            {
                return repeat+1;
            }  


            return -1;
        }
    }
}
