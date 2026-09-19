public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1){
            arr[0] = -1;
            return arr;
        }
        for(int i=0; i < arr.Length-1; i++) {
            int max = -1;
            for(int j=i+1; j< arr.Length;j++) {
                max = Math.Max(max, arr[j]);
            }
            arr[i] = max;
        }
        arr[arr.Length-1] = -1;
        return arr;
    }
}