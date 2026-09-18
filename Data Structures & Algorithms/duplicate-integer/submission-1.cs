public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> numbers = new();

        foreach(int num in nums)
        {
            if (numbers.ContainsKey(num))
                return true;
            else
                numbers.Add(num, 1);
        }

        return false;
    }
}
