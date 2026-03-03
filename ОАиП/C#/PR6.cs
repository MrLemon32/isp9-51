using System;
using System.Collections.Generic;

class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
    }
}

class BinaryTree
{
    public Node Root;

    public void InsertLevelOrder(int value)
    {
        if (Root == null)
        {
            Root = new Node(value);
            return;
        }

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(Root);

        while (q.Count > 0)
        {
            Node cur = q.Dequeue();

            if (cur.Left == null)
            {
                cur.Left = new Node(value);
                return;
            }
            else
            {
                q.Enqueue(cur.Left);
            }

            if (cur.Right == null)
            {
                cur.Right = new Node(value);
                return;
            }
            else
            {
                q.Enqueue(cur.Right);
            }
        }
    }

    public bool Contains(int value)
    {
        if (Root == null) return false;

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(Root);

        while (q.Count > 0)
        {
            Node cur = q.Dequeue();
            if (cur.Value == value) return true;

            if (cur.Left != null) q.Enqueue(cur.Left);
            if (cur.Right != null) q.Enqueue(cur.Right);
        }

        return false;
    }

    public void Preorder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        Preorder(node.Left);
        Preorder(node.Right);
    }

    public void Inorder(Node node)
    {
        if (node == null) return;
        Inorder(node.Left);
        Console.Write(node.Value + " ");
        Inorder(node.Right);
    }

    public void Postorder(Node node)
    {
        if (node == null) return;
        Postorder(node.Left);
        Postorder(node.Right);
        Console.Write(node.Value + " ");
    }

    public void LevelOrder()
    {
        if (Root == null) return;

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(Root);

        while (q.Count > 0)
        {
            Node cur = q.Dequeue();
            Console.Write(cur.Value + " ");

            if (cur.Left != null) q.Enqueue(cur.Left);
            if (cur.Right != null) q.Enqueue(cur.Right);
        }
    }

    public int Sum()
    {
        if (Root == null) return 0;

        int total = 0;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(Root);

        while (q.Count > 0)
        {
            Node cur = q.Dequeue();
            total += cur.Value;

            if (cur.Left != null) q.Enqueue(cur.Left);
            if (cur.Right != null) q.Enqueue(cur.Right);
        }

        return total;
    }

    public int CountEven()
    {
        if (Root == null) return 0;

        int count = 0;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(Root);

        while (q.Count > 0)
        {
            Node cur = q.Dequeue();
            if (cur.Value % 2 == 0) count++;

            if (cur.Left != null) q.Enqueue(cur.Left);
            if (cur.Right != null) q.Enqueue(cur.Right);
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();

        Console.WriteLine("Введите 7 чисел:");

        for (int i = 0; i < 7; i++)
        {
            int value = int.Parse(Console.ReadLine());
            tree.InsertLevelOrder(value);
        }

        Console.WriteLine("Обход по уровням:");
        tree.LevelOrder();
        Console.WriteLine();

        Console.WriteLine("Сумма всех значений: " + tree.Sum());
        Console.WriteLine("Количество чётных чисел: " + tree.CountEven());
    }
}