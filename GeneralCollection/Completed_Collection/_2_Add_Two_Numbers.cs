using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection.Collection
{
  
   ///Definition for singly-linked list.
    public class ListNode {
       public int val;
       public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
       }
    }
   
    internal class _2_Add_Two_Numbers
    {
 
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0, a = 0, b = 0;
  
            ListNode l1_ptr=l1;
            ListNode l2_ptr=l2;
            ListNode result=null;
            bool l1KeepLoop = true;
            bool l2KeepLoop = true;
            ListNode result_ptr = null;
            do
            {
                if (l1KeepLoop)
                {
                    a = l1_ptr.val;
                    if (l1_ptr.next == null)
                        l1KeepLoop = false;
                    else
                        l1_ptr = l1_ptr.next;
                }
                else a = 0;

                if (l2KeepLoop)
                {
                    b = l2_ptr.val;
                    if (l2_ptr.next == null)
                        l2KeepLoop = false;
                    else
                        l2_ptr = l2_ptr.next;
                }
                else b = 0;

                int sum = a + b + carry;
                carry = sum / 10;

                if (result_ptr == null)
                {
                    result = new ListNode(sum % 10, null);
                    result_ptr = result;
                }
                else
                {
                    result_ptr.next = new ListNode(sum % 10, null);
                    result_ptr = result_ptr.next;
                }


            } while (l1KeepLoop || l2KeepLoop);
             
            if(carry >0)
            {
                if (result_ptr == null)
                {
                    result = new ListNode(carry, null);
                    result_ptr = result;
                }
                else
                {
                    result_ptr.next = new ListNode(carry, null);
                    result_ptr = result_ptr.next;
                }
            }

            return result;
        }
    }
}
