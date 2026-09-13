

# 📚 C# Data Structures & Algorithms — Documentation & Notes

This document provides a beginner-friendly conceptual guide to the
data structures and algorithms included in this repository.

The goal is not only to read the code, but to understand **what each
structure or algorithm is doing, why it works, and where it is useful**.

---

## 🗂️ Contents

### Data Structures
- [Linked List]
- [Stack]
- [Queue]
- [Binary Tree]

### Algorithms
- [Binary Search]
- [Tree Traversal]
- [Insertion Sort]
- [Merge Sort]

---

# 🔗 Linked List

A **Linked List** is a linear data structure made from individual
nodes.

Each node generally contains:

```text
┌─────────┬─────────┐
│  Data   │  Next   │
└─────────┴─────────┘
```

The `Next` reference points to another node.

For example:

```text
[10] → [20] → [30] → null
```

The final node points to `null`, indicating the end of the list.

## How it differs from an array

An array stores elements by index:

```text
[10] [20] [30] [40]
  0    1    2    3
```

A linked list connects elements through references:

```text
[10] → [20] → [30] → [40]
```

This makes the two structures useful for different situations.

## Common operations

- Insert
- Delete
- Search
- Traverse

## Mental model

Think of a linked list as a **chain**.

Each link knows where the next link is.

---

# 📚 Stack

A **Stack** is a linear data structure that follows:

> **LIFO — Last In, First Out**

The most recently added element is removed first.

```text
      ┌──────┐
      │  30  │ ← Pop
      ├──────┤
      │  20  │
      ├──────┤
      │  10  │
      └──────┘
```

If we perform:

```text
Push(10)
Push(20)
Push(30)
```

The first element removed will be `30`.

## Main operations

### Push

Adds an element to the top.

### Pop

Removes the top element.

### Peek

Looks at the top element without removing it.

## Mental model

Think about a **stack of plates**.

You normally place a plate on top and remove the top plate first.

---

# 🚶 Queue

A **Queue** is a linear data structure that follows:

> **FIFO — First In, First Out**

The first element added is the first element removed.

```text
Front                         Rear
  ↓                             ↓
[10] → [20] → [30] → [40]
  ↑                             ↑
Dequeue                       Enqueue
```

If we perform:

```text
Enqueue(10)
Enqueue(20)
Enqueue(30)
```

The first element removed will be `10`.

## Main operations

### Enqueue

Adds an element to the rear of the queue.

### Dequeue

Removes an element from the front.

### Peek

Looks at the front element without removing it.

## Mental model

Think about people standing in a **line**.

The person who arrives first normally gets served first.

---

# 🌳 Binary Tree

A **Binary Tree** is a hierarchical data structure in which each node
can have at most two children.

Each node can have:

- No children
- One child
- Two children

## Important terms

### Root

The top node of the tree.

```text
             10  ← Root
```

### Child

A node directly connected below another node.

### Parent

A node directly above another node.

### Leaf

A node with no children.

In the example above:

```text
2, 7, 20
```

are leaf nodes.

---

# 🔄 Tree Traversal

Traversal means **visiting the nodes of a tree in a particular order**.

Three fundamental depth-first traversal methods are:

- Preorder
- Inorder
- Postorder


## Preorder

> **Root → Left → Right**

```text
10 → 5 → 2 → 7 → 15 → 20
```

The root is visited first.

---

## Inorder

> **Left → Root → Right**

```text
2 → 5 → 7 → 10 → 15 → 20
```

For a binary search tree, inorder traversal produces values in
sorted order when the tree satisfies the binary-search-tree property.

---

## Postorder

> **Left → Right → Root**

```text
2 → 7 → 5 → 20 → 15 → 10
```

The root is visited after both subtrees.

---

# 🔍 Binary Search

**Binary Search** is a searching algorithm designed for a **sorted**
collection.

Instead of checking every element one by one, it repeatedly divides
the search space.

For example:

```text
[1, 3, 5, 7, 9, 11, 13]
          ↑
        middle
```

If the target is larger than the middle value, the search can ignore
the left half.

If the target is smaller, it can ignore the right half.

The process continues until the value is found or the search space
becomes empty.

## Core idea

```text
Large search space
       ↓
Check middle
       ↓
Discard half
       ↓
Check middle again
       ↓
Discard half
       ↓
       ...
```

## Typical time complexity

**O(log n)**

This assumes the data is sorted and the implementation can access
the middle element efficiently.

---

# 📝 Insertion Sort

**Insertion Sort** builds a sorted portion of a collection one element
at a time.

Conceptually:

```text
Unsorted elements
       ↓
Take one element
       ↓
Find its position
       ↓
Insert it into the sorted portion
       ↓
Repeat
```

Example:

```text
[5, 3, 4, 1]

[5] [3, 4, 1]
 ↓
[3, 5] [4, 1]
 ↓
[3, 4, 5] [1]
 ↓
[1, 3, 4, 5]
```

Insertion Sort is simple and can be useful for small or nearly sorted
collections.

## Typical time complexity

- Best case: **O(n)** when the data is already sorted
- Average case: **O(n²)**
- Worst case: **O(n²)**

---

# 🔀 Merge Sort

**Merge Sort** uses a divide-and-conquer strategy.

It repeatedly divides a collection into smaller parts, sorts those
parts, and then merges them back together.

The smaller collections are then merged in sorted order:

```text
[8] + [3] → [3, 8]

[5] + [1] → [1, 5]

[3, 8] + [1, 5] → [1, 3, 5, 8]
```

## Core idea

```text
Divide
  ↓
Sort smaller parts
  ↓
Merge
  ↓
Sorted collection
```

## Typical time complexity

**O(n log n)**

Merge Sort generally requires additional memory for the merging
process, depending on the implementation.

---

# ⚖️ Quick Comparison

| Topic | Category | Main Idea |
|---|---|---|
| Linked List | Data Structure | Nodes connected by references |
| Stack | Data Structure | LIFO |
| Queue | Data Structure | FIFO |
| Binary Tree | Data Structure | Hierarchical nodes |
| Binary Search | Algorithm | Repeatedly divide a sorted search space |
| Insertion Sort | Algorithm | Insert elements into a sorted portion |
| Merge Sort | Algorithm | Divide, sort and merge |

---

# 🧠 Data Structure vs Algorithm

These two ideas are related but different.

### Data Structure

A **data structure** describes how data is organized and accessed.

Examples:

```text
Linked List
Stack
Queue
Binary Tree
```

### Algorithm

An **algorithm** describes a sequence of steps used to solve a
problem.

Examples:

```text
Binary Search
Insertion Sort
Merge Sort
```

A useful way to think about it:

> **Data structure = how we organize information**

> **Algorithm = how we process information**

---

# 🎯 Learning Approach

When studying these implementations, don't just memorize the method
names.

Try asking:

1. What problem is this structure solving?
2. How is the data represented?
3. Where is the next element stored?
4. What happens when an element is added?
5. What happens when an element is removed?
6. What is the cost of the operation?
7. What assumptions does the algorithm make?

Understanding these questions makes it easier to read unfamiliar
implementations later.

---
