using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class BinaryTreeBase<T>
{
    private protected BinaryTreeNode<T> _root;    
    public BinaryTreeBase(BinaryTreeNode<T> root)
    {
        _root = root;
    }
    public void InOrder()
    {
        Console.WriteLine("in order: ");
        if (_root is null)
            return;
        BinaryTreeNode<T> currentRoot = _root;
        InOrderTraversal(currentRoot);
        Console.WriteLine();
    }
    private void InOrderTraversal(BinaryTreeNode<T> root)
    {
        if (root.Left is not null)
            InOrderTraversal(root.Left);
        Console.Write(root.Data + " ");
        if (root.Right is not null)
            InOrderTraversal(root.Right);
    }

    public void PreOrder()
    {
        Console.WriteLine("pre order: ");
        if (_root is null)
            return;
        BinaryTreeNode<T> currentRoot = _root;
        PreOrderTraversal(currentRoot);
        Console.WriteLine();
    }

    private void PreOrderTraversal(BinaryTreeNode<T> root)
    {
        Console.Write(root.Data + " ");
        if (root.Left is not null)
            PreOrderTraversal(root.Left);
        if (root.Right is not null)
            PreOrderTraversal(root.Right);
    }

    public void PostOrder()
    {
        Console.WriteLine("post order: ");
        if (_root is null)
            return;
        BinaryTreeNode<T> currentRoot = _root;
        PostOrderTraversal(currentRoot);
        Console.WriteLine();
    }

    private void PostOrderTraversal(BinaryTreeNode<T> root)
    {
        if (root.Left is not null)
            PostOrderTraversal(root.Left);
        if (root.Right is not null)
            PostOrderTraversal(root.Right);
        Console.Write(root.Data + " ");
    }

}
