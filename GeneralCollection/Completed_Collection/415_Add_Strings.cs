using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
    class _415_Add_Strings
    {

        private static int to_int(char a)
        {
            return a - '0';
        }
        
        StringBuilder finalResult = new StringBuilder("");


        private int PerformAddition( int val1, int val2 ,ref int previous_carry)
        {
            int sum =  val1 + val2  + previous_carry;
            previous_carry = sum / 10;
            return sum % 10;
        }



        private string addStringIntegers(string bigString, string smallString)
        {
            int carry = 0,a=0, b=0;
            int small_index = smallString.Length-1;
            int big_index = bigString.Length - 1;
            for (; big_index>=0; big_index--, small_index--)
            {
                a = to_int(bigString[big_index]);
                if (small_index >= 0)
                    b = to_int(smallString[small_index]);
                else
                    b = 0;

                finalResult.Insert(0, PerformAddition(a,b,ref carry).ToString());
            }
            if (carry > 0) finalResult.Insert(0, carry.ToString());
            return finalResult.ToString();
        }

        
        public string AddStrings(string num1, string num2)
        {
            string bigString, smallstring = "";

            if (num1.Length >= num2.Length)
            {
                bigString = num1;
                smallstring = num2;
            }
            else
            {
                bigString = num2;
                smallstring = num1;
            }

            return addStringIntegers(bigString, smallstring);
        }
    }
}
