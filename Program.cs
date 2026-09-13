using Data_Structure.BinarySearch;
using Data_Structure.InsertionSort;
using Data_Structure.Merge_Sort;
using Data_Structure.LinkedList;
using Data_Structure.Queue;
using Data_Structure.Stack;
using Data_Structure.Tree;

using Algorithms.TreeTraversal;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Merge Sort =====
            int[] arr = { 8, 3, 5, 4, 2, 1 };

            Console.WriteLine(
                "Before MergeSort: " + string.Join(", ", arr)
            );

            MergeSort.Sort(arr);

            Console.WriteLine(
                "After MergeSort:  " + string.Join(", ", arr)
            );

            Console.WriteLine();

            // ===== Insertion Sort =====
            int[] arr1 = { 8, 3, 5, 4, 2, 1 };

            Console.WriteLine(
                "Before InsertionSort: " + string.Join(", ", arr1)
            );

            insertionsort.Sort(arr1);

            Console.WriteLine(
                "After InsertionSort:  " + string.Join(", ", arr1)
            );

            Console.WriteLine();

            // ===== Binary Search =====
            int[] arr3 = { 1, 3, 4, 5, 6, 7, 8 };
            int target = 5;

            int index = binarysearch.Search(arr3, target);

            if (index != -1)
            {
                Console.WriteLine(
                    $"Element {target} found at index: {index}"
                );
            }
            else
            {
                Console.WriteLine(
                    $"Element {target} not found in the array"
                );
            }

            Console.WriteLine();

            // ===== Data Structure Tests =====
            Console.WriteLine("Choose Test:");
            Console.WriteLine("1 - LinkedList");
            Console.WriteLine("2 - Stack");
            Console.WriteLine("3 - Queue");
            Console.WriteLine("4 - Tree");
            Console.WriteLine("5 - Tree Traversal");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            switch (choice)
            {
                case 1:
                    TestLinkedList();
                    break;

                case 2:
                    TestStack();
                    break;

                case 3:
                    TestQueue();
                    break;

                case 4:
                    TestTree();
                    break;

                case 5:
                    TestTreeTraversal();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // ===== LinkedList Test =====
        static void TestLinkedList()
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.Add(new Employee(1, "Ahmed", 5000));
            list.Add(new Employee(2, "Ali", 6000));
            list.Add(new Employee(3, "Mona", 7000));

            Console.WriteLine("Forward:");
            list.PrintForward();

            Console.WriteLine("Backward:");
            list.PrintBackward();
        }

        // ===== Stack Test =====
        static void TestStack()
        {
            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Peek: " + stack.Peek());

            stack.Print();
        }

        // ===== Queue Test =====
        static void TestQueue()
        {
            MyQueue queue = new MyQueue(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Dequeue: " + queue.Dequeue());

            queue.Print();
        }

        // ===== Binary Tree Test =====
        static void TestTree()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(7);

            Console.WriteLine("Binary Search Tree created.");
            Console.WriteLine("Root: " + tree.Root.Data);
        }

        // ===== Tree Traversal Test =====
        static void TestTreeTraversal()
        {
            // Create a generic tree
            var root = new TreeTraversal.TreeNode<int>(10);

            root.Left = new TreeTraversal.TreeNode<int>(5);
            root.Right = new TreeTraversal.TreeNode<int>(15);

            root.Left.Left = new TreeTraversal.TreeNode<int>(3);
            root.Left.Right = new TreeTraversal.TreeNode<int>(7);

            Console.WriteLine("Tree Traversal:");

            Console.WriteLine(
                "PreOrder:  " +
                string.Join(" ", TreeTraversal.PreOrder(root))
            );

            Console.WriteLine(
                "InOrder:   " +
                string.Join(" ", TreeTraversal.InOrder(root))
            );

            Console.WriteLine(
                "PostOrder: " +
                string.Join(" ", TreeTraversal.PostOrder(root))
            );

            Console.WriteLine(
                "LevelOrder:" +
                string.Join(" ", TreeTraversal.LevelOrder(root))
            );
        }
    }
}