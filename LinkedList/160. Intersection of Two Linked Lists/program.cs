/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lenA = GetListLength(headA);
        int lenB = GetListLength(headB);

        while (lenA > lenB) 
        {
            lenA--;
            headA = headA.next;
        }

        while (lenB > lenA) 
        {
            lenB--;
            headB = headB.next;
        }

        // Move both pointers until they meet (or reach null)
        while (headA != headB) 
        {
            headA = headA.next;
            headB = headB.next;
        }

        return headA; // Either the intersection node or null
    }

    private int GetListLength(ListNode head) 
    {
        int len = 0;

        while (head != null) 
        {
            len++;
            head = head.next;
        }

        return len;
    }
        
    
}
    
