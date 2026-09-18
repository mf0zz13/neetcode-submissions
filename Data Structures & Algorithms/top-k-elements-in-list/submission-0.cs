public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new();
        int[] returnArray = new int[k];
        int counter = 0;

        foreach(int num in nums)
        {
            if (count.ContainsKey(num))
                count[num] += 1;
            else
                count.Add(num, 1);
        }

       
        foreach (var num in count.OrderByDescending(x => x.Value))
        {
            returnArray[counter] = num.Key;
            counter++;
            if (counter == k)
                break;
        }

        return returnArray;
    }
}
