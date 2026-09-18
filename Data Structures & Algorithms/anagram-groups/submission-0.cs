public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> words = new();
        List<List<string>> returnList = new();

        foreach(string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            if (words.ContainsKey(sorted))
                words[sorted].Add(s);
            else
            {
                List<string> temp = new() { s };
                words.Add(sorted, temp);
            }
        }

        foreach(var kvp in words)
        {
            returnList.Add(kvp.Value);
        }

        return returnList;
    }
}
