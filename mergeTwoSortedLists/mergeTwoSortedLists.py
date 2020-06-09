# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
    head = ListNode()
    current = head
    
    while (l1 != None and l2 != None):
        if (l1.val > l2.val):
            current.next = ListNode(l2.val)
            l2 = l2.next
            
        else:
            current.next = ListNode(l1.val)                
            l1 = l1.next
            
        current = current.next               
    
    while (l1 != None):
        current.next = ListNode(l1.val)
        l1 = l1.next
        current = current.next
        
    while (l2 != None):            
        current.next = ListNode(l2.val)
        l2 = l2.next
        current = current.next
    
    return head.next