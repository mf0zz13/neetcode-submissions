class MinStack {
public:
    vector<int> arr;
    
    MinStack() {
    }
    
    void push(int val) {
        arr.push_back(val);
    }
    
    void pop() {
        arr.pop_back();
    }
    
    int top() {
        return(arr[arr.size()-1]);
    }
    
    int getMin() {
        int min = top();
        for(int i = 0; i< arr.size();i++){
            min = min < arr[i]? min: arr[i];
        }
        return min;
    }
};
