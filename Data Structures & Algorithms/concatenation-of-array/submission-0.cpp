class Solution {
public:
    vector<int> getConcatenation(vector<int>& nums) {
        vector<int> newVector (nums.size() * 2);

        for(int i=0; i < nums.size(); i++) {
            newVector[i] = nums[i];
            newVector[nums.size()+i] = nums[i]; 
        }
        return newVector;
    }
};