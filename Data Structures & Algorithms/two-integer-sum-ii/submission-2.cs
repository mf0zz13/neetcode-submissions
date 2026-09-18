public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] nums = new int[2];

        int p1 = 0;
        int p2 = numbers.Length - 1;
        int sum = numbers[p1] + numbers[p2];

        do 
        {
            if (sum > target)
                p2--;
            else if (sum < target)
                p1++;
            else if (sum == target)
            {
                nums[0] = p1 + 1;
                nums[1] = p2 + 1;
                return nums;
            }

            sum = numbers[p1] + numbers[p2];
        }
        while (p1 != p2);

        return nums;
    }
}
