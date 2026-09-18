public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        Dictionary<char,char> parentheses = new()
            {
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };

        if (s.Length % 2 > 0)
            return false;

        foreach(char c in s)
        {
            if (parentheses.ContainsKey(c))
                stack.Push(c);
            else if (stack.Count > 0 && parentheses.ContainsValue(c))
            {
                if (!(parentheses[stack.Pop()] == c))
                    return false;
            }
            else
                return false;

        }

        if (stack.Count > 0)
            return false;

        return true;
    }
}
