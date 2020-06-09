/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
    ListNode head = new ListNode();
    ListNode current = head;
    
    while (l1 != null && l2 != null) 
    {
        if (l1.val > l2.val)
        {
            current.next = new ListNode(l2.val);                
            l2 = l2.next;
        }
        else 
        {
            current.next = new ListNode(l1.val);                
            l1 = l1.next;
        }   
        current = current.next;
    }
    while (l1 != null)
    {
        current.next = new ListNode(l1.val);
        current = current.next;
        l1 = l1.next;
    }
        
    while (l2 != null)
    {
        current.next = new ListNode(l2.val);
        current = current.next;
        l2 = l2.next;
    }
    
    return head.next;
}