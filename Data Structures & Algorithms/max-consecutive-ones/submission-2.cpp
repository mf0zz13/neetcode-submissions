class Solution {
public:
    int findMaxConsecutiveOnes(vector<int>& nums) {
        int maxConsecutive = 0;
            int size = nums.size();

            for (int i=0; i < size; i++) {

                if (nums[i] == 1) {

                    int j = 0;

                    do {
                        j++;
                        i+=1;
                    } while (i != size && nums[i] == 1);

                    maxConsecutive = j > maxConsecutive? j : maxConsecutive;
                }
            }
            return maxConsecutive;
    }
};