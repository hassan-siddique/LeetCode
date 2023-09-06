using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCollection
{
    

    
    
    class _1721_Swapping_Nodes_in_a_Linked_List
    {

        public static void EntryPoint()
        {
                    //_1721_Swapping_Nodes_in_a_Linked_List.ListNode head = new _1721_Swapping_Nodes_in_a_Linked_List.ListNode(1,new _1721_Swapping_Nodes_in_a_Linked_List.ListNode(2));
            //_1721_Swapping_Nodes_in_a_Linked_List obj = new _1721_Swapping_Nodes_in_a_Linked_List();
            //obj.SwapNodes(head, 1);
        }



        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode SwapNodes(ListNode head, int k)
        {
            if (head.next == null)
                return head;

            HashSet<ListNode> lstNodes = new HashSet<ListNode>();

            ListNode start_ptr = head;
            ListNode end_ptr = head;

            while (start_ptr != null)
            {
                lstNodes.Add(start_ptr);
                start_ptr = start_ptr.next;
            }

            start_ptr = lstNodes.ElementAt<ListNode>(k-1);
            end_ptr = lstNodes.ElementAt<ListNode>(lstNodes.Count - k );
            int temp = start_ptr.val;
            start_ptr.val = end_ptr.val;
            end_ptr.val = temp;


            return head;

        }
            public ListNode SwapNodes2(ListNode head, int k)
        {
            if (head.next == null)
                return head;
            int slow_counter = 1;
            int fast_counter = 1;
        
            ListNode slow = head;
            ListNode fast = head;

            ListNode begin_kNode = null;
            ListNode end_kNode = null;
            while (slow_counter != k)
            {
                slow = slow.next;
                slow_counter++;
                if (slow_counter == k)
                {
                    begin_kNode = slow;
                }

                if (fast.next != null && fast.next.next != null)
                {
                    fast = fast.next.next;
                    fast_counter += 2;
                }
                else if (fast.next != null)
                {
                    fast = fast.next;
                    fast_counter++;
                }
            }
            if (slow_counter == k)
            {
                begin_kNode = slow;
            }

            while (fast != null  && fast.next != null )
            {
               if(  fast.next !=null && fast.next.next!= null)
                {
                    fast = fast.next.next;
                    fast_counter+=2;
                }
                else if(  fast.next != null)
                {
                    fast = fast.next;
                    fast_counter++;
                    break;
                }
                 
            }
            //if (slow_counter > fast_counter - k + 1)
            //    k = fast_counter - k + 1;
            // this is the problem when total nodes are 5 and k is almost equal to total count 

            if (fast_counter - k + 1 == slow_counter && k == fast_counter - k + 1)
            {
                return head;
            }

            if (fast_counter - k+1 == slow_counter)
            {
                end_kNode = slow;
            }

            while (fast_counter -k+1 != slow_counter)
            {
                slow = slow.next;
                slow_counter++;
                if (fast_counter - k+1 == slow_counter)
                {
                    end_kNode = slow;
                }
            }

            int temp = begin_kNode.val;
            begin_kNode.val = end_kNode.val  ;
            end_kNode.val= temp;


            return head;
        }
    }
}
