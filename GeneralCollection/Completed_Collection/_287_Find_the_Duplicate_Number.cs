using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{

    public class _287_Find_the_Duplicate_Number
    {
        public int FindDuplicate(int[] nums)
        {

            //int[] indexCounter = new int[nums.Length - 1];
            //indexCounter.AsParallel().ForAll(x=> x=0);

            //nums.AsParallel().ForAll(x => indexCounter[x-1] += 1);

            //for (int i = 0; i < indexCounter.Length; i++)
            //{
            //    if (indexCounter[i] > 1)
            //        return i+1;
            //}
            //return 0;


            for (int i = 0; i < nums.Length; i++)
            {
                int cur = nums[i] < 0 ? nums[i] * -1 : nums[i];
                if (nums[cur] < 0)
                    return cur;

                nums[cur] = nums[cur] * -1;
            }

            return 0;


        }
    }

}