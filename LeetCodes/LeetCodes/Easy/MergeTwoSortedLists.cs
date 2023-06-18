using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes.Easy
{
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

    class MergeTwoSortedLists
    {
         public ListNode MergeTwoLists(ListNode list1, ListNode list2)
         {
            var listDum = new ListNode();
            var current = listDum;

            while(list1 != null && list2 != null)
            {
                var _listDum2 = list1.val <= list2.val;
                var nextNode = _listDum2 ? list1 : list2;

                current.next = nextNode;
                current = current.next;

                (list1, list2) = _listDum2 ? (list1.next, list2) : (list1, list2.next);
            }

            current.next = list1 ?? list2;

            return listDum.next;
         }



    }



}
