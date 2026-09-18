public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> counts = new();

        foreach (int num in nums)
        {
            if (counts.ContainsKey(num))
                return true;
            else
                counts.Add(num,1);
        }

        return false;
    }
}
