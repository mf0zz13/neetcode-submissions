public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        List<List<int>> returnList = new();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
                continue;

            int p1 = i + 1;
            int p2 = nums.Length - 1;

            while (p1 != p2)
            {
                int sum = nums[i] + nums[p1] + nums[p2];

                if (sum == 0)
                {
                    int[] tempList = { nums[i], nums[p1], nums[p2] };
                    if (returnList.Count > 0)
                    {
                        if (returnList[returnList.Count - 1].SequenceEqual(tempList.ToList()))
                        {
                            p1++;
                            continue;
                        }
                    }
                    returnList.Add(tempList.ToList());
                    p1++;
                }
                else if (sum > 0)
                    p2--;
                else if (sum < 0)
                    p1++;
            }
        }

        return returnList;
    }
}
