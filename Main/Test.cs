using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;
using Graph;
using _io = FastIO.Output;

namespace Main;

internal class Test
{
    public static void TestSinglyLinkedList()
    {
        SinglyLinkedList<int> linkedListOfInts = new SinglyLinkedList<int>();
        linkedListOfInts.AddFirst(1);
        linkedListOfInts.AddFirst(2);
        linkedListOfInts.AddLast(3);
        linkedListOfInts.PrintList();
        SinglyLinkedList<string> linkedListOfStrings = new();
        linkedListOfStrings.AddFirst("Hello");
        linkedListOfStrings.AddLast("World!");
        linkedListOfStrings.AddFirst("_");
        linkedListOfStrings.RemoveFirst();
        linkedListOfStrings.RemoveLast();
        linkedListOfStrings.PrintList();
    }

    public static void TestTree()
    {
        Tree<string> tree = new Tree<string>();

        // level 3
        TreeNode<string> n6 = new TreeNode<string>() { Data = "#1=3 n6" };
        TreeNode<string> n8 = new TreeNode<string>() { Data = "#1=3 n8" };

        // level 2
        TreeNode<string> n7 = new TreeNode<string>() { Data = "#1=2 n7" };
        TreeNode<string> n4 = new TreeNode<string>() { Data = "#1=2 n4" };
        TreeNode<string> n5 = new("#1=2 n5", [n8, n6]);

        // level 1
        TreeNode<string> n1 = new("#l=1 n1");
        TreeNode<string> n2 = new("#l=1 n2");
        TreeNode<string> n3 = new("#1=1 n3");

        // root_children = [1,2,3]
        TreeNode<string> root = new TreeNode<string>("root", [n1,n2,n3]);

        tree.AddRoot(root); // r > 1,2,3
        n1.AddChild(n7);
        n3.AddChild(n4);
        n3.AddChild(n5); 

        // bfs = r, 1,2,3, 7,4,5, 6,8 
        // dfs = r,1,7,4,5,8,6
        tree.PrintBFS();
        tree.PrintDFS();

    }

    private static List<BinaryTreeNode<int>> getRoots()
    {
        List<BinaryTreeNode<int>> result = new();
        BinaryTreeNode<int> root;
        root = new(data: 0);
        root.Left = new(data: 1);
        root.Right = new(data: 2);
        root.Left.Left = new(data: 4);
        root.Left.Right = new(data: 5);
        root.Left.Right.Left = new(data: 6);
        root.Left.Left.Left = new(data: 11, left: 11, right: 11);

        result.Add(root);

        root = new BinaryTreeNode<int>(0);
        root.Left = new BinaryTreeNode<int>(1);
        root.Right = new BinaryTreeNode<int>(2);
        root.Left.Left = new BinaryTreeNode<int>(4);
        root.Left.Right = new BinaryTreeNode<int>(5);
        root.Left.Right.Left = new BinaryTreeNode<int>(6);

        result.Add(root);

        return result;

    }

    public static void TestBinaryTree()
    {
        var roots = getRoots();
        roots.ForEach(root => {
            BinaryTree<int> bt = new(root);
            bt.InOrder();
            bt.PreOrder();
            bt.PostOrder();
            Console.WriteLine(bt.ElementExists(11));
        });

    }

    public static void TestGraph()
    {
        Graph.Node<int> n0 = new(0);
        Graph.Node<int> n1 = new(1);
        Graph.Node<int> n2 = new(2);
        Graph.Node<int> n3 = new(3);
        Graph.Node<int> n4 = new(4);
        Graph.Node<int> n5 = new(5);
        Graph.Node<int> n6 = new(6);

        Graph<int> graph = new();
        graph.AddEdge(n0, n1,4);
        graph.AddEdge(n0, n2,2);
        graph.AddEdge(n1, n2,1);
        graph.AddEdge(n1, n3,2);
        graph.AddEdge(n2, n4,1);
        graph.AddEdge(n3, n4,3);
        n1.PrintNeighbours();
        n0.PrintNeighbours();

        graph.DFS(n0);
        graph.BFS(n1);
        graph.RecursiveDFS(n3);
    }

}
