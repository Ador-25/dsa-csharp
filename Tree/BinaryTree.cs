using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class BinaryTree<T> : BinaryTreeBase<T>,IBinaryTree<T>
{
    private readonly HashSet<BinaryTreeNode<T>> _nodes = new();
    public BinaryTree(BinaryTreeNode<T> root):base(root){}

    public bool ElementExists(T key)
    {
        if (_root is null)
            return false;
        BinaryTreeNode<T> currentNode = _root;
        _nodes.Add(currentNode);
        return searchElement(key,currentNode);
    }
    private bool searchElement(T key,BinaryTreeNode<T> currentNode)
    {
        if (currentNode is null)
            return false;
        if (currentNode.Data.Equals(key))
            return true;
        return searchElement(key,currentNode.Left) || searchElement(key,currentNode.Right);
    }
}
