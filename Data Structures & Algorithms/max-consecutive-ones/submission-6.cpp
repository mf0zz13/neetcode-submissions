class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
       int maxNum = 0;
       int j = 0;

       for(int i=0; i < nums.size(); i++){
        j = nums[i] == 1? j + 1 : 0;
        maxNum = max(maxNum,j);
       }
       return maxNum;
    }
};