/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        stack<ListNode*> _stack;
        ListNode* currNode = head;

        if (head == nullptr) {
            return head;
        }

        while(currNode != nullptr) {
            _stack.push(currNode);
            currNode = currNode->next;
        }
        
        head->next = nullptr;
        head = _stack.top();
        currNode = head;
        _stack.pop();

        while(!_stack.empty()) {
            currNode->next = _stack.top();
            _stack.pop();
            currNode = currNode->next;    
        }

        return head;
    }
};
