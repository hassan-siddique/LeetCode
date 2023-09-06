using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Completed_Collection
{
    class _459_repeated_substring_pattern
    {
        //public bool RepeatedSubstringPattern(string s) {

        //     if (s.Length ==1 )
        //            return false;


        //    if(s.Length%2 == 0){
        //       var subString= s.Substring(0,s.Length/2);
        //       if(s.Equals(subString+subString))
        //       {
        //            return true;
        //       }
        //    }
        //    else
        //    {


        //        var midChar = s[s.Length/2];
        //        if( s[s.Length/2 -1]==midChar )
        //            return true;


        //    }
        //    return false;
        //}

        public static void EntryPoint()
        {
            Console.WriteLine("abab >>>  "+ RepeatedSubstringPattern1("abab").ToString() );
        }

        public static bool RepeatedSubstringPattern(string s)
        { 
            if(s.Length==1)
                return false;

            int min_index = 2;
            int max_index = s.Length/min_index;

            while (min_index<=max_index)
            {
                //do magic here


                if (s.Length % min_index == 0)
                {
       
                    string subMultiplied1   = string.Concat(Enumerable.Repeat( s.Substring(0,min_index), max_index));
                    string subMultiplied2  = string.Concat(Enumerable.Repeat( s.Substring(0,max_index),min_index ));
                    if (subMultiplied1.Equals(s))
                    {
                        return true;
                    }
                    else if (subMultiplied2.Equals(s))
                    {
                        return true;
                    }

                }

                min_index++;
                max_index = s.Length/min_index;
            }



            //int n = s.Length;
            //for (int len = 1; len <= n / 2; len++)
            //{
            //    if (n % len == 0)
            //    {
            //        string substring = s.Substring(0, len);
            //        string constructed = string.Concat(substring, new string(substring[0], n - len));
            //        if (constructed.Equals(s))
            //        {
            //            return true;
            //        }
            //    }
            //}
            return false;
        }

        public static bool RepeatedSubstringPattern1(string s)
        { 
            if(s.Length==1)
                return false;

            string newstr = (s+s).Substring(1,s.Length*2-2);
            if(newstr.Contains(s))
                return true;
            return false;
        }
    }
}
