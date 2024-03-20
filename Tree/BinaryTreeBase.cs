using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class BinaryTreeBase<T>
{
    private BinaryTreeNode<T> _root;    
    public BinaryTreeBase(BinaryTreeNode<T> root)
    {
        _root = root;
    }
    public bool ElementExists(T key)
    {
        throw new NotImplementedException();
    }

    public void InOrder()
    {
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

    public void PostOrder()
    {
        throw new NotImplementedException();
    }

    public void PreOrder()
    {
        throw new NotImplementedException();
    }
}
