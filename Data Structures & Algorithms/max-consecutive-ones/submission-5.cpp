class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int maxConsecutive = 0;
        int temp = 0;

        for (int i=0; i < nums.size();i++) {
        temp = nums[i] == 1? temp+=1 : 0;
        maxConsecutive = max(temp,maxConsecutive); 
        }
        return maxConsecutive;
    }
};