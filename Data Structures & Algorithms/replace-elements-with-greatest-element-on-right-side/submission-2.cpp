class Solution {
public:
    vector<int> replaceElements(vector<int>& arr) {
        if(arr.size() == 1) {
            arr[0] = -1;
            return arr;
        }
        
        for(int i=0; i < arr.size()-1;i++) {
            int maxNum = arr[i+1];
            for(int j=i+1; j< arr.size();j++) {
                maxNum = max(maxNum, arr[j]);
            }
            arr[i] = maxNum;
        }
        arr[arr.size()-1] = -1;
        return arr;
    }
};