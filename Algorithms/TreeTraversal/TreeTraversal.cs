using Data_Structure.Tree;
using System.Collections.Generic;

namespace Algorithms.TreeTraversal;

public static class TreeTraversal
{
    public static IEnumerable<int> PreOrder(TreeNode? root)
    {
        if (root is null) yield break;

        yield return root.Data;

        foreach (var value in PreOrder(root.Left))
            yield return value;

        foreach (var value in PreOrder(root.Right))
            yield return value;
    }

    public static IEnumerable<int> InOrder(TreeNode? root)
    {
        if (root is null) yield break;

        foreach (var value in InOrder(root.Left))
            yield return value;

        yield return root.Data;

        foreach (var value in InOrder(root.Right))
            yield return value;
    }

    public static IEnumerable<int> PostOrder(TreeNode? root)
    {
        if (root is null) yield break;

        foreach (var value in PostOrder(root.Left))
            yield return value;

        foreach (var value in PostOrder(root.Right))
            yield return value;

        yield return root.Data;
    }

    public static IEnumerable<int> LevelOrder(TreeNode? root)
    {
        if (root is null) yield break;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            yield return node.Data;

            if (node.Left is not null)
                queue.Enqueue(node.Left);

            if (node.Right is not null)
                queue.Enqueue(node.Right);
        }
    }
}