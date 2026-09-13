using System.Collections.Generic;

namespace Algorithms.TreeTraversal
{
    public static class TreeTraversal
    {
        // Generic tree node used by the traversal algorithms
        public sealed class TreeNode<T>
        {
            public T Value { get; }

            public TreeNode<T>? Left { get; set; }

            public TreeNode<T>? Right { get; set; }

            public TreeNode(T value)
            {
                Value = value;
            }
        }

        // Root → Left → Right
        public static IEnumerable<T> PreOrder<T>(TreeNode<T>? root)
        {
            if (root is null)
                yield break;

            yield return root.Value;

            foreach (var value in PreOrder(root.Left))
                yield return value;

            foreach (var value in PreOrder(root.Right))
                yield return value;
        }

        // Left → Root → Right
        public static IEnumerable<T> InOrder<T>(TreeNode<T>? root)
        {
            if (root is null)
                yield break;

            foreach (var value in InOrder(root.Left))
                yield return value;

            yield return root.Value;

            foreach (var value in InOrder(root.Right))
                yield return value;
        }

        // Left → Right → Root
        public static IEnumerable<T> PostOrder<T>(TreeNode<T>? root)
        {
            if (root is null)
                yield break;

            foreach (var value in PostOrder(root.Left))
                yield return value;

            foreach (var value in PostOrder(root.Right))
                yield return value;

            yield return root.Value;
        }

        // Level by level
        public static IEnumerable<T> LevelOrder<T>(TreeNode<T>? root)
        {
            if (root is null)
                yield break;

            var queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                yield return node.Value;

                if (node.Left is not null)
                    queue.Enqueue(node.Left);

                if (node.Right is not null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}