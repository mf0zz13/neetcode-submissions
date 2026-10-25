class Solution {
public:
    int calPoints(vector<string>& operations) {
        stack<int> _stack;
        int score = 0;

        for(int i=0; i<operations.size();i++) {
            if (operations[i] == "+") {
                int j = _stack.top();
                _stack.pop();
                int k = j + _stack.top();
                _stack.push(j);
                _stack.push(k);
            }
            else if(operations[i] == "D") {
                _stack.push(_stack.top() * 2);
            }
            else if(operations[i] == "C") {
                _stack.pop();
            }
            else {
                _stack.push(stoi(operations[i]));
            }
        }
       
       while (!_stack.empty()){
        score += _stack.top();
        _stack.pop();
       }
        return score;
    }
};