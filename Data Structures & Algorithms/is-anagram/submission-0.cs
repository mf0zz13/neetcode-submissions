public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> lettersS = FindCharCount(s);
        Dictionary<char, int> lettersT = FindCharCount(t);

        if (lettersT.Count > lettersS.Count)
        {
            Dictionary<char,int> tempDic = lettersS;
            lettersS = lettersT;
            lettersT = tempDic;
        }

        foreach (var kvp in lettersS)
        {
            if (!lettersT.ContainsKey(kvp.Key))
            {
                return false;
            }
            else if (lettersT[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }

        return true;        
    }

    public static Dictionary<char, int> FindCharCount(string s)
    {
        Dictionary<char, int> tempDic = new();

        foreach (char c in s)
        {
            if (tempDic.ContainsKey(c))
            {
                tempDic[c] += 1;
            }
            else 
            {
                tempDic.Add(c, 1);
            }
        }

        return tempDic;
    }
}
