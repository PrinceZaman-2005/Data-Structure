using Data_Structure.BinarySearch;
using Data_Structure.TreeTraversal;
using Data_Structure.InsertionSort;
using Data_Structure.Merge_Sort;
using Data_Structure.LinkedList;
using Data_Structure.Queue;
using Data_Structure.Stack;
using Data_Structure.Tree;

namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        // =========================================
        // Main Menu
        // =========================================

        static void RunMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine(" Data Structures & Algorithms");
                Console.WriteLine("=================================");
                Console.WriteLine("1 - Merge Sort");
                Console.WriteLine("2 - Insertion Sort");
                Console.WriteLine("3 - Binary Search");
                Console.WriteLine("4 - LinkedList");
                Console.WriteLine("5 - Stack");
                Console.WriteLine("6 - Queue");
                Console.WriteLine("7 - Tree");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("=================================");
                Console.Write("Choose Test: ");

                string? input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
                    case "1":
                        TestMergeSort();
                        break;

                    case "2":
                        TestInsertionSort();
                        break;

                    case "3":
                        TestBinarySearch();
                        break;

                    case "4":
                        TestLinkedList();
                        break;

                    case "5":
                        TestStack();
                        break;

                    case "6":
                        TestQueue();
                        break;

                    case "7":
                        TestTree();
                        break;

                    case "0":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }

        // =========================================
        // Algorithms
        // =========================================

        static void TestMergeSort()
        {
            int[] arr = { 8, 3, 5, 4, 2, 1 };

            Console.WriteLine("=== Merge Sort ===");
            Console.WriteLine("Before: " + string.Join(", ", arr));

            MergeSort.Sort(arr);

            Console.WriteLine("After:  " + string.Join(", ", arr));
        }

        static void TestInsertionSort()
        {
            int[] arr = { 8, 3, 5, 4, 2, 1 };

            Console.WriteLine("=== Insertion Sort ===");
            Console.WriteLine("Before: " + string.Join(", ", arr));

            insertionsort.Sort(arr);

            Console.WriteLine("After:  " + string.Join(", ", arr));
        }

        static void TestBinarySearch()
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 8 };
            int target = 5;

            Console.WriteLine("=== Binary Search ===");

            int index = binarysearch.Search(arr, target);

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
        }

        // =========================================
        // Linked List
        // =========================================

        static void TestLinkedList()
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.Add(new Employee(1, "Hi", 5000));
            list.Add(new Employee(2, "Hello", 6000));
            list.Add(new Employee(3, "Hey", 7000));

            Console.WriteLine("=== LinkedList ===");

            Console.WriteLine("Forward:");
            list.PrintForward();

            Console.WriteLine("Backward:");
            list.PrintBackward();
        }

        // =========================================
        // Stack
        // =========================================

        static void TestStack()
        {
            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("=== Stack ===");

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Peek: " + stack.Peek());

            Console.WriteLine("Stack:");
            stack.Print();
        }

        // =========================================
        // Queue
        // =========================================

        static void TestQueue()
        {
            MyQueue queue = new MyQueue(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("=== Queue ===");

            Console.WriteLine("Dequeue: " + queue.Dequeue());

            Console.WriteLine("Queue:");
            queue.Print();
        }

        // =========================================
        // Binary Tree + Tree Traversal
        // =========================================

        static void TestTree()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(7);

            Console.WriteLine("=== Binary Search Tree ===");
            Console.WriteLine("Root: " + tree.Root.Data);

            var root = new treetraversal.TreeNode<int>(10);

            root.Left = new treetraversal.TreeNode<int>(5);
            root.Right = new treetraversal.TreeNode<int>(15);

            root.Left.Left = new treetraversal.TreeNode<int>(3);
            root.Left.Right = new treetraversal.TreeNode<int>(7);

            Console.WriteLine();
            Console.WriteLine("=== Tree Traversals ===");

            Console.WriteLine(
                "PreOrder:   " +
                string.Join(" ", treetraversal.PreOrder(root))
            );

            Console.WriteLine(
                "InOrder:    " +
                string.Join(" ", treetraversal.InOrder(root))
            );

            Console.WriteLine(
                "PostOrder:  " +
                string.Join(" ", treetraversal.PostOrder(root))
            );

            Console.WriteLine(
                "LevelOrder: " +
                string.Join(" ", treetraversal.LevelOrder(root))
            );
        }
    }
}
