class Solution {
public:
    bool isValid(string s) {
        stack<char> _stack;

        if((s.size() % 2) != 0){
            return false;
        }

        for(int i=0; i< s.size();i++) {
            switch(s[i]){
                case ']':
                    if (_stack.empty() || _stack.top() != '['){
                        return false;
                    }
                    _stack.pop();
                    break;
                case '}':
                    if (_stack.empty() || _stack.top() != '{'){
                        return false;
                    }
                    _stack.pop();
                    break;
                case ')':
                    if (_stack.empty() || _stack.top() != '('){
                        return false;
                    }
                    _stack.pop();
                    break;
                default:
                    _stack.push(s[i]);
                    break;
            }           
        }

        if(!_stack.empty()) {
            return false;
        }
        return true;
    }
};
