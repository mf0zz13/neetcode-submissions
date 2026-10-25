class Solution {
public:
    vector<int> getConcatenation(vector<int>& nums) {
        int numsSize = nums.size();
        vector<int> newVector(numsSize * 2);

        for(int i=0; i < numsSize; i++) {
            newVector[i] = nums[i];
            newVector[i + numsSize] = nums[i];
        }

        return newVector;
    }    
};