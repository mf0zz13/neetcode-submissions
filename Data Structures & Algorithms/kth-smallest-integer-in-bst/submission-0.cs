/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        List<int> nums = new();
        DFS (root, nums);
        return nums[k-1];
                
    }

    public static void DFS(TreeNode root, List<int> nums)
    {
        if (root == null)
            return;
        
        DFS(root.left, nums);
        nums.Add(root.val);
        DFS(root.right, nums);
    }

}
