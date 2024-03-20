using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

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
}
