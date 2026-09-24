class Solution {
public:
    int calPoints(vector<string>& operations) {
        stack<int> _stack;

        for(int i=0; i< operations.size(); i++) {
            string var = operations[i];

            if(var == "+") {
                int nums[2];
                stack<int> tempStack(_stack);

                for (int i=0; i < 2; i++) {
                    nums[i] = tempStack.top();
                    tempStack.pop();
                }

                _stack.push(nums[0] + nums[1]);
            }
            else if(var == "D") {
                _stack.push(_stack.top() * 2);
            }
            else if(var == "C") {
                _stack.pop();
            }
            else {
                _stack.push(stoi(var));
            }
        }

        int returnNum = 0;

        while(!_stack.empty()) {
            returnNum += _stack.top();
            _stack.pop();
        }

        return returnNum;
    }
};