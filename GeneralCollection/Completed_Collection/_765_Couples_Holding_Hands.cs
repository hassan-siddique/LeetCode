using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
    internal class _765_Couples_Holding_Hands
    {

        Dictionary<int, int> dictLocations = new Dictionary<int, int>();


        private void swapValues(int i,int valToFind, int[] row)
        {
            
            int temp = row[i + 1];
            int indexToSwap = dictLocations[valToFind];
            dictLocations.Remove(row[i + 1]);
            dictLocations.Remove(row[indexToSwap]);

            row[i + 1] = row[indexToSwap];
            row[indexToSwap]=temp;

            dictLocations.Add(row[i + 1], i + 1);
            dictLocations.Add(row[indexToSwap], indexToSwap);

        }
        public int MinSwapsCouples(int[] row)
        {
            
            for (int i = 0; i < row.Length; i++)
            {
                dictLocations.Add(row[i], i);
            }

            int swapsCounter = 0;

            for (int i = 0; i < row.Length; i += 2)
            {
                int valToFind = row[i] % 2 == 0 ? row[i] + 1 : row[i] - 1;
                if (   row[i + 1]  != valToFind)
                {
                    swapValues(i, valToFind, row);
                    swapsCounter++;
                }
            }

            return swapsCounter;
        }

      
    }
}
