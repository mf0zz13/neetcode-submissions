public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new();

        foreach(char c in s.ToLower())
        {
            if(Char.IsLetterOrDigit(c))
                sb.Append(c);
        }

        string t = sb.ToString();

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] != t[t.Length - (1 + i)])
                return false;
        }
        return true;
    }
}
