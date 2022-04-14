using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
     
    internal class _973_K_Closest_Points_to_Origin
    {

        /// <summary>   https://leetcode.com/problems/k-closest-points-to-origin/
        /// Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, return the k closest points to the origin (0, 0).

        // The distance between two points on the X-Y plane is the Euclidean distance(i.e., √(x1 - x2)2 + (y1 - y2)2).

        //You may return the answer in any order.The answer is guaranteed to be unique (except for the order that it is in).



        //Example 1:


        //Input: points = [[1,3],[-2,2]], k = 1
        //Output: [[-2,2]]
        //Explanation:
        //The distance between(1, 3) and the origin is sqrt(10).
        //The distance between(-2, 2) and the origin is sqrt(8).
        //Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
        //We only want the closest k = 1 points from the origin, so the answer is just[[-2, 2]].
        //Example 2:

        //Input: points = [[3,3],[5,-1],[-2,4]], k = 2
        //Output: [[3,3],[-2,4]]
        //Explanation: The answer[[-2,4],[3,3]] would also be accepted.


        //Constraints:

        //1 <= k <= points.length <= 104
        //-104 < xi, yi< 104
        /// </summary>
        /// <param name="args"></param>
 
        public class Solution
        {

           

            class CalcualtedPoint
            {
                public int point_x;
                public int point_y;

                public int distance;
            }

            class ListOfMinDistPoints
            {
                List<CalcualtedPoint> result;
                int maxSize = 0;
                public  ListOfMinDistPoints(int size)
                {
                    maxSize = size;
                    result = new List<CalcualtedPoint>(size);
                }


                public void insertPoints(CalcualtedPoint point)
                {

                    point.distance = point.point_x * point.point_x + point.point_y * point.point_y;

                    result.Add(point);

                 
                    
                }


                public  int [][] return2DArray()
                {
                    result = result.OrderBy(x => x.distance).ToList();

                    int[][] ret2DArray = new int[maxSize][];
                    for(int i =0; i < ret2DArray.Length; i++)
                    {
                        ret2DArray[i] = new int[2];
                        ret2DArray[i][0] = result[i].point_x;
                        ret2DArray[i][1] = result[i].point_y;
                    }

                    return ret2DArray;
                }
            }

            


            public int[][] KClosest(int[][] points, int k)
            {

                ListOfMinDistPoints lst = new ListOfMinDistPoints(k);
                for(int i =0; i <points.Length;i++)
                {

                    var pnt = new CalcualtedPoint();
                    pnt.point_x = points[i][0];
                    pnt.point_y = points[i][1];

                    lst.insertPoints(pnt);

                }




                return lst.return2DArray();
            }
        }

    }
}
