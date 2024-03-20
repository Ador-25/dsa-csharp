using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class Tree<T> : ITree<T>
{
    private TreeNode<T> Root = null;

    public void AddRoot(TreeNode<T> node)
    {
        Root = node;
    }

    public void PrintBFS()
    {
        if (Root is null)
        {
            return;
        }
        TreeNode<T> currentNode = Root;
        BFS(currentNode);
    }
    public void PrintDFS()
    {
        if(Root is null)
        {
            return;
        }
        TreeNode<T> currentNode = Root;
        DFS(currentNode);
    }

    private void BFS(TreeNode<T> root)
    {
        StringBuilder sb = new StringBuilder();
        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode<T> current = queue.Dequeue();
            sb.Append(current.Data + " ");
            foreach (TreeNode<T> child in current.GetChildrenNodes())
            {
                queue.Enqueue(child);
            }
        }
        Console.WriteLine(sb.ToString());
    }
    private void DFS(TreeNode<T> root)
    {
        StringBuilder sb = new StringBuilder();
        Stack<TreeNode<T>> nodes = new Stack<TreeNode<T>>();
        nodes.Push(root);

        while (nodes.Count > 0) 
        { 
            TreeNode<T> node = nodes.Pop();
            sb.Append(node.Data+" ");
            if (node.HasChildren())
            {
                foreach(TreeNode<T> child in node.GetChildrenNodes())
                {
                    nodes.Push(child);
                }
            }
        }
        Console.WriteLine(sb.ToString());
    }
    

}
