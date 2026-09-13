namespace Data_Structure.Tree
{
    public class BinaryTree
    {
        public TreeNode Root;

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }

        private TreeNode InsertRec(TreeNode root, int data)
        {
            if (root == null)
                return new TreeNode(data);

            if (data < root.Data)
                root.Left = InsertRec(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRec(root.Right, data);

            return root;
        }
    }
}