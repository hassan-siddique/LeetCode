using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
    internal class _41_First_Missing_Positive
    {
        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            nums.AsParallel().ForAll(x => set.Add(x));

            for(int i =1;i<=nums.Length;i++ )
            {
                if (!set.Contains(i))
                    return i;
            }
            return nums.Length + 1;

        }
    }
}
