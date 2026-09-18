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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new();
        List<List<int>> levels = new();
        Queue<TreeNode> q = new();

        if (root == null)
            return res;
        
        q.Enqueue(root);

        while (q.Count > 0)
        {
            List<int> tempList = new();
            for (int i = q.Count; i > 0; i--)
            {
                var pos = q.Dequeue();
                tempList.Add(pos.val);

                if (pos.left != null)
                    q.Enqueue(pos.left);
                if (pos.right != null)
                    q.Enqueue(pos.right);
            }

            if (tempList.Count > 0)
                levels.Add(tempList);
        }

        foreach (var level in levels)
            res.Add(level[level.Count - 1]);
        
        return res;        
    }
}
