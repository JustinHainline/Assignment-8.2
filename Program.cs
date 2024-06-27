namespace Assignment_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var stack = new Stack<(TreeNode, TreeNode)>();
            stack.Push((root.left, root.right));

            while (stack.Any())
            {
                switch (stack.Pop())
                {
                    case (null, null):
                        continue;

                    case (null, _) or (_, null):
                        return false;

                    case (TreeNode l, TreeNode r) when l.val != r.val:
                        return false;

                    case (TreeNode l, TreeNode r) when l.val == r.val:
                        stack.Push((l.left, r.right));
                        stack.Push((l.right, r.left));
                        break;
                }
            }

            return true;
        }
    }
}

