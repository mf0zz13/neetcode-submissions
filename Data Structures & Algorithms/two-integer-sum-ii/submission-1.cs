public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] nums = new int[2];

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    nums[0] = i + 1;
                    nums[1] = j + 1;
                    return nums;
                }
            }
        }

        return nums;
    }
}
