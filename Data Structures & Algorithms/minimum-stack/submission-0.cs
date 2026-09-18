public class MinStack {
    int[] stack;
    int length = 0;
    int minVal;

    public MinStack() {
        stack = new int[2];
    }
    
    public void Push(int val) {
        if ((length + 1) == stack.Length)
        {
            int[] temp = new int[stack.Length * 2];

            for (int i = 0; i < stack.Length; i++)
            {
                temp[i] = stack[i];
            }

            stack = temp;
        }

        stack[length] = val;
        length++;
    }
        
    
    public void Pop() {
        length--;
    }
    
    public int Top() {
        return stack[length - 1];
    }
    
    public int GetMin() {
        minVal = stack[0];

        for (int i = 0; i < length; i++)
        {
            if (stack[i] < minVal)
                minVal = stack[i];
        }

        return minVal;
    }
}
