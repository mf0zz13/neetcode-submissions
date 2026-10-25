class MinStack {
public:
    stack<int> _stack;
    MinStack() {
    }
    
    void push(int val) {
        _stack.push(val);
    }
    
    void pop() {
        _stack.pop();
    }
    
    int top() {
        return _stack.top();
    }
    
    int getMin() {
        stack<int> tempStack;
        int minNum = _stack.top();

        while(!_stack.empty()) {
            tempStack.push(_stack.top());
            minNum = min(minNum, _stack.top());
            _stack.pop();
        }

        while(!tempStack.empty()) {
            _stack.push(tempStack.top());
            tempStack.pop();
        }

        return minNum;
    }
};
