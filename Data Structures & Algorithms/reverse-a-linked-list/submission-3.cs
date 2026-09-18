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
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        Stack<ListNode> stack = new();
        ListNode list = new();
        ListNode node = list;

        while (head != null)
        {
            stack.Push(head);
            head = head.next;
        }

        while (stack.Count > 0)
        {
            node.next = stack.Pop();
            node = node.next;

            if(stack.Count == 0)
                node.next = null;
        }

        return list.next;

          
    }
}
