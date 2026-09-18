public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConsecutive = 0;
        int consecutive = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            consecutive = nums[i] == 1 ? consecutive+=1 : 0;
            maxConsecutive = Math.Max(consecutive, maxConsecutive);
        }
        return maxConsecutive;
    }
}