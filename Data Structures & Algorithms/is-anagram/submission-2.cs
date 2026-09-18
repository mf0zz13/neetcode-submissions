public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char> chars = new();

        if (s.Length < t.Length)
        {
            string temp = s;
            s = t;
            t = temp;
        }

        foreach(char c in s)
            chars.Add(c);

        foreach(char c in t)
        {
            if (chars.Contains(c))
                chars.Remove(c);
        }

        if (chars.Count > 0)
            return false;
        
        return true;
    }
}
