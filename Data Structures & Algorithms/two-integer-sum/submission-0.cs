public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] returnVal =  new int[2];

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    returnVal[0] = i;
                    returnVal[1] = j;
                    return returnVal;
                }
            }
        }

        return returnVal;
    }
}
