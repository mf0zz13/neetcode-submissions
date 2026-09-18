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
        ListNode pre = null;
        ListNode currNode = head;

        while (currNode != null)
        {
            ListNode temp = currNode.next;
            currNode.next = pre;
            pre = currNode;
            currNode = temp;
        }

        return pre;
    }
}
