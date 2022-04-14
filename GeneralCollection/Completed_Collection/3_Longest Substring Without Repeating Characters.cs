using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection
{
    internal  class _3_Longest_Substring_Without_Repeating_Characters_1    // This didnt work for "dvdf" where output was 2 but should have been 3 , we need to store index as well
    {
        HashSet<char> store;        
        public void  ResetStore()
        {
            store = new HashSet<char>();
        }
        public int LengthOfLongestSubstring(string s)
        {
            ResetStore();
            int Max = 0;
            int currentCount=0;
            int index = 0;

            while(index < s.Length)
            {
                if ( store.Contains(s[index]) )
                {
                    //reset hashblock and start again here
                    ResetStore();
                    store.Add(s[index]);
                    if (currentCount>Max)
                    {
                        Max = currentCount;
                    }
                    currentCount = 1;
                }
                else
                {
                    //insert in hash and update counters
                    store.Add(s[index]);
                    currentCount ++;
                }
                index++;
            }

            if (currentCount > Max)
            {
                Max = currentCount;
            }
            return Max;

        }
    }



    internal class _3_Longest_Substring_Without_Repeating_Characters_2    // This didnt work for "dvdf" where output was 2 but should have been 3 , we need to store index as well
    {
        Dictionary<char,int> store = new Dictionary<char, int>();
        public void ResetStore()
        {
             store.Clear();
        }
        public int LengthOfLongestSubstring(string s)
        {
            int Max = 0;
            int currentCount = 0;
            int index = 0;

            while (index < s.Length)
            {
                if (store.ContainsKey(s[index]))
                {
                    index = store[s[index]]+1;
                    ResetStore();
                    //reset store block and start again here                    
                    if (currentCount > Max)
                    {
                        Max = currentCount;
                    }
                    currentCount = 0;
                    continue;
                }
 
                //insert in hash and update counters
                store.Add(s[index],index);
                currentCount++;
                index++;
            }

            if (currentCount > Max)
            {
                Max = currentCount;
            }
            return Max;

        }
    }


}
